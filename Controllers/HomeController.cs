﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fundraising.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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


        public ActionResult Beginning()
        {
            ViewBag.Message = "Beginning page";

            return View();
        }


        public ActionResult Gallery()
        {
            ViewBag.Message = "Gallery page";

            return View();
        }
        public ActionResult Plans()
        {
            ViewBag.Message = "Plans page";

            return View();
        }

        public ActionResult Team()
        {
            ViewBag.Message = "Team page";

            return View();
        }
    }
}