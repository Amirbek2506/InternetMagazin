using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetMagazin.Db;
using InternetMagazin.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternetMagazin.Controllers
{
    public class AdminController : Controller
    {
        DataContext _context;
        public AdminController(DataContext context)
        {
            _context = context;
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
            return View();
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