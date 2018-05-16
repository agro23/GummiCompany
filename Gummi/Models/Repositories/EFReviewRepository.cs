using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gummi.Models;

namespace Gummi.Models.Repositories
{
    public class EFReviewRepository : IReviewRepository
    {
        GummiDbContext db = new GummiDbContext();
        private GummiDbContext GummiDbContext;

        public EFReviewRepository(GummiDbContext GummiDbContext)
        {
            this.GummiDbContext = GummiDbContext;
        }

        public EFReviewRepository()
        {
        }

        public IQueryable<Review> Reviews
        { get { return db.Reviews; } }

        public Review Save(Review product)
        {
            db.Reviews.Add(product);
            db.SaveChanges();
            return product;
        }

        public Review Edit(Review product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return product;
        }

        public void Remove(Review product)
        {
            db.Reviews.Remove(product);
            db.SaveChanges();
        }
    }

}






