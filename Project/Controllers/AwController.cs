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

        [HttpGet]
        public ActionResult Drzava(int id)
        {
            return View(Repo.GetGrad(id));
        }

        public ActionResult Gradovi()
        {
            return View();
        }

        public ActionResult Kupac(int id)
        {
            return View(Repo.GetKupci(id));
        }

        public ActionResult Kupci()
        {
            return View();
        }       

        [HttpGet]
        public ActionResult UrediKupca(int id)
        {
            ViewBag.gradovi = Repo.GetGradovi();
            return View(Repo.GetKupac(id));
        }

        [HttpPost]
        public ActionResult UrediKupca(Kupac k)
        {
            if (ModelState.IsValid)
            {
                Repo.UpdateKupac(k);
                return RedirectToAction("Kupci");
            }
            else
            {
                ViewBag.gradovi = Repo.GetGradovi();
                return View(k);
            }
        }

        public ActionResult Racuni(int id)
        {
            return View();
        }
    }
}