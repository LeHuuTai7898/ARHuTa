using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARHuTaWebProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<String> images = new List<string>();
            images.Add("~/Content/Images/slide-1.jpg");
            ViewData["SlidesSrc"] = images;
            return View();
        }

      
        public ActionResult Login()
        {
            return RedirectToAction("Index","Login");
        }

        public ActionResult CreateAccout()
        {
            return RedirectToAction("Index", "CreateAccount");

        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Men()
        {
            return View();
        }

        public ActionResult Women()
        {
            return View();
        }

        public ActionResult ProductDetail()
        {
            return View();
        }
    }
}