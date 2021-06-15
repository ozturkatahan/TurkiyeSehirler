using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TurkiyeSehirler.Controllers
{
    public class SehirlerController : Controller
    {
        // GET: Sehirler
        public ActionResult Index()
        {
            return View();
        }
    }
}