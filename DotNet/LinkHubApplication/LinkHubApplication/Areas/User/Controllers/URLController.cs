using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubApplication.Areas.User.Controllers
{
    public class URLController : BaseUserController
    {
        public ActionResult Index()
        {
            ViewBag.CategoryId = new SelectList(objBs.categoryBs.GetAll(), "CategoryId", "CategoryName");
            ViewBag.UserId = new SelectList(objBs.userBs.GetAll(), "UserId", "UserEmail");
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_Url url)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    objBs.urlBs.Insert(url);
                    TempData["Msg"] = "Created Successfully.";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.CategoryId = new SelectList(objBs.categoryBs.GetAll(), "CategoryId", "CategoryName");
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
