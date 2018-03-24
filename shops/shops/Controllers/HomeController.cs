using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shops.Models;

namespace shops.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork;

        public HomeController()
        {
            unitOfWork = new UnitOfWork();
        }

        // Shops list
        public ActionResult Index()
        {
            IEnumerable<Shop> shops = unitOfWork.Shops.GetAll();

            if (Request.IsAjaxRequest())
            {
                return PartialView("ShopsList", shops);
            }

            return View(shops);
        }

        // Products list
        public PartialViewResult GetProducts(int id)
        {
            var products = unitOfWork.Products.GetQueryableById(id);

            return PartialView(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }
    }
}