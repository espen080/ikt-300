using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageService;

namespace PSUManager
{
    internal class Manager
    {
        public Manager(string messageServiceProvider)
        {
            messageService = MessageService.MessageServiceFactory.GetMessageService(messageServiceProvider);
        }

        protected IMessageService messageService;
    }
}
