using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelTrip_MVCProject.Models.Classes
{
    public class YorumlarTBL
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Yorum { get; set; }
        public int Blogid { get; set; }
        public virtual BlogTBL Blog { get; set; }
    }
}