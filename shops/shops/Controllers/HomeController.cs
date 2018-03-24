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
        //AppDbContext db = new AppDbContext();
        
        UnitOfWork unitOfWork;
        public HomeController()
        {
            unitOfWork = new UnitOfWork();
        }

        public ActionResult Index()
        {
            //IEnumerable<Shop> shops = db.Shops;
            IEnumerable<Shop> shops = unitOfWork.Shops.GetAll();
            ViewBag.Shops = shops;
            return View();
        }

        public ActionResult GetProducts(int id)
        {
            //var products = db.Products.Where(x => x.ShopId == id);
            var products = unitOfWork.Products.GetQueryableById(id);
            ViewBag.Products = products;
            return View();
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