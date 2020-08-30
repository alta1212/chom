using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class formController : Controller
    {
        // GET: form
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult re(FormCollection a )
        {
            if (a["soa"]!=null&& a["sob"] != null)
            {
                float a1 = float.Parse(a["soa"]);
                float b2 = float.Parse(a["sob"]);
                float x = -b2 / a1;
                ViewBag.kq = x.ToString();
            }
            return View("re");
        }
    }
}