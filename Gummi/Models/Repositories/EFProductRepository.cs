
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gummi.Models;

namespace Gummi.Models.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        //GummiDbContext db = new GummiDbContext();
        private GummiDbContext GummiDbContext;

        //public EFProductRepository(GummiDbContext GummiDbContext)
        //{
        //    this.GummiDbContext = GummiDbContext;
        //}



        GummiDbContext db;
        public EFProductRepository()
        {
            db = new GummiDbContext();
        }
        public EFProductRepository(GummiDbContext thisDb)
        {
            db = thisDb;
        }





        //public EFProductRepository()
        //{
        //}

        //public Product Index(Product product) // ADDED THIS
        //{
        //    return product;
        //}
        
        public IQueryable<Product> Products
        { get { return db.Products; } }

        public Product Save(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return product;
        }

        public Product Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return product;
        }

        public void Remove(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }

}






