using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMagazin.Models
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }

        public UserViewModel User { get; set; }
        public ProductViewModel Product { get; set; }


    }
}
