using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubApplication.Areas.Admin.Controllers
{
    public class ApproveURLsController : BaseAdminController
    {
        public ActionResult Index(string Status)
        {
            ViewBag.Status = (Status == null ? "P" : Status);
            if (Status == null)
            {
                var urls = objBs.urlBs.GetAll().Where(x => x.IsApproved == "P").ToList();
                return View(urls);
            }
            else
            {
                var urls = objBs.urlBs.GetAll().Where(x => x.IsApproved == Status).ToList();
                return View(urls);
            }
        }

        public ActionResult Approve(int id)
        {
            try
            {
                var url = objBs.urlBs.GetById(id);
                url.IsApproved = "A";

                objBs.urlBs.Update(url);
                TempData["Msg"] = "Approved Successfully.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Approval Failed : " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        public ActionResult Reject(int id)
        {
            try
            {
                var url = objBs.urlBs.GetById(id);
                url.IsApproved = "R";

                objBs.urlBs.Update(url);
                TempData["Msg"] = "Rejected Successfully.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Rejection Failed : " + ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}
