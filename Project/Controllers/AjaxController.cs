using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class AjaxController : Controller
    {
        public ActionResult GetDrzave()
        {
            return Json(Repo.GetDrzave(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetGradovi()
        {
            return Json(Repo.GetGradovi(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetKupci()
        {
            return Json(Repo.GetKupci(), JsonRequestBehavior.AllowGet);
        }

        protected override JsonResult Json(object data, string contentType, System.Text.Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonResult()
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior,
                MaxJsonLength = Int32.MaxValue
            };
        }
    }
}