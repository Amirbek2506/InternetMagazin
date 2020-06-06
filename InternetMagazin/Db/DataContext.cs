using InternetMagazin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMagazin.Db
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<RollViewModel> Rolles { get; set; }
        public DbSet<UserViewModel> Users { get; set; }
        public DbSet<CartViewModel> Carts { get; set; }
        public DbSet<CategoryViewModel> Categories { get; set; }
        public DbSet<Order_ItemViewModel> Order_Items { get; set; }
        public DbSet<OrderViewModel> Orders { get; set; }
        public DbSet<ProductViewModel> Products { get; set; }
        public DbSet<Product_GaleryViewModel> Product_Galeries { get; set; }
        public DbSet<ReviewViewModel> Reviews { get; set; }
        public DbSet<SiteProperty> SiteProperties { get; set; }
        public DbSet<SlideShowViewModel> SlideShows { get; set; }


    }
}
