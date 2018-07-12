using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class AwController : Controller
    {
        public ActionResult Drzave()
        {
            return View();
        }

        public ActionResult Gradovi()
        {
            return View();
        }


        public ActionResult Kupac(int id)
        {
            return View();
        }

        public ActionResult Kupci()
        {
            //edit
            return View();
        }

        public ActionResult Racuni(int id)
        {
            return View();
        }
    }
}