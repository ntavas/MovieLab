using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieLab.Models;
using MovieLab.ViewModels;
using System.Web.Mvc;
using System.Web.UI;

namespace MovieLab.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            throw new Exception();
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