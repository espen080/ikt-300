using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MessageService;
using PSU;

namespace PSUManager
{
    internal class Manager
    {
        IMessageService messageService;
        Dictionary<int, IPSU> PSUs;
        List<int> BroadcastList;
        string configFilePath;
        int frequency = 3;

        public Manager(IMessageService messageService, string configFilePath)
        {
            this.messageService = messageService;
            this.messageService.Connect(SubscriptionCallback);;
            PSUs = new Dictionary<int, IPSU>();
            BroadcastList = new List<int>();
            this.configFilePath = configFilePath;
            LoadConfig();
            string psuList = JsonConvert.SerializeObject(PSUs.Keys.ToList());
            messageService.Publish("PSU/LIST", psuList);
            messageService.Subscribe("PSU/+/#");
            messageService.Subscribe("PSU/FREQUENCY");
        }

        public void Broadcast()
        {
            Console.WriteLine("Updating PSU info");
            foreach ( int id in BroadcastList )
            {
                GetCurrent(id);
            }
            Thread.Sleep(frequency * 1000);
        }

        void SubscriptionCallback(string topic, string message)
        {
            if (topic.ToLower() == "psu/frequency")
            {
                int.TryParse(message, out frequency);
                Console.WriteLine(string.Format("Frequency set to {0}", frequency));
                return;
            }
            string[] topics = topic.Split("/");
            if( !int.TryParse(topics[1], out int id) )
                return;
            
            if (!PSUs.ContainsKey(id))
                return;

            switch(topics[2].ToLower())
            {
                case "stop":
                    shutdown(id);
                    break;
                case "voltage":
                    if (topics[3].ToLower() == "get")
                        GetVoltage(id);
                    if (topics[3].ToLower() == "set")
                        SetVoltage(id, message);
                    break;
                case "current":
                    GetCurrent(id);
                    break;
                case "status":
                    SetStatus(id, message);
                    break;
                default:
                    break;
            }
        }

        void shutdown(int id)
        {
            Console.WriteLine(String.Format("Shutting down psu {0}", id));
            PSUs[id].SetVoltage(0);
            if ( BroadcastList.Contains(id) )
            {
                BroadcastList.Remove(id);
            }
            messageService.Publish(target: String.Format("PSU/{0}/SERVER/STOP", id));
        }

        void GetCurrent(int id)
        {
            string current = PSUs[id].GetCurrent();
            messageService.Publish(
                target:String.Format("PSU/{0}/SERVER/CURRENT", id),
                message:current
            );
        }

        void GetVoltage(int id)
        {
            string voltage = PSUs[id].GetVoltage();
            messageService.Publish(
                target: String.Format("PSU/{0}/SERVER/VOLTAGE", id),
                message: voltage
            );
        }

        void SetVoltage(int id, string message)
        {
            if (!float.TryParse(message, out float voltage))
                return;
            PSUs[id].SetVoltage(voltage);
            if (!BroadcastList.Contains(id))
            {
                BroadcastList.Add(id);
            }
        }

        void SetStatus(int id, string status)
        {
            bool enabled = status.ToLower() == "lock" ? true : false;
            bool success = PSUs[id].RemoteControlEnabled(enabled);
            if (success)
                messageService.Publish(
                    target: String.Format("PSU/{0}/SERVER/STATUS", id),
                    message: status
                );
        }

        void LoadConfig()
        {
            if (this.configFilePath == null)
                return;

            PSUs.Clear();

            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            using StreamReader streamReader = new(Path.Combine(projectDirectory, configFilePath));
            string content = streamReader.ReadToEnd();
            List<PSUConfig>? configList = JsonConvert.DeserializeObject<List<PSUConfig>>(content);
            if (configList != null)
            {
                foreach (PSUConfig config in configList)
                {
                    IPSU PSU = PSUFactory.GetPSU(
                        type: config.Type,
                        comPort: config.ComPort
                    );
                    if (PSU != null)
                    {
                        PSUs.Add(config.Id, PSU);
                    }
                }
            }
        }
    }

    public class PSUConfig
    {
        public int Id;
        public string ComPort = String.Empty;
        public string Type = String.Empty;
    }
}
