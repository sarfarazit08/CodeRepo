using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;

namespace HelloServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloWorldService.HelloService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString("dd/MMM/yyyy"));
                Console.ReadLine();
            }
        }
    }
}
