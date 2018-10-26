using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment3.Models.ActionFilters;
using Assignment3.Models.Extensions;
namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var date1 = new DateTime(1990, 01, 01).ToAge();
            var date2= new DateTime(1987, 05, 07).ToAge();
            var date3= new DateTime(1975, 10, 10).ToAge();
            var string1 = "abc123".ToDigitsOnly();
            var string2 = "z1x2c3v4".ToDigitsOnly();
            var string3 = "#$ss223%^".ToDigitsOnly();
            return View();
        }

        [CrawlerAuhthentication]
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