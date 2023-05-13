using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        mydbEntities db=new mydbEntities();
        public ActionResult Index()
        {
            var lst = db.dept.OrderBy(m => m.dno).ToList();
            return View(lst);
        }

        /*public int Showit() //簡單的程式"不"寫在'已有檢視'的地方
        {
            ViewBag.x = 1;
            return ViewBag.x;
            //return (1+"<br>"+2).ToString();
        }
        public void Showit(int x)
        {
            ViewBag.x = 1;
            //return View();
            //return (1+"<br>"+2).ToString();
        }*/
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Sno, string Sname)
        {
            ViewBag.Sno = Sno;
            ViewBag.Sname = Sname;
            return View();
        }

    }

}