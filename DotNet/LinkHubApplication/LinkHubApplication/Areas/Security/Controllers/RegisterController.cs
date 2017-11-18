using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubApplication.Areas.Security.Controllers
{
    //[AllowAnonymous]
    public class RegisterController : BaseSecurityController
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    user.Role = "U";
                    objBs.userBs.Insert(user);
                    TempData["Msg"] = "Created Successfully.";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Create Failed : " + ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}
