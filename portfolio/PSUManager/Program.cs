using PSUManager;


Console.WriteLine("Starting PSU Manager");

Manager manager = new Manager("MQTT", "config.json");
manager.messageService.Connect();
manager.messageService.Subscribe("PSU/CONNECT/#", manager.SubscriptionCallback);

while(true)
{
    // Run PSU management here
}
