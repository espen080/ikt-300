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
        public Manager(string messageServiceProvider, string configFilePath)
        {
            Console.WriteLine("Initializing manager");
            messageService = MessageServiceFactory.GetMessageService(messageServiceProvider, "127.0.0.1");
            PSUs = new Dictionary<int, IPSU>();
            this.configFilePath = configFilePath;
            LoadConfig();
        }

        public IMessageService messageService;
        public Dictionary<int, IPSU> PSUs;

        public void SubscriptionCallback(string message)
        {
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
