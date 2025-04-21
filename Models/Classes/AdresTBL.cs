using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip_MVCProject.Models.Classes
{
    public class AdresTBL
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string AcikAdres { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}