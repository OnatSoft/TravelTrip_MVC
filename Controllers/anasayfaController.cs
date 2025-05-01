using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip_MVCProject.Models.Classes;

namespace TravelTrip_MVCProject.Controllers
{
    public class anasayfaController : Controller
    {
        Context c = new Context();
        
        public ActionResult Index()
        {
            var blogs = c.BlogTBLs.Take(10).ToList();
            return View(blogs);
        }

        public PartialViewResult indexPartial1()
        {
            var values = c.BlogTBLs.OrderByDescending(x => x.ID).Take(4).ToList();
            return PartialView(values);
        }

        public PartialViewResult indexPartial2()
        {
            var values = c.BlogTBLs.Where(x => x.ID <= 8).OrderByDescending(x => x.ID).Take(4).ToList();
            return PartialView(values);
        }

        public PartialViewResult partialViewTop10()
        {
            var values = c.BlogTBLs.Take(10).ToList();
            return PartialView(values);
        }
    }
}