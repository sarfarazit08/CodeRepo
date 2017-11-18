using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubApplication.Areas.Common.Controllers
{
    //[AllowAnonymous]
    public class BrowseURLController : BaseCommonController
    {
        public ActionResult Index(string SortOrder, string SortBy, string Page)
        {
            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;
            var urls = objBs.urlBs.GetAll().Where(url => url.IsApproved == "A");

            switch (SortBy)
            {
                case "UrlId":
                    switch (SortOrder)
                    {
                        case "ASC":
                            urls = urls.OrderBy(x => x.UrlId).ToList();
                            break;
                        case "DESC":
                            urls = urls.OrderByDescending(x => x.UrlId).ToList();
                            break;
                        default:
                            break;
                    }
                    break;

                case "UrlTitle":
                    switch (SortOrder)
                    {
                        case "ASC":
                            urls = urls.OrderBy(x => x.UrlTitle).ToList();
                            break;
                        case "DESC":
                            urls = urls.OrderByDescending(x => x.UrlTitle).ToList();
                            break;
                        default:
                            break;
                    }
                    break;

                case "Url":
                    switch (SortOrder)
                    {
                        case "ASC":
                            urls = urls.OrderBy(x => x.Url).ToList();
                            break;
                        case "DESC":
                            urls = urls.OrderByDescending(x => x.Url).ToList();
                            break;
                        default:
                            break;
                    }
                    break;

                case "UrlDesc":
                    switch (SortOrder)
                    {
                        case "ASC":
                            urls = urls.OrderBy(x => x.UrlDesc).ToList();
                            break;
                        case "DESC":
                            urls = urls.OrderByDescending(x => x.UrlDesc).ToList();
                            break;
                        default:
                            break;
                    }
                    break;

                case "CategoryId":
                    switch (SortOrder)
                    {
                        case "ASC":
                            urls = urls.OrderBy(x => x.CategoryId).ToList();
                            break;
                        case "DESC":
                            urls = urls.OrderByDescending(x => x.CategoryId).ToList();
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    urls = urls.OrderBy(x => x.UrlTitle).ToList();
                    break;

            }

            ViewBag.TotalPages = Math.Ceiling(urls.Count() / 10.0);
            int page = int.Parse(Page == null ? "1" : Page);
            ViewBag.Page = page;
            urls = urls.Skip((page - 1) * 10).Take(10);


            return View(urls);
        }

    }
}
