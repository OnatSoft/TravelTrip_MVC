using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip_MVCProject.Models.Classes
{
    public class iletisimTBL
    {
        [Key]
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Konu { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Mesaj { get; set; }
    }
}