using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMagazin.Models
{
    public class ReviewViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

        public UserViewModel Users { get; set; }
    }
}
