using InternetMagazin.Db;
using InternetMagazin.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InternetMagazin.Controllers
{
    public class CustomerController : Controller
    {

        DataContext _context;
        IHostingEnvironment _appEnvironment;
        public CustomerController(DataContext context, IHostingEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        public async Task<IActionResult> Index(UserViewModel user)
        {
            if (User.Identity.IsAuthenticated)
            {
                List<ProductViewModel> Products = await _context.Products.ToListAsync<ProductViewModel>();
                ViewBag.GetImagesProducts = await _context.Product_Galeries.ToListAsync<Product_GaleryViewModel>();
                ViewBag.GetCategories = await _context.Categories.ToListAsync<CategoryViewModel>();
                ViewBag.GetUserModel = user;
                return View("Index", Products);
            }
            return BadRequest();
        }




        [HttpGet]
        public async Task<IActionResult> Index_product(int id)
        {
            ViewBag.Category = _context.Categories.Where(p => p.Id == id).FirstOrDefault<CategoryViewModel>();
            List<ProductViewModel> Products = await _context.Products.Where(p => p.CategoryId == id).ToListAsync<ProductViewModel>();
            ViewBag.GetImagesProducts = await _context.Product_Galeries.ToListAsync<Product_GaleryViewModel>();
            return View("Index_product", Products);
        }



        public async Task<string> Add_to_cart(int id)
        {
            try
            {

                ProductViewModel product =  await _context.Products.Where(p => p.Id == id).SingleAsync();
                var user = GetUserModel();
                var item_cart = new CartViewModel();
                item_cart.UserId = user.Id;
                item_cart.ProductId = id;
                item_cart.Price = product.Is_sale==1?product.Price_Discount:product.Price;
                item_cart.Quantity = 1;
                item_cart.Created_at = DateTime.Now.Date.ToString();
                item_cart.Updated_at = null;
                var carts = await _context.Carts.Where(p => p.ProductId == id && p.UserId == user.Id).ToArrayAsync();
                if (carts.Count() > 0)
                    return "В корзину раньше было добавлено!";
            _context.Carts.Add(item_cart);
                await _context.SaveChangesAsync();
            return "В корзину успешно добавлен!";
            }
            catch (SqlException ex)
            {
                return "Error:"+ex.Message;
            }
          
        }


        public async Task<string> Add_to_wishlist(int id)
        {
            try
            {
                var user = GetUserModel();
                var carts = await _context.Wishlists.Where(p => p.ProductId == id && p.UserId == user.Id).ToListAsync();
                if (carts.Count() > 0)
                    return "В список желании раньше было добавлено!";
                _context.Wishlists.Add(new WishlistViewModel() { ProductId=id,UserId=user.Id});
                await _context.SaveChangesAsync();
                return "В список желании успешно добавлен!";
            }
            catch (SqlException ex)
            {
                return "Error:" + ex.Message;
            }

        }

        public async Task<IActionResult> Edit(int id)
        {
            return View("edit", await _context.Users.Where(p => p.Id == id).SingleAsync());
        }


        public async Task<string> Save_edit(UserViewModel user, IFormFile image)
        {
            if (user.LastName != null && user.FirstName != null && user.Phone.Length==9 && int.TryParse(user.Phone, out int B) && user.City != null && user.Addres != null)
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
                if (image != null)
                {
                    User.Image = image.FileName;
                    using (FileStream output = System.IO.File.Create(this._appEnvironment.WebRootPath + "\\uploads\\users\\" + User.Id + "\\" + User.Image))
                        await image.CopyToAsync(output);
                }
                await _context.SaveChangesAsync();
                return "Успешно сохранено!";
            }
            return "Вы не сможете изменить данны по таким образом!";
        }


        public async Task<IActionResult> GetWishlist(int id)
        {
            List<WishlistViewModel> wishlist = await _context.Wishlists.Where(p => p.UserId == id).ToListAsync();
            List<ProductViewModel> products = new List<ProductViewModel>();
            foreach (var wish in wishlist)
            {
                products.Add(await _context.Products.Where(p => p.Id == wish.ProductId).FirstAsync<ProductViewModel>());
            }
            ViewBag.GetImagesProducts= await _context.Product_Galeries.ToListAsync<Product_GaleryViewModel>();
            return View("wishlist",products);
        }

        public async Task<bool> Delete_item_wishlist(int id)
        {
            _context.Wishlists.Remove(await _context.Wishlists.Where(p => p.ProductId == id).SingleAsync());
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IActionResult> GetItemCart(int id)
        {
            List<CartViewModel> Cart = await _context.Carts.Where(p => p.UserId == id).ToListAsync();
            List<ProductViewModel> products = new List<ProductViewModel>();
            foreach (var item in Cart)
            {
                products.Add(await _context.Products.Where(p => p.Id == item.ProductId).FirstAsync<ProductViewModel>());
            }
            ViewBag.GetImagesProducts = await _context.Product_Galeries.ToListAsync<Product_GaleryViewModel>();
            return View("cart", products);
        }

        public async Task<bool> Delete_item_cart(int id)
        {
            _context.Carts.Remove(await _context.Carts.Where(p => p.ProductId == id).SingleAsync());
            await _context.SaveChangesAsync();
            return true;
        } 


        public UserViewModel GetUserModel()
        {
            var objLoggedInUser = new UserViewModel();
            if (User.Identity.IsAuthenticated)
            {
                var claimsIndentity = HttpContext.User.Identity as ClaimsIdentity;
                var userClaims = claimsIndentity.Claims;

                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    foreach (var claim in userClaims)
                    {
                        var cType = claim.Type;
                        var cValue = claim.Value;
                        switch (cType)
                        {
                            case "LastName":
                                objLoggedInUser.LastName = cValue;
                                break;
                            case "FirstName":
                                objLoggedInUser.FirstName = cValue;
                                break;
                            case "MiddleName":
                                objLoggedInUser.MiddleName = cValue;
                                break;
                            case "Phone":
                                objLoggedInUser.Phone = cValue;
                                break;
                            case "Addres":
                                objLoggedInUser.Addres = cValue;
                                break;
                            case "City":
                                objLoggedInUser.City = cValue;
                                break;
                            case "Email":
                                objLoggedInUser.Email = cValue;
                                break;
                            case "Image":
                                objLoggedInUser.Image = cValue;
                                break;
                            case "Rolle":
                                objLoggedInUser.RollesId = Convert.ToInt32(cValue);
                                break;
                            case "Id":
                                objLoggedInUser.Id = Convert.ToInt32(cValue);
                                break;
                        }
                    }

                }
            }
            return objLoggedInUser;
        }
    }
}