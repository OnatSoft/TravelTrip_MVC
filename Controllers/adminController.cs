using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip_MVCProject.Models.Classes;

namespace TravelTrip_MVCProject.Controllers
{
    public class adminController : Controller
    {
        Context c = new Context();

        /*** BLOGLAR KOMUTLARI ***/
        public ActionResult BlogList()
        {
            var values = c.BlogTBLs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddNewBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewBlog(BlogTBL blog)
        {
            c.BlogTBLs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("BlogList");
        }

        public ActionResult DeleteBlog(int id)
        {
            var values = c.BlogTBLs.Find(id);
            c.BlogTBLs.Remove(values);
            c.SaveChanges();
            return RedirectToAction("BlogList");
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var blog = c.BlogTBLs.Find(id);
            return View("UpdateBlog", blog);
        }

        [HttpPost]
        public ActionResult UpdateBlog(BlogTBL b)
        {
            var blg = c.BlogTBLs.Find(b.ID);
            blg.Baslik = b.Baslik;
            blg.Tarih = b.Tarih;
            blg.Aciklama = b.Aciklama;
            blg.BlogFoto = b.BlogFoto;
            c.SaveChanges();
            return RedirectToAction("BlogList");
        }

        /*** YORUMLAR KOMUTLARI ***/
        public ActionResult CommentList()
        {
            var yorumlar = c.YorumlarTBLs.ToList();
            return View(yorumlar);
        }

        public ActionResult DeleteComment(int id)
        {
            var yorumlar = c.YorumlarTBLs.Find(id);
            c.YorumlarTBLs.Remove(yorumlar);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }

        [HttpGet]
        public ActionResult UpdateComment(int id)
        {
            var yorum = c.YorumlarTBLs.Find(id);
            return View("UpdateComment", yorum);
        }

        [HttpPost]
        public ActionResult UpdateComment(YorumlarTBL y)
        {
            var yrm = c.YorumlarTBLs.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Email = y.Email;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}