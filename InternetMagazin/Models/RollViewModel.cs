using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMagazin.Models
{
    public class RollViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<UserViewModel> Users { get; set; }
    }
}
