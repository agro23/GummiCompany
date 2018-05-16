using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gummi.Models;

namespace Gummi.Models
//namespace Gummi.Tests.Models
{
    public class GummiTestDbContext : GummiDbContext
    {

        public override DbSet<Product> Products { get; set; }
        public override DbSet<Review> Reviews { get; set; }
        //public DbSet<User> Users { get; set; }

        //public DbSet<Person> People { get; set; }
        //public DbSet<ExperiencePeople> ExperiencePeople { get; set; }

        public GummiTestDbContext()
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseMySql(@"Server=localhost;Port=8889;database=gummitest;uid=root;pwd=root;");
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //=> optionsBuilder
            //.UseMySql(@"Server=localhost;Port=8889;database=gummitest;uid=root;pwd=root;");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;database=gummitest;uid=root;pwd=root;");
        }


    }
}

//using Microsoft.EntityFrameworkCore;

//namespace ToDoList.Models
//{
//    public class TestDbContext : ToDoListContext
//    {
//        public override DbSet<Item> Items { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder options)
//        {
//            options.UseMySql(@"Server=localhost;database=todolist_test;uid=root;pwd=root;");
//        }
//    }
//}
