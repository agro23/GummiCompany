using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gummi.Models;

namespace Gummi.Models
//namespace Gummi.Tests.Models
{
    public class GummiTestDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        //public DbSet<User> Users { get; set; }

        //public DbSet<Person> People { get; set; }
        //public DbSet<ExperiencePeople> ExperiencePeople { get; set; }

        public GummiTestDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;database=gummitest;uid=root;pwd=root;");
        }


    }
}
