using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubApplication.Areas.Common.Controllers
{
    //[AllowAnonymous]
    public class HomeController : BaseCommonController
    {   
        public ActionResult Index()
        {
            return View();
        }
    }
}
