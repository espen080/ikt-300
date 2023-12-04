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
        public Manager(IMessageService messageService, string configFilePath)
        {
            this.messageService = messageService;
            this.messageService.Connect(SubscriptionCallback);
            messageService.Subscribe("PSU/CONNECT");
            PSUs = new Dictionary<int, IPSU>();
            this.configFilePath = configFilePath;
            LoadConfig();
        }

        protected IMessageService messageService;
        protected Dictionary<int, IPSU> PSUs;

        private void SubscriptionCallback(string topic, string message)
        {
            if(topic.ToLower() == "psu/connect")
            {
                string psuList = JsonConvert.SerializeObject(PSUs.Keys.ToList());
                messageService.Publish("PSU/LIST", psuList);
            }
            Console.WriteLine(topic);
            Console.WriteLine(message);
        }

        private string configFilePath;

        private void LoadConfig()
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
                    PSUs.Add(config.Id, PSUFactory.GetPSU(config.ComPort));
                }
            }
        }
    }



    public class PSUConfig
    {
        public int Id;
        public string ComPort = String.Empty;
    }
}
