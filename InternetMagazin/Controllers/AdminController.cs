using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using InternetMagazin.Db;
using InternetMagazin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace InternetMagazin.Controllers
{
    public class AdminController : Controller
    {
        DataContext _context;
        IHostingEnvironment _appEnvironment;
        public AdminController(DataContext context, IHostingEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }


        [HttpPost]
        public async Task<IActionResult> Create_product(ProductViewModel product,string imageProduct)
        {
            if (product.Title != null && product.Quontity!=0 && product.Price!=0 && product.Articul!=null)
            {
                try
                {
                    _context.Products.Add(product);
                    if (await _context.SaveChangesAsync()>0)
                    {
                        await SaveImages(imageProduct, product.Id);
                        product.Product_Galeries = await _context.Product_Galeries.Where(p => p.ProductsId == product.Id).ToListAsync<Product_GaleryViewModel>();
                        return View("Create_product", product);
                    }
                }
                catch (SqlException ex)
                {
                    return View("Error",ex);
                }
            }
            return View();
        }


        [HttpPost]
        public async Task<string> AddImageProduct(IFormFile file,string folderName, string folderproductsName)
        {
            string filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                if (filename.Contains("\\"))
                    filename = filename.Substring(filename.LastIndexOf("\\") + 1);
                string Addresfile = this._appEnvironment.WebRootPath + "\\uploads\\"+ folderproductsName+folderName + "\\" + filename;
                using (FileStream output = System.IO.File.Create(Addresfile))
                    await file.CopyToAsync(output);
                if(folderName!="temp")
                {
                _context.Product_Galeries.Add(new Product_GaleryViewModel() { ProductsId=Convert.ToInt32(folderName),Image=filename});
                 await _context.SaveChangesAsync();
                return folderName + "/" + filename;
                }
                return filename;
        }



        [HttpGet]
        public async Task<IActionResult> Index(UserViewModel user)
        {
            if(User.Identity.IsAuthenticated)
            {
            ViewBag.GetCategories =await _context.Categories.ToListAsync<CategoryViewModel>();
                return View("Index",user);
            }
            return NotFound();
        }


        //Control Products
        [HttpGet]
        public async Task<IActionResult> Index_product(int id)
        {
            ViewBag.Category = _context.Categories.Where(p => p.Id == id).FirstOrDefault<CategoryViewModel>();
            List<ProductViewModel> Products=await _context.Products.Where(p => p.CategoryId == id).ToListAsync<ProductViewModel>();
            ViewBag.GetImagesProducts =await _context.Product_Galeries.ToListAsync<Product_GaleryViewModel>();
            ViewBag.GetCategories = await _context.Categories.ToListAsync<CategoryViewModel>();
            return View("Index_product",Products);
        }
        public async Task<string> Delete_product(int id)
        {
            try
            {
                _context.Products.Remove(await _context.Products.Where(p => p.Id == id).SingleAsync());
                List<Product_GaleryViewModel> listgalery = await _context.Product_Galeries.Where(p => p.ProductsId == id).ToListAsync<Product_GaleryViewModel>();
                if(listgalery.Count()>0)
                _context.Product_Galeries.RemoveRange(listgalery);
                List<WishlistViewModel> wishlist = await _context.Wishlists.Where(p => p.ProductId == id).ToListAsync();
                _context.Wishlists.RemoveRange(wishlist);
                List<CartViewModel> cartitems = await _context.Carts.Where(p => p.ProductId == id).ToListAsync();
                _context.Carts.RemoveRange(cartitems);
                await _context.SaveChangesAsync();
                string addresfolderimage = this._appEnvironment.WebRootPath +"\\uploads\\products\\"+id;
                if (Directory.Exists(addresfolderimage))
                    Directory.Delete(addresfolderimage,true);
                return "Успешно удален!";
            }
            catch(SqlException ex)
            {
                return ex.Message;
            }
            
        }

        public async Task<IActionResult> Edit_product(int id)
        {
            try
            {
               var res= await _context.Products.Where(p => p.Id == id).SingleAsync<ProductViewModel>();
               res.Product_Galeries = await _context.Product_Galeries.Where(p => p.ProductsId == res.Id).ToListAsync();
               return View("Edit_product",res);
            }
             catch (SqlException ex)
            {
                return View("Error", ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save_edit_product(ProductViewModel product)
        {
            try
            {
                if (product.Title != null && product.Quontity != 0 && product.Price != 0 && product.Articul != null)
                {
                    ProductViewModel Product = await _context.Products.Where(p => p.Id == product.Id).SingleAsync();
                    Product.Title = product.Title;
                    Product.Quontity = product.Quontity;
                    Product.Price = product.Price;
                    Product.Price_Discount = product.Price_Discount;
                    Product.Is_sale = product.Is_sale;
                    Product.Is_new = product.Is_new;
                    Product.Articul = product.Articul;
                    Product.Description = product.Description;

                    if (await _context.SaveChangesAsync() > 0)
                    {
                        Product.Product_Galeries = await _context.Product_Galeries.Where(p => p.ProductsId == Product.Id).ToListAsync<Product_GaleryViewModel>();
                        return View("Save_edit_product", Product);
                    }
                }
                return null;
            }
            catch (SqlException ex)
            {
                return View("Error", ex.Message);
            }
        }





        // Function MoveImages and SaveImages at db 
        public async Task<bool> SaveImages(string imagesproduct,int id)
        {
            try
            {
                //Create folder if on not exists
                string folder = this._appEnvironment.WebRootPath + "\\uploads\\products\\" + id;
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                if (imagesproduct != null)
                {
                    string[] ImagesArr = imagesproduct.Split(',');
                    foreach (var Image in ImagesArr)
                    {
                        string path = this._appEnvironment.WebRootPath + "\\uploads\\temp\\" + Image;
                        string path2 = this._appEnvironment.WebRootPath + "\\uploads\\products\\" + id + "\\" + Image;
                        if (!System.IO.File.Exists(path))
                        {
                            using (FileStream fs = System.IO.File.Create(path)) { }
                        }
                        if (System.IO.File.Exists(path2))
                            System.IO.File.Delete(path2);
                        
                        System.IO.File.Move(path, path2);
                        _context.Product_Galeries.Add(new Product_GaleryViewModel() { ProductsId = id, Image = Image });
                    }
                    await _context.SaveChangesAsync();
                }
                    return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> DeleteImage(int id)
        {
            _context.Product_Galeries.Remove(await _context.Product_Galeries.Where(p=>p.Id==id).SingleAsync<Product_GaleryViewModel>());
            await _context.SaveChangesAsync();
            return true;
        }


        //Control Categories
        public async Task<IActionResult> categories(int id)
        {
            CategoryViewModel categoryname;
            if (id!=0)
            {
                 categoryname = (await _context.Categories.Where(p => p.Id == id).SingleAsync<CategoryViewModel>());
            }
            else
            {
                categoryname = new CategoryViewModel() { Title = "Категории на главной", Id=0};
            }
            ViewBag.CategoryName = categoryname;
            List<CategoryViewModel> OutputCategoriesModel = await _context.Categories.Where(p => p.ParentId == id).ToListAsync<CategoryViewModel>();
            return View("Index_categories",OutputCategoriesModel);
        }

        public async Task<int> Create_category(CategoryViewModel category,IFormFile image)
        {
            category.Image = image.FileName;
            _context.Categories.Add(category);
          if( await _context.SaveChangesAsync()>0)
            {string folder = this._appEnvironment.WebRootPath + "\\uploads\\categories\\" +category.Id;
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            if (image != null)
            {
                using (FileStream output = System.IO.File.Create(this._appEnvironment.WebRootPath + "\\uploads\\categories\\" + category.Id + "\\" + category.Image))
                    await image.CopyToAsync(output);
            }
            }
            return category.Id;
        }

        public async Task<bool> Delete_category(int id)
        {
            List<CategoryViewModel> podcategories=await _context.Categories.Where(p => p.ParentId == id).ToListAsync();
            if(podcategories.Count()>0)
            {
                foreach(var category in podcategories)
                {
                    _context.Categories.Remove(await _context.Categories.Where(p => p.Id == category.Id).SingleAsync());
                    await Delete_ProductsByCategory(category.Id);
                }
            }
            _context.Categories.Remove(await _context.Categories.Where(p => p.Id == id).SingleAsync());
            await Delete_ProductsByCategory(id);
            string addresfolderimage = $"{this._appEnvironment.WebRootPath }\\uploads\\categories\\{id}";
            if (Directory.Exists(addresfolderimage))
                Directory.Delete(addresfolderimage, true);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task Delete_ProductsByCategory(int categoryid)
        {
            List<ProductViewModel> products=await _context.Products.Where(p=>p.CategoryId==categoryid).ToListAsync();
            if (products.Count() > 0)
            {
                foreach (var prod in products)
                {
                    _context.Products.Remove(await _context.Products.Where(p => p.Id == prod.Id).SingleAsync());
                    List<Product_GaleryViewModel> listgalery = await _context.Product_Galeries.Where(p => p.ProductsId == prod.Id).ToListAsync<Product_GaleryViewModel>();
                    if (listgalery.Count() > 0)
                        _context.Product_Galeries.RemoveRange(listgalery);
                    List<WishlistViewModel> wishlist = await _context.Wishlists.Where(p => p.ProductId == prod.Id).ToListAsync();
                    _context.Wishlists.RemoveRange(wishlist);
                    List<CartViewModel> cartitems = await _context.Carts.Where(p => p.ProductId == prod.Id).ToListAsync();
                    _context.Carts.RemoveRange(cartitems);
                    await _context.SaveChangesAsync();
                    string addresfolderimage = $"{this._appEnvironment.WebRootPath }\\uploads\\products\\{prod.Id}";
                    if (Directory.Exists(addresfolderimage))
                        Directory.Delete(addresfolderimage, true);
                }
            }
        }



        //Control Users
        public async Task<IActionResult> Index_users()
        {
            ViewBag.Roles = await _context.Rolles.ToListAsync<RollViewModel>();
           List<UserViewModel> Users= await _context.Users.ToListAsync<UserViewModel>();
            return View("Index_Users", Users);
        }

        public async Task<IActionResult> Create_user(UserViewModel user,IFormFile image)
        {
            user.Image = image.FileName;
            _context.Users.Add(user);
            if(await _context.SaveChangesAsync()>0)
            {
                string folder = this._appEnvironment.WebRootPath + "\\uploads\\users\\"+user.Id;
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                if(image!=null)
                using (FileStream output = System.IO.File.Create(folder+"\\"+user.Image))
                    await image.CopyToAsync(output);
            }
            return View("Create_user",user);
        }

        public async Task<string> Delete_user(int id)
        {
            try
            {
                _context.Users.Remove(await _context.Users.Where(p => p.Id == id).SingleAsync());
                List<WishlistViewModel> wishlist = await _context.Wishlists.Where(p => p.UserId == id).ToListAsync();
                if (wishlist.Count() > 0)
                {
                    _context.Wishlists.RemoveRange(wishlist);
                }
                List<CartViewModel> carts = await _context.Carts.Where(p => p.UserId == id).ToListAsync();
                if (carts.Count() > 0)
                {
                    _context.Carts.RemoveRange(carts);
                }
                List<OrderViewModel> orders = await _context.Orders.Where(p => p.UserId == id).ToListAsync();
                if (orders.Count() > 0)
                {
                    foreach (var item in orders)
                    {
                        _context.Orders.Remove(item);
                        _context.Order_Items.RemoveRange(await _context.Order_Items.Where(p => p.OrderId == item.Id).ToListAsync());
                    }
                }
                if (await _context.SaveChangesAsync() > 0)
                {
                    string addresfolderimage = $"{this._appEnvironment.WebRootPath }\\uploads\\users\\{id}";
                    if (Directory.Exists(addresfolderimage))
                        Directory.Delete(addresfolderimage, true);
                }
                return "Удаления успешно завершен!";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public async Task<IActionResult> Edit_user(int id)
        {
            ViewBag.Roles = await _context.Rolles.ToListAsync<RollViewModel>();
            return View("Edit_user",await _context.Users.Where(p=>p.Id==id).SingleAsync<UserViewModel>());
        }

        public async Task<IActionResult> Save_edit_user(UserViewModel user,IFormFile image)
        {
            if(user.LastName!=null && user.FirstName!=null && user.Phone!=null && user.City!=null && user.Addres!=null)
            {
                var User = await _context.Users.Where(p => p.Id == user.Id).SingleAsync();
                User.LastName = user.LastName;
                User.FirstName = user.FirstName;
                User.MiddleName = user.MiddleName;
                User.Phone = user.Phone;
                User.City = user.City;
                User.Addres = user.Addres;
                User.Email = user.Email;
                if (user.Password != null)
                    User.Password = user.Password;
                User.RollesId = user.RollesId;
                if(image!=null)
                {
                    User.Image = image.FileName;
                    using (FileStream output = System.IO.File.Create(this._appEnvironment.WebRootPath + "\\uploads\\users\\" + user.Id +"\\"+ User.Image))
                        await image.CopyToAsync(output);
                }
                 await _context.SaveChangesAsync();
                return View("Save_edit_user", User);
            }
            return View();
        }




        //Control orders
        public async Task<IActionResult> Index_orders()
        {
            ViewBag.GetUsers = await _context.Users.ToListAsync();
            return View("index_orders", await _context.Orders.ToListAsync());
        }


        public async Task<IActionResult> Order_details(int id)
        {
            OrderViewModel order = await _context.Orders.Where(p => p.Id == id).SingleAsync();
            ViewBag.User = await _context.Users.Where(p => p.Id == order.UserId).SingleAsync();
            ViewBag.Get_order_items = await _context.Order_Items.Where(p => p.OrderId == order.Id).ToListAsync();
            ViewBag.GetProducts = await _context.Products.ToListAsync();
            ViewBag.GetProduct_Galeries = await _context.Product_Galeries.ToListAsync();
            return View("order_details", order);
        }


        public async Task<int> Save_sts_order(int id,int sts)
        {
            var order= await _context.Orders.Where(p => p.Id == id).SingleAsync();
            order.Order_Status = sts;order.Updated_at = DateTime.Now.Date;
            await _context.Order_Items.Where(p => p.OrderId == order.Id).ForEachAsync(p => p.Updated_at = DateTime.Now.Date);
            await _context.SaveChangesAsync();
            return sts;
        }


        public async Task<bool> Delete_order(int id)
        {
           _context.Orders.Remove(await _context.Orders.Where(p => p.Id == id).SingleAsync());
            _context.Order_Items.RemoveRange(await _context.Order_Items.Where(p => p.OrderId == id).ToListAsync());
            await _context.SaveChangesAsync();
            return true;
        }
    }
}