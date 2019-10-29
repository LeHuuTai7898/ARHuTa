using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARHuTaWebProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public void onSingInClick()
        {

        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public ActionResult CreateAccount()
        {
            return RedirectToAction("Index", "CreateAccount");
        }
        public ActionResult ReturnToStore()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}