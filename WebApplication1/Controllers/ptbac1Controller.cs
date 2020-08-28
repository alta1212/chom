using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ptbac1Controller : Controller
    {
        // GET: ptbac1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult tinh(string so_1,string so_2)
        {
            if(so_1!=null &&so_2!=null)
            {   
                float  a = float .Parse(so_1);
                float  b = float .Parse(so_2);
                float  x = -b / a;      
                ViewBag.kq = x.ToString();
            }    
            return View("tinh");

        }
    }
}