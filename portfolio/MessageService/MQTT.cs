using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MessageService
{
    internal class MQTT: IMessageService
    {
        MqttClient? Client;
        string connectionString;
        string ClientId;

        public MQTT(string connectionString)
        {
            this.connectionString = connectionString;
            ClientId = Guid.NewGuid().ToString();
            Client = new MqttClient(this.connectionString);
        }
        public void Connect(Action<string, string> handler)
        {
            try
            {
                if(Client == null)
                {
                    return;
                }
                // Register a callback for received messages
                Client.MqttMsgPublishReceived += (sender, e) =>
                {
                    string topic = e.Topic.ToString();
                    string message = Encoding.UTF8.GetString(e.Message);
                    handler(topic, message);
                };
                Client.Connect(ClientId);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Disconnect()
        {
            Client?.Disconnect();
        }
        public void Publish(string target, string message)
        {
            Client?.Publish(target, Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        public void Subscribe(string target)
        {
            // Subscribe to topic
            Client?.Subscribe(new string[] { target }, new byte[] { 2 });
        }
    }
}
