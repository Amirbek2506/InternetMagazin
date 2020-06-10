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
        public string Create_product(ProductViewModel prod)
        {
            return "dd";
        }


        [HttpPost]
        public async Task<string> AddImageProduct(IFormFile file)
        {
            string filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                if (filename.Contains("\\"))
                    filename = filename.Substring(filename.LastIndexOf("\\") + 1);
                string Addresfile = this._appEnvironment.WebRootPath + "\\uploads\\products\\" + filename;
                using (FileStream output = System.IO.File.Create(Addresfile))
                    await file.CopyToAsync(output);

                return filename;
        }



        [HttpGet]
        public IActionResult Index()
        {
                ViewBag.GetCategories = _context.Categories.ToList<CategoryViewModel>();
                return View();
        }
        [HttpGet]
        public IActionResult Index_product(int id)
        {
                ViewBag.Category = _context.Categories.Where(p => p.Id == id).FirstOrDefault<CategoryViewModel>();
               ViewBag.GetProducts=_context.Products.Where(p => p.CategoryId == id).ToList<ProductViewModel>();
            ViewBag.GetCategories = _context.Categories.ToList<CategoryViewModel>();
            return this.View();
        }
        public IActionResult Delete(int id)
        {
            _context.Products.Remove(_context.Products.Where(p => p.Id == id).Single());
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int? id,ProductViewModel product)
        {
            if(new HomeController(_context).GetUserModel().RollesId==1)
            {
                if (product != null)
                {
                    _context.Products.Remove(_context.Products.Where(p => p.Id == id).Single());
                    _context.SaveChanges();
                }
                return View();
            }
            return RedirectToAction("Index");
        }



      
        public IActionResult Add_product(ProductViewModel product)
        {
                if (product != null)
                {
                    _context.Products.Add(product);
                    _context.SaveChanges();
                }
                return Redirect("~/Admin/Index_product");
        }

    }
}