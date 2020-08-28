using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ptbac2Controller : Controller
    {
        // GET: ptbac2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ptbac2(string so1,string so2,string so3)
        {
            double a=0, b=0, c=0;
            if (so1!=null && so2 != null && so3 != null )
            {
              a = double.Parse(so1);
              b = double.Parse(so2);
              c = double.Parse(so3);
            }    
           
            double x1, x2;
            double   d  = b * b - 4 * a * c;
            if (d == 0)
            {
               
                x1 = -b / (2.0 * a);
                x2 = x1;
                ViewBag.kq = x1.ToString();
            }
            else if (d > 0)
            {
                Console.Write("Phuong trinh co hai nghiem thuc phan biet\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                ViewBag.kq = string.Format("Nghiệm 1 {0} nghiệm 2 {1}",x1,x2);
            }
            else
              ViewBag.kq=("Phuong trinh vo nghiem (hay khong co nghiem thuc nao)\n\n");
            return View("tinh2");
        }    
    }
}