﻿using System;
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
                _context.Products.Remove(await _context.Products.Where(p => p.Id == id).SingleAsync());
                List<Product_GaleryViewModel> listgalery = await _context.Product_Galeries.Where(p => p.ProductsId == id).ToListAsync<Product_GaleryViewModel>();
                if(listgalery.Count()>0)
                _context.Product_Galeries.RemoveRange(listgalery);
                await _context.SaveChangesAsync();
                string addresfolderimage = $"{this._appEnvironment.WebRootPath }\\uploads\\products\\{id}";
                if (!Directory.Exists(addresfolderimage))
                    Directory.Delete(addresfolderimage);
                
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
               var res= await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync<ProductViewModel>();
               res.Product_Galeries = await _context.Product_Galeries.Where(p => p.ProductsId == res.Id).ToListAsync();
               return View("Edit_product",res);
            }
             catch (SqlException ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save_edit_product(ProductViewModel product)
        {
            if (product.Title != null && product.Quontity != 0 && product.Price != 0 && product.Articul != null)
            {
                ProductViewModel Product =await _context.Products.Where(p => p.Id == product.Id).SingleAsync();
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
                    Product.Product_Galeries = await _context.Product_Galeries.Where(p=>p.ProductsId==Product.Id).ToListAsync<Product_GaleryViewModel>();
                    return View("Save_edit_product", Product);
                    }
            }
            return null;
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


        //categories
        public async Task<IActionResult> categories(int id)
        {
            List<CategoryViewModel> OutputCategoriesModel = await _context.Categories.Where(p => p.ParentId == id).ToListAsync<CategoryViewModel>();
            return View("Index_categories",OutputCategoriesModel);
        }
    }
}