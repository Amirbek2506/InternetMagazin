using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMagazin.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public virtual ICollection<ProductViewModel> Products { get; set; }


    }
}
