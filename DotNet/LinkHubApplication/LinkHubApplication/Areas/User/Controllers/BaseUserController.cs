using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubApplication.Areas.User.Controllers
{
    public class BaseUserController : Controller
    {
        protected UserAreaBs objBs;

        public BaseUserController()
        {
            objBs = new UserAreaBs();
        }
    }
}
