using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTrip_MVCProject.Models.Classes;

namespace TravelTrip_MVCProject.Controllers
{
    public class loginController : Controller
    {
        Context c = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AdminTBL adm)
        {
            //* Admin Yönetim Paneline giriş (Authenticate) sağlanıyor.
            var bilgiler = c.adminTBLs.FirstOrDefault(x => x.KullaniciAd == adm.KullaniciAd && x.Sifre == adm.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAd, false);
                Session["KullaniciAd"] = bilgiler.KullaniciAd.ToString();
                return RedirectToAction("BlogList", "admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "anasayfa");
        }
    }
}