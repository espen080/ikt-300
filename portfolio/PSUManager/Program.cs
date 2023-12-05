using PSUManager;
using MessageService;


Console.WriteLine("Starting PSU Manager");

IMessageService messageService = MessageServiceFactory.GetMessageService("MQTT", "127.0.0.1");
Manager manager = new Manager(messageService, "config.json");


Timer timer = new(Callback, manager, TimeSpan.Zero, TimeSpan.FromSeconds(5));
while (true)
{

}

static void Callback(object state)
{
    Manager manager = (Manager)state;
    manager.Broadcast();
}
