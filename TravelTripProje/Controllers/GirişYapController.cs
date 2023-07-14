using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProje.Controllers
{
    public class GirişYapController : Controller
    {
        // GET: GirişYap
     
        public ActionResult Login()
        {
            return View();
        }
    }
}