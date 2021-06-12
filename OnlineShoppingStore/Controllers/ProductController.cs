using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GameCategory()
        {
            return View("~/Views/Product/GameDetails.cshtml");
        }
        public ActionResult MenCategory()
        {
            return View("~/Views/Product/MenDetails.cshtml");
        }
        public ActionResult WomenCategory()
        {
            if (Session["loged_in_customer"] != null)
            {
                return View("~/Views/Product/WomenDetails.cshtml");
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult ElectronicsCategory()
        {
            return View("~/Views/Product/ElectronicsDetails.cshtml");
        }

        public ActionResult TestDetails()
        {
            return View("~/Views/Product/TestDetails.cshtml");
        }

        



    }
}