using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip_MVCProject.Models.Classes;
using PagedList.Mvc;

namespace TravelTrip_MVCProject.Controllers
{
    [Authorize]
    public class adminController : Controller
    {
        Context c = new Context();
        iletisimTBL ilt = new iletisimTBL();

        /*** BLOGLAR KOMUTLARI ***/

        public ActionResult BlogList(int page = 1)
        {
            var values = c.BlogTBLs.ToList().ToPagedList(page, 5);
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
        public ActionResult CommentList(int page = 1)
        {
            var val = c.YorumlarTBLs.ToList().ToPagedList(page, 5);
            return View(val);
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

        public ActionResult Inbox()
        {
            ilt.messageValue = c.iletisimTBLs.ToList();
            return View(ilt);
        }

        //public ActionResult MsgDetail(int id)
        //{ => Mesaj içeriğini Popup Modal'da yazdırmak için Ajax ile alternatif yöntem.
        //    var value = c.iletisimTBLs.Where(v => v.ID == id).Select(m => m.Mesaj).FirstOrDefault();
        //    return Json(new { Mesaj = value }, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult MessageDel(int id)
        {
            var value = c.iletisimTBLs.Find(id);
            c.iletisimTBLs.Remove(value);
            c.SaveChanges();
            return RedirectToAction("Inbox");
        }
    }
}