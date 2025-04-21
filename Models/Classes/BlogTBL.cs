using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip_MVCProject.Models.Classes
{
    public class BlogTBL
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogFoto { get; set; }
        public ICollection<YorumlarTBL> YorumlarTBLs { get; set; }
    }
}