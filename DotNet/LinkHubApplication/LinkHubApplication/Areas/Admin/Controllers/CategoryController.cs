using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubApplication.Areas.Admin.Controllers
{
    public class CategoryController : BaseAdminController
    {
        //
        // GET: /Admin/Category/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(tbl_Category category)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    objBs.categoryBs.Insert(category);
                    TempData["Msg"] = "Created Successfully.";
                    return RedirectToAction("Index");
                }
                else
                    return View("Index");

            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Create Failed : " + ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}
