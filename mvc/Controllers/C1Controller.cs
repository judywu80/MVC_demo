using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class C1Controller : Controller
    {
        // GET: C1
        public List<int> showlist() //有檢視器indx, 不用打網址
        {
            List<int> lst = new List<int> { 1, 2, 3, 4, 5 };
            return lst;
        }
        public int show()
        {
            int s = 0;
            for (int i = 1; i <= 10; i++)
            { s += i; }
            return s; //s=55
        }

        public ActionResult Index()
        {
            ViewBag.list = showlist();
            return View();
        }

    }
}