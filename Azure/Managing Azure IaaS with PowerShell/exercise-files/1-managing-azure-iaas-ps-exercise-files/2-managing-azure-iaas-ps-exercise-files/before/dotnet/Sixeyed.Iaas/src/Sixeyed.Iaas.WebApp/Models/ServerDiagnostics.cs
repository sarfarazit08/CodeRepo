using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sixeyed.Iaas.WebApp.Models
{
    public class ServerDiagnostics
    {
        public string ApplicationName { get; set; }

        public string ApplicationVersionNumber { get; set; }

        public string WorkingDirectory { get; set; }

        public string DnsHostName { get; set; }

        public string MachineName { get; set; }

        public DateTime MachineDate { get; set; }

        public string MachineCulture { get; set; }

        public string MachineTimeZone { get; set; }

        public IEnumerable<string> IpAddressList { get; set; }
    }
}
