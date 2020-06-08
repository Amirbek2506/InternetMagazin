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

namespace InternetMagazin.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Category = _context.Categories.ToList<CategoryViewModel>();
            ViewBag.UserModel = GetUserModel();
            return View();
        }

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
            return RedirectToAction("Index");
        }

        public IActionResult Logoff()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public JsonResult EndSession()
        {
            HttpContext.Session.Clear();
            return Json(new { result = "success" });
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private IEnumerable<Claim> GetUserClaims(UserViewModel user)
        {
            List<Claim> claims = new List<Claim>();
            Claim _claim;
            _claim = new Claim("LastName", user.LastName);
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
        private UserViewModel GetUserModel()
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
                        }
                    }
                }
            }
            return objLoggedInUser;
        }
    }
}
