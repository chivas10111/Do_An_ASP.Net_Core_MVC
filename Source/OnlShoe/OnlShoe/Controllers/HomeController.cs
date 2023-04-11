using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlShoe.Models;

namespace OnlShoe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();

        }
        public ActionResult Brand()
        {

            return View();

        }
        public ActionResult Sale()
        {

            return View();

        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult SlidePartial()
        {
            return PartialView();

        }
    }
}