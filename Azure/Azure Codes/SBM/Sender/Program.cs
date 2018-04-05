using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Azure;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;

namespace Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            const string QueueName = "sbmQueue1";
            string connectionString =
                CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.ConnectionString");

            string msg = "This is a message from sender.";

            var namespaceManager =
                NamespaceManager.CreateFromConnectionString(connectionString);

            if (!namespaceManager.QueueExists(QueueName))
            {
                namespaceManager.CreateQueue(QueueName);
            }

            MessagingFactory factory =
                MessagingFactory.CreateFromConnectionString(connectionString);

            QueueClient myQueueClient = factory.CreateQueueClient(QueueName);
            BrokeredMessage bsm = new BrokeredMessage(msg);
            myQueueClient.Send(bsm);

            Console.ReadLine();
        }
    }
}
