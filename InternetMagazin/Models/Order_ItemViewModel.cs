using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMagazin.Models
{
    public class Order_ItemViewModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

        public ProductViewModel Product { get; set; }
        public OrderViewModel Order { get; set; }

    }
}
