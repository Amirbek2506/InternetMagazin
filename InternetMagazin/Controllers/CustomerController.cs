using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                ViewBag.Category = await _context.Categories.ToListAsync<CategoryViewModel>();
                ViewBag.UserModel = user;
                return View("Index");
            }
            return BadRequest();
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
    }
}