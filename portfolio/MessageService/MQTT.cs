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

        public MQTT(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Connect()
        {
            try
            {
                Client = new MqttClient(connectionString);
                string clientID = Guid.NewGuid().ToString();
                Client.Connect(clientID);

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

        }

        public void Subscribe(string target, Action<string> messageHandler)
        {
            Console.WriteLine("Subscribing");
            // Register a callback for received messages
            Client.MqttMsgPublishReceived += (sender, e) =>
            {
                string receivedMsg = e.Topic.ToString();
                Console.WriteLine(receivedMsg);
                messageHandler(receivedMsg);
            };
            // Subscribe to topic
            Client.Subscribe(new string[] { target }, new byte[] { 2 });
        }
    }
}
