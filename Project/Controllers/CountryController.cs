using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class CountryController : Controller
    {
        // GET: City
        public ActionResult All()
        {
            return View(Repo.GetDrzave());
        }
    }
}