using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace RemotingServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloRemotingService.HelloRemotingService remotingService = 
                new HelloRemotingService.HelloRemotingService();
           
            TcpChannel channel = new TcpChannel(8085);
            ChannelServices.RegisterChannel(channel);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(HelloRemotingService.HelloRemotingService),
                "HelloWorldMessage",
                WellKnownObjectMode.Singleton);


            Console.WriteLine("Remoting Service Started @" + DateTime.Now.ToString("dd/MMM/yyyy"));
            Console.ReadLine();

            //string name = Console.ReadLine();
            //Console.WriteLine(remotingService.HelloWorldMessage(name));

            //Console.WriteLine("Remoting Service Ended @" + DateTime.Now.ToString("dd/MMM/yyyy"));
        }
    }
}
