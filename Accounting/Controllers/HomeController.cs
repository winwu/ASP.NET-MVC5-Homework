using Accounting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ForAccountChildAction()
        {
            ViewData.Model = new AccountItemView
            {
                Id = 1,
                Type = "支出",
                Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ffff"),
                Price = 300
            };
          
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