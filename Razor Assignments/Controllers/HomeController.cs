using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor_Assignments.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int amount=0)
        {
            ViewBag.amount = amount;
            ViewBag.denom = new List<int>() { 1000, 500, 100, 10, 1 };
            return View();
        }
    }
}