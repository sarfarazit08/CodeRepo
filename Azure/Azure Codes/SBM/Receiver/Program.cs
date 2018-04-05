using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Azure;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;

namespace Receiver
{
    class Program
    {
        static void Main(string[] args)
        {
            const string QueueName = "sbmQueue1";

            string connectionString =
                CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.ConnectionString");

            var client =
                QueueClient.CreateFromConnectionString(connectionString, QueueName);

            // Event triggered by sender and recieved here
            client.OnMessage(message =>
            {
                
                Console.WriteLine(String.Format("Message body : {0}", message.GetBody<String>()));
                Console.WriteLine(String.Format("Message id : {0}", message.MessageId));
            });

            Console.ReadLine();

        }
    }
}
