using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using InternetMagazin.Db;
using InternetMagazin.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
                item_cart.Price = 10m;
                item_cart.Quantity = 1;
                item_cart.Created_at = null;
                item_cart.Updated_at = null;
            _context.Carts.Add(item_cart);
                await _context.SaveChangesAsync();
            return "Успешно добавлен!";
            }
            catch (SqlException ex)
            {
                return "Error:"+ex.Message;
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