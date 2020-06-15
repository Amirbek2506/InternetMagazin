using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetMagazin.Db;
using InternetMagazin.Models;
using Microsoft.AspNetCore.Hosting;
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
    }
}