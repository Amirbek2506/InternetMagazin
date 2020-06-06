using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMagazin.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Articul { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal Price_Discount { get; set; }
        public string Description { get; set; }
        public int Is_new { get; set; }
        public int Is_sale { get; set; }
        public int Quontity { get; set; }

        public CategoryViewModel Category { get; set; }
        public virtual ICollection<CartViewModel> Carts { get; set; }
        public virtual ICollection<Order_ItemViewModel> Order_Items { get; set; }
        public virtual ICollection<Product_GaleryViewModel> Product_Galeries { get; set; }

    }
}
