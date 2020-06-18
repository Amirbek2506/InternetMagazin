using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMagazin.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Order_Date { get; set; }
        public decimal Order_Sum { get; set; }
        public int Order_Status { get; set; }
        public string Order_Number { get; set; }
        public string Payment_type { get; set; }
        public string Delivery_type { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

        public UserViewModel User { get; set; }

        public virtual ICollection<Order_ItemViewModel> Order_Items { get; set; }

    }
}
