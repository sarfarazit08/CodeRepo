using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubApplication.Areas.Admin.Controllers
{
    public class ListCategoryController : BaseAdminController
    {
        
        //
        // GET: /Admin/ListCategory/

        public ActionResult Index(string SortOrder, string SortBy, string Page)
        {
            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;
            var categories = objBs.categoryBs.GetAll();

            switch (SortBy)
            {
                case "CategoryName":
                    switch (SortOrder)
                    {
                        case "ASC":
                            categories = categories.OrderBy(x => x.CategoryName).ToList();
                            break;
                        case "DESC":
                            categories = categories.OrderByDescending(x => x.CategoryName).ToList();
                            break;
                        default:
                            break;
                    }
                    break;

                case "CategoryDesc":
                    switch (SortOrder)
                    {
                        case "ASC":
                            categories = categories.OrderBy(x => x.CategoryDesc).ToList();
                            break;
                        case "DESC":
                            categories = categories.OrderByDescending(x => x.CategoryDesc).ToList();
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    categories = categories.OrderBy(x => x.CategoryName).ToList();
                    break;
            }

            ViewBag.TotalPages = Math.Ceiling(categories.Count() / 10.0);
            int page = int.Parse(Page == null ? "1" : Page);
            ViewBag.Page = page;
            categories = categories.Skip((page - 1) * 10).Take(10);
            
            return View(categories);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                objBs.categoryBs.Delete(id);
                TempData["Msg"] = "Deleted Successfully.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Delete Failed : " + ex.Message;
                return RedirectToAction("Index");
            }
        }

    }
}
