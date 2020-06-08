using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMagazin.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public int RollesId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Remember { get; set; }
        public string Addres { get; set; }
        public string City { get; set; }
        public string Image { get; set; }

        public RollViewModel Rolles { get; set; }
        public virtual ICollection<CartViewModel> Carts { get; set; }
        public virtual ICollection<OrderViewModel> Orders { get; set; }
        public virtual ICollection<ReviewViewModel> Reviews { get; set; }


    }
}
