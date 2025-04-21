using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTrip_MVCProject.Models.Classes
{
    public class BlogYorum
    {
        public IEnumerable<BlogTBL> blogValue { get; set; }
        public IEnumerable<BlogTBL> recentBlog { get; set; }
        public IEnumerable<YorumlarTBL> yorumValue { get; set; }
    }
}