using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageService
{
    public static class MessageServiceFactory
    {
        public static IMessageService GetMessageService(string provider) 
        { 
            switch (provider.ToLower())
            {
                case "mqtt":
                    return new MQTT();
                default:
                    return null;
            }
        }
    }

    public interface IMessageService
    {
        public void Connect();
        public void Disconnect();
        public void Publish(string target, string message);
        public void Subscribe(string target);
    }
}
