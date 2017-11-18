using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHelloRemotingService
{
    public interface IHelloRemotingService
    {
        string HelloWorldMessage(string name);
    }
}
