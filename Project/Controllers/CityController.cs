using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class CityController : Controller
    {
        [HttpGet]
        public ActionResult Index(int id)
        {
            return View(Repo.GetGrad(id));
        }

        public ActionResult All()
        {
            return View(Repo.GetGradovi());
        }
    }
}