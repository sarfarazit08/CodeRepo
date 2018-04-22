using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Sixeyed.Iaas.WebApp.Models;
using System.Globalization;
using System.Net;

namespace Sixeyed.Iaas.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //adapted from https://gist.github.com/sixeyed/8445048
            var diagnostics = new ServerDiagnostics();

            diagnostics.MachineDate = DateTime.Now;
            diagnostics.MachineName = Environment.MachineName;
            diagnostics.MachineCulture = string.Format("{0} - {1}", CultureInfo.CurrentCulture.DisplayName, CultureInfo.CurrentCulture.Name);
            diagnostics.MachineTimeZone = TimeZone.CurrentTimeZone.IsDaylightSavingTime(diagnostics.MachineDate) ? TimeZone.CurrentTimeZone.DaylightName : TimeZone.CurrentTimeZone.StandardName;
            diagnostics.DnsHostName = Dns.GetHostName();
            diagnostics.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var ipHost = Dns.GetHostEntry(diagnostics.DnsHostName);
            var ipList = new List<string>(ipHost.AddressList.Length);
            foreach (var ipAddress in ipHost.AddressList)
            {
                ipList.Add(ipAddress.ToString());
            }
            diagnostics.IpAddressList = ipList;
            diagnostics.ApplicationName = "Managing Azure IaaS with PowerShell";
            diagnostics.ApplicationVersionNumber = this.GetType().Assembly.GetName().Version.ToString();

            return View(diagnostics);
        }
    }
}
