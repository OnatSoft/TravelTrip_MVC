using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTrip_MVCProject.Models.Classes
{
    public class Context:DbContext
    {
        public DbSet<AdminTBL> adminTBLs { get; set; }
        public DbSet<AdresTBL> adresTBLs { get; set; }
        public DbSet<BlogTBL> BlogTBLs { get; set; }
        public DbSet<HakkimizdaTBL> hakkimizdaTBLs { get; set; }
        public DbSet<iletisimTBL> iletisimTBLs { get; set; }
        public DbSet<YorumlarTBL> YorumlarTBLs { get; set; }
    }
}