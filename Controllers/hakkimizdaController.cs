using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip_MVCProject.Models.Classes;

namespace TravelTrip_MVCProject.Controllers
{
    public class hakkimizdaController : Controller
    {
        Context c = new Context();

        public ActionResult Main()
        {
            var value = c.hakkimizdaTBLs.ToList();
            return View(value);
        }
    }
}