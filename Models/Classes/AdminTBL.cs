using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip_MVCProject.Models.Classes
{
    public class AdminTBL
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
    }
}