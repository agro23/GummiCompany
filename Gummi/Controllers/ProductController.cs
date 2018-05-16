using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gummi.Models;
using Gummi.Models.Repositories;

namespace Gummi.Controllers
{
    public class ProductsController : Controller
    {

        private IProductRepository productRepo;  // New!

        public ProductsController(IProductRepository repo = null)
        {
            if (repo == null)
            {
                this.productRepo = new EFProductRepository();
            }
            else
            {
                this.productRepo = repo;
            }
        }

        private GummiDbContext db = new GummiDbContext();

        public ViewResult Index()
        {
            // Updated:
            return View(productRepo.Products.ToList());
        }

        //public IActionResult Index() // MINE
        //{
        //    List<Product> model = db.Products.ToList();
        //    return View(model);
        //}

        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost] // MINE
        //public IActionResult Create(Product product)
        //{
        //    db.Products.Add(product);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public IActionResult Create(Product product)
        {
            productRepo.Save(product);   // Updated
            // Removed db.SaveChanges() call
            return RedirectToAction("Index");
        }



        //public IActionResult Edit(int id) // MINE
        //{
        //    var thisProduct = db.Products.FirstOrDefault(Products => Products.ProductId == id);
        //    return View(thisProduct);
        //}

        //[HttpPost]
        //public IActionResult Edit(Product product)
        //{
        //    db.Entry(product).State = EntityState.Modified;
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}




        public IActionResult Edit(int id)
        {
            // Updated:
            Product thisProduct = productRepo.Products.FirstOrDefault(x => x.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            productRepo.Edit(product);   // Updated!
            // Removed db.SaveChanges() call
            return RedirectToAction("Index");
        }






        //public IActionResult Details(int id) // THEIRS
        //{
        //    var thisProduct = db.Products.FirstOrDefault(Products => Products.ProductId == id);
        //    return View(thisProduct);
        //}

        public IActionResult Details(int id)
        {
            Product thisProduct = db.Products.FirstOrDefault(y => y.ProductId == id);

            thisProduct.Reviews = db.Reviews.Where(c => c.ProductId == id).ToList();

            return View(thisProduct);
        }

        //public IActionResult Details(int id) // THEIRS
        //{
        //    // Updated:
        //    Product thisProduct = productRepo.Products.FirstOrDefault(x => x.ProductId == id);
        //    return View(thisProduct);
        //}

        //public IActionResult Delete(int id) // MINE
        //{
        //    var thisProduct = db.Products.FirstOrDefault(Products => Products.ProductId == id);
        //    return View(thisProduct);
        //}

        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    var thisProduct = db.Products.FirstOrDefault(Products => Products.ProductId == id);
        //    db.Products.Remove(thisProduct);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}


        public IActionResult Delete(int id)
        {
            // Updated:
            Product thisProduct = productRepo.Products.FirstOrDefault(x => x.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            // Updated:
            Product thisProduct = productRepo.Products.FirstOrDefault(x => x.ProductId == id);
            productRepo.Remove(thisProduct);   // Updated!
            // Removed db.SaveChanges() call
            return RedirectToAction("Index");
        }





    }
}

  