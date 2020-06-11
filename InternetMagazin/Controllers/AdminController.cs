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
        public async Task<string> Create_product(ProductViewModel product,string imageProduct)
        {
            if (product.Title != null && product.Quontity!=0 && product.Price!=0 && product.Articul!=null)
            {
                try
                {
                    _context.Products.Add(product);
                  if(await _context.SaveChangesAsync()>0 && await SaveImages(imageProduct, product.Id))
                    {
                        return "Успешно добавлен!";
                    }
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            return "Продукт не готов для добавления!";
        }


        [HttpPost]
        public async Task<string> AddImageProduct(IFormFile file,string folderName)
        {
            string filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                if (filename.Contains("\\"))
                    filename = filename.Substring(filename.LastIndexOf("\\") + 1);
                string Addresfile = this._appEnvironment.WebRootPath + "\\uploads\\"+folderName+"\\" + filename;
                using (FileStream output = System.IO.File.Create(Addresfile))
                    await file.CopyToAsync(output);

                return filename;
        }



        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.GetCategories =await _context.Categories.ToListAsync<CategoryViewModel>();
                return View();
        }
        [HttpGet]
        public async Task<IActionResult> Index_product(int id=2)
        {
            ViewBag.Category = _context.Categories.Where(p => p.Id == id).FirstOrDefault<CategoryViewModel>();
            ViewBag.GetProducts=await _context.Products.Where(p => p.CategoryId == id).ToListAsync<ProductViewModel>();
            ViewBag.GetImagesProducts =await _context.Product_Galeries.ToListAsync<Product_GaleryViewModel>();
            ViewBag.GetCategories = await _context.Categories.ToListAsync<CategoryViewModel>();
            return this.View();
        }
        public async Task<string> Delete_product(int id)
        {
            try
            {
                _context.Products.Remove(_context.Products.Where(p => p.Id == id).Single());
                await _context.SaveChangesAsync();
                return "Успешно удален!";
            }
            catch(SqlException ex)
            {
                return ex.Message;
            }
            
        }

        public async Task<ProductViewModel> Edit_product(int id)
        {
            return await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync<ProductViewModel>();
            /* try
             {
             }
             catch (SqlException ex)
             {
                // return ex.Message;
             }*/

        }



        // Function MoveImages and SaveImages at db 
        public async Task<bool> SaveImages(string imagesproduct,int id)
        {
            try
            {

                string[] ImagesArr = imagesproduct.Split(',');
                foreach (var Image in ImagesArr)
                {
                    string path = this._appEnvironment.WebRootPath + "\\uploads\\temp\\" + Image;
                    string path2 = this._appEnvironment.WebRootPath + "\\uploads\\products\\" + id.ToString() + "\\" + Image;
                    if (!System.IO.File.Exists(path))
                    {
                        using (FileStream fs = System.IO.File.Create(path)) { }
                    }
                    if (System.IO.File.Exists(path2))
                        System.IO.File.Delete(path2);

                    string folder = this._appEnvironment.WebRootPath + "\\uploads\\products\\" + id.ToString();
                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);
                    System.IO.File.Move(path, path2);
                    _context.Product_Galeries.Add(new Product_GaleryViewModel() { ProductsId = id, Image = Image });
                }
                await _context.SaveChangesAsync();
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}