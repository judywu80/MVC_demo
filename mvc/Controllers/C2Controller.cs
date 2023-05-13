using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class C2Controller : Controller
    {
        // GET: C2
        public List<object> showdata()
        {
            string s1="",s = ""; int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                s1 += i.ToString() + "+";
                
            }
            s =s+ s1.Remove(s1.Length - 1, 1);
            s += "=";
            List<object> lst = new List<object>();
            lst.Add(s);
            lst.Add(sum.ToString());
            return lst;
        }
        public ActionResult Index()
        {
            ViewBag.list = showdata();
            return View();
        }

    }
}