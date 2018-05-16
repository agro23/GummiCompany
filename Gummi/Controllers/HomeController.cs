using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gummi.Models;

namespace Gummi.Controllers
{
    public class HomeController : Controller
    {
        private GummiDbContext db = new GummiDbContext();
        //    public IActionResult Index()
        //    {
        //        List<Product> model = db.Products.ToList();
        //        return View(model);
        //    }
        public IActionResult Index()
        {
            List<Product> products = db.Products.Include(p => p.Reviews).ToList();
            List<Product> sortedProducts = products.OrderByDescending(p => p.getAverageRating()).ToList();
            if (sortedProducts.Count >= 3)
            {
                List<Product> topThree = new List<Product> { sortedProducts[0], sortedProducts[1], sortedProducts[2] };
                return View(topThree);
            }
            else
            {
                return View(sortedProducts);
            }
        }
    }
}