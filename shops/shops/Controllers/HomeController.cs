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
        AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            IEnumerable<Shop> shops = db.Shops;
            ViewBag.Shops = shops;
            return View();
        }

        public ActionResult GetProducts(int id)
        {
            var products = db.Products.Where(x => x.ShopId == id);
            ViewBag.Products = products;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}