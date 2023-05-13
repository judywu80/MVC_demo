using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class AController : Controller
    {
        // GET: A
        public ActionResult Index()
        {
            return View();
        }
        public int Showit() //待改寫成多載
        {
            ViewBag.x = 1;
            return ViewBag.x;
        }

    }
}