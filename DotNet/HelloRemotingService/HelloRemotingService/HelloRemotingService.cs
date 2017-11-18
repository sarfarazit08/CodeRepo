using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HelloRemotingService
{
    public class HelloRemotingService : MarshalByRefObject, IHelloRemotingService.IHelloRemotingService
    {
        public string HelloWorldMessage(string name)
        {
            return "Hello! " + name;
        }
    }

}
