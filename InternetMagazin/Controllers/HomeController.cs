using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InternetMagazin.Models;
using InternetMagazin.Db;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Data.SqlClient;

namespace InternetMagazin.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context;
        IHostingEnvironment _appEnvironment;
        public HomeController(DataContext context, IHostingEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ProductViewModel> Products = await _context.Products.ToListAsync<ProductViewModel>();
            ViewBag.GetImagesProducts = await _context.Product_Galeries.ToListAsync<Product_GaleryViewModel>();
            ViewBag.GetCategories = await _context.Categories.ToListAsync<CategoryViewModel>();
            return View("Index", Products);
        }

        public async Task<string> Registr_user(UserViewModel user, IFormFile image)
        {
            try
            {
                List<UserViewModel> Users = await _context.Users.Where(p => p.Phone == user.Phone || p.Password == user.Password).ToListAsync<UserViewModel>();
                if (Users.Count() == 0)
                {
                    if (user.FirstName != null && user.LastName != null && user.Phone.Length == 9 && int.TryParse(user.Phone, out int B) && user.Password != null && user.Addres != null && user.City != null)
                    {
                        user.RollesId = 2;
                        user.Image = (image != null) ? image.FileName : null;
                        _context.Add(user);
                        if (await _context.SaveChangesAsync() > 0)
                        {
                            string folder = this._appEnvironment.WebRootPath + "\\uploads\\users\\" + user.Id;
                            if (!Directory.Exists(folder))
                                Directory.CreateDirectory(folder);
                            if (image != null)
                                using (FileStream output = System.IO.File.Create(folder + "\\" + user.Image))
                                    await image.CopyToAsync(output);
                            return "Регистрация успешно завершен!";
                        }
                    }
                    return "Не коректние данны";
                }
                return "Клиент по такой логин или пароль уже существует!";
            }
            catch(SqlException ex)
            {
                return "error: " + ex.Message;
            }
        }


        [HttpGet]
        public async Task<IActionResult> Index_product(int id)
        {
            ViewBag.Category = _context.Categories.Where(p => p.Id == id).FirstOrDefault<CategoryViewModel>();
            List<ProductViewModel> Products = await _context.Products.Where(p => p.CategoryId == id).ToListAsync<ProductViewModel>();
            ViewBag.GetImagesProducts = await _context.Product_Galeries.ToListAsync<Product_GaleryViewModel>();
            return View("Index_product", Products);
        }



        //Authentification
        public IActionResult LoginUser(UserViewModel user)
    {
            string token = null;
            UserViewModel Us = _context.Users.Where(x => x.Phone == user.Phone).FirstOrDefault();
            if (Us == null)
                return null;
            if (user.Password == Us.Password)
            {
                var key = Encoding.ASCII.GetBytes("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c");
                var JWToken = new JwtSecurityToken(
                    issuer: "http://localhost:44381/",
                    audience: "http://localhost:44381/",
                    claims: GetUserClaims(Us),
                    notBefore: new DateTimeOffset(DateTime.Now).DateTime,
                    expires: new DateTimeOffset(DateTime.Now.AddDays(1)).DateTime,
                    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                );
                 token = new JwtSecurityTokenHandler().WriteToken(JWToken);
            }
            if (token != null)
            {
                HttpContext.Session.SetString("JWToken", token);
            }
            int id = Us.Id;
            if (Us.RollesId == 1)
                return RedirectToAction("Index","Admin");
            return RedirectToAction("Index","Customer");
    }

        public IActionResult Logoff()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


        private IEnumerable<Claim> GetUserClaims(UserViewModel user)
        {
            List<Claim> claims = new List<Claim>();
            Claim _claim;
            _claim = new Claim("LastName", user.LastName);
            claims.Add(_claim);
            _claim = new Claim("Id", user.Id.ToString());
            claims.Add(_claim);
            _claim = new Claim("FirstName", user.FirstName);
            claims.Add(_claim);
            if (user.MiddleName != null)
            {
                _claim = new Claim("MiddleName", user.MiddleName);
                claims.Add(_claim);
            }
            _claim = new Claim("Phone", user.Phone);
            claims.Add(_claim);
            _claim = new Claim("Addres", user.Addres);
            claims.Add(_claim);
            _claim = new Claim("City", user.City);
            claims.Add(_claim);
            _claim = new Claim("Email", user.Email);
            claims.Add(_claim);
            _claim = new Claim("Image", user.Image);
            claims.Add(_claim);
            _claim = new Claim("Rolle", user.RollesId.ToString());
            claims.Add(_claim);
            return claims.AsEnumerable<Claim>();
        }
    }
}
