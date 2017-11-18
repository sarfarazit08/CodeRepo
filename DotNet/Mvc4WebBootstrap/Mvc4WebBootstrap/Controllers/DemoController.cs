using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4WebBootstrap.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/

        public ActionResult Index()
        {
            //ViewBag used to provide dynamic/runtime properties to object
            //it doesn't provides compile time error checking
            ViewBag.Countries = new List<string>
            {
                "US",
                "UK",
                "UAE",
                "Ukrain",
                "Uganda"              
            };

            //ViewData used to provide dynamic/runtime properties to object
            //it doesn't provides compile time error checking
            ViewData["Countries"] = new List<string>
            {
                "US",
                "UK",
                "UAE",
                "Ukrain",
                "Uganda"              
            };

            return View();
        }

    }
}
