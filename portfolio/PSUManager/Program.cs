using PSUManager;
using MessageService;


Console.WriteLine("Starting PSU Manager");

IMessageService messageService = MessageServiceFactory.GetMessageService("MQTT", "127.0.0.1");
Manager manager = new Manager(messageService, "config.json");

Console.WriteLine("Press q to quit");
while (Console.ReadLine() != "q")
{
    
}

manager.Unload();