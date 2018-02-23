using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BetaWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "關於本公司...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "歡迎透過email與我們聯繫，或是追蹤我們的Facebook粉絲團。";

            return View();
        }

        public ActionResult TestPage1()
        {
            ViewBag.Message = "message測試的頁面";

            return View();
        }
    }
}