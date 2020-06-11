using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMagazin.Models
{
    public class Product_GaleryViewModel
    {
        public int Id { get; set; }
        public int ProductsId { get; set; }
        public string Image { get; set; }

        public ProductViewModel Products { get; set; }
    }
}
