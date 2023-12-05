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
        Dictionary<string, int> PSUIds;
        List<int> BroadcastList;
        Timer BroadcastTimer;
        Timer PSUTimer;
        string configFilePath;
        int frequency = 3;
        static int DefaultId = 1;

        public Manager(IMessageService messageService, string configFilePath)
        {
            // Initialize members
            this.configFilePath = configFilePath;
            this.messageService = messageService;
            this.messageService.Connect(SubscriptionCallback);;
            PSUs = new Dictionary<int, IPSU>();
            PSUIds = new Dictionary<string, int>();
            BroadcastList = new List<int>();
            
            
            LoadConfig();
            
            
            var list = PSUFactory.GetPSUs();
            foreach(var serialNo in list.Keys)
            {
                if (PSUIds.ContainsKey(serialNo))
                    PSUs.Add(PSUIds[serialNo], list[serialNo]);
                else
                    PSUs.Add(PSUIds.Values.Max()+ DefaultId++, list[serialNo]);
            }


            string psuList = JsonConvert.SerializeObject(PSUs.Keys.ToList());
            messageService.Publish("PSU/LIST", psuList);
            messageService.Subscribe("PSU/+/#");
            messageService.Subscribe("PSU/FREQUENCY");

            BroadcastTimer = new(BroadcastCallback, this, TimeSpan.Zero, TimeSpan.FromSeconds(frequency));
            PSUTimer = new(ValidatorCallback, this, TimeSpan.Zero, TimeSpan.FromSeconds(60));
        }

        public void Unload()
        {
            messageService.Disconnect();
            BroadcastTimer.Dispose();
            PSUTimer.Dispose();
        }

        void Broadcast()
        {
            Console.WriteLine("Updating PSU info");
            foreach ( int id in BroadcastList )
            {
                GetCurrent(id);
            }
        }

        void ValidatePSUs()
        {
            foreach( int id in PSUs.Keys )
            {
                if (!PSUs[id].IsValid())
                    PSUs.Remove(id);
            }

        }
        static void BroadcastCallback(object? state)
        {
            Manager? manager = state as Manager;
            manager?.Broadcast();
        }
        static void ValidatorCallback(object? state)
        {
            Manager? manager = state as Manager;
            manager?.ValidatePSUs();
        }

        void SubscriptionCallback(string topic, string message)
        {
            if (topic.ToLower() == "psu/frequency")
            {
                int.TryParse(message, out frequency);
                BroadcastTimer.Change(0, frequency * 1000);
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
            GetCurrent(id);
            GetVoltage(id);
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

            PSUIds.Clear();

            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            using StreamReader streamReader = new(Path.Combine(projectDirectory, configFilePath));
            string content = streamReader.ReadToEnd();
            List<PSUConfig>? configList = JsonConvert.DeserializeObject<List<PSUConfig>>(content);
            if (configList != null)
            {
                foreach (PSUConfig config in configList)
                {
                    PSUIds.Add(config.SerialNo, config.Id);
                }
            }

        }


    }

    public class PSUConfig
    {
        public int Id;
        public string SerialNo;
    }
}
