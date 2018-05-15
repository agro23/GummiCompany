using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gummi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gummi.Controllers
{
    public class ProductsController : Controller
    {
        private GummiDbContext db = new GummiDbContext();
        public IActionResult Index()
        {
            List<Product> model = db.Products.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(Products => Products.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //public IActionResult Details(int id)
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


        public IActionResult Delete(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(Products => Products.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(Products => Products.ProductId == id);
            db.Products.Remove(thisProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}


     /*


List<Product> products = db.Products.Include(p => p.Reviews).ToList();
List<Product> sortedProducts = products.OrderByDescending(p => p.AverageRating()).ToList();
if (sortedProducts.Count >= 3)
    {
        List<Product> topThree = new List<Product> { sortedProducts[0], sortedProducts[1], sortedProducts[2] };
        return View(topThree);
    }
else
    {
        return View(sortedProducts);
    }



*/