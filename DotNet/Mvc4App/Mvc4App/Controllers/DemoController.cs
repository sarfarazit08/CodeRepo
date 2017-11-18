using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4App.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/

        public ActionResult Index()
        {
            ViewBag.AnimalSet1 = new List<string>()
            {
                "Dog",
                "Giraffe",
                "Elephant",
                "Horse",
                "Cat"
            };

            ViewData["AnimalSet2"] = new List<string>()
            {
                "Lion",
                "Leopard",
                "Jaguar",
                "Horse",
                "Tiger"
            };


            return View();
        }

    }
}
