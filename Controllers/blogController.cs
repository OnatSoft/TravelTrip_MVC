using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip_MVCProject.Models.Classes;

namespace TravelTrip_MVCProject.Controllers
{
    public class blogController : Controller
    {
        Context c = new Context();
        BlogYorum by = new BlogYorum();

        public ActionResult Index()
        {
            //var value = c.BlogTBLs.ToList();
            by.blogValue = c.BlogTBLs.ToList();
            by.recentBlog = c.BlogTBLs.OrderByDescending(x => x.Tarih).Take(3).ToList();
            return View(by);
        }

        public ActionResult BlogDetail(int id)
        {
            //* Statik olarak blogun ID'sine göre ilgili ayrıntı sayfasını açma.
            //var findBlog = c.BlogTBLs.Where(x => x.ID == id).ToList();
            
            //* BlogYorum sınıfından gelen interface değeri ile ID'ye göre ilgili blogları ve yorumları açma.
            by.blogValue = c.BlogTBLs.Where(x => x.ID == id).ToList();
            by.yorumValue = c.YorumlarTBLs.Where(x => x.Blogid == id).ToList();
            by.recentBlog = c.BlogTBLs.OrderByDescending(x => x.Tarih).Take(3).ToList();
            return View(by);
        }

        [HttpGet]
        public PartialViewResult partialCommentAdd(int id)
        {
            ViewBag.blogID = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult partialCommentAdd(YorumlarTBL y)
        {
            c.YorumlarTBLs.Add(y);
            c.SaveChanges();
            return PartialView(y);
        }
    }
}