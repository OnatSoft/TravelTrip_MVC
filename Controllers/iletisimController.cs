using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip_MVCProject.Models.Classes;

namespace TravelTrip_MVCProject.Controllers
{
    public class iletisimController : Controller
    {
        Context c = new Context();

        [HttpGet]
        public ActionResult Main()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Main(iletisimTBL iletisim)
        {
            if (iletisim.Mesaj != null && iletisim.AdSoyad != null && iletisim.Mail != null)
            {
                c.iletisimTBLs.Add(iletisim);
                c.SaveChanges();
            }
            return RedirectToAction("Main");

        }
    }
}