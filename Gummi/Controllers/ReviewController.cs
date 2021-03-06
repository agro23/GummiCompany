﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gummi.Models;
using Gummi.Models.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gummi.Controllers
{
    public class ReviewsController : Controller
    {
        private GummiDbContext db = new GummiDbContext();
        private EFReviewRepository db1;

        private IReviewRepository reviewRepo;  


        public ReviewsController(EFReviewRepository db1)
        {
            this.db1 = db1;
        }

        //private IReviewRepository @object;

        //public ReviewsController(IReviewRepository @object)
        //{
        //    this.@object = @object;
        //}

        public IActionResult Index()
        {
            List<Review> model = db.Reviews.ToList();
            return View(model);
        }

        public ReviewsController(IReviewRepository repo = null)
        {
            if (repo == null) // repo is not null
            {
                this.reviewRepo = new EFReviewRepository();
            }
            else
            {
                this.reviewRepo = repo;
            }
        }




        [HttpPost]
        public IActionResult Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            Review newReview = new Review(int.Parse(Request.Form["ProductId"]), Request.Form["Author"], Request.Form["Content"], int.Parse(Request.Form["Rating"]));
            db.Reviews.Add(newReview);
            db.SaveChanges();
        return RedirectToAction("Details", "Products", new { id = newReview.ProductId });
            //return RedirectToAction("Details", "Product", newReview.ProductId);

            //return View("Product/Details/", newReview.ProductId)
        }

        public IActionResult Edit(int id)
        {
            var thisReview = db.Reviews.FirstOrDefault(Reviews => Reviews.ReviewId == id);
            return View(thisReview);
        }

        [HttpPost]
        public IActionResult Edit(Review review)
        {
            db.Entry(review).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var thisReview = db.Reviews.FirstOrDefault(Reviews => Reviews.ReviewId == id);
            return View(thisReview);
        }

        public IActionResult Delete(int id)
        {
            var thisReview = db.Reviews.FirstOrDefault(Reviews => Reviews.ReviewId == id);
            return View(thisReview);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisReview = db.Reviews.FirstOrDefault(Reviews => Reviews.ReviewId == id);
            db.Reviews.Remove(thisReview);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
