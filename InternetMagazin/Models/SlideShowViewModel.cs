using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMagazin.Models
{
    public class SlideShowViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public string Image_Mobile { get; set; }
        public int Is_Active { get; set; }
        public string Description { get; set; }
        public DateTime Date_Add{ get; set; }
        public DateTime Date_And{ get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }


    }
}
