using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gummi.Models
{
    public class GummiDbContext : DbContext
    {
        //private DbContextOptions<Gummi.Tests.Models.GummiTestDbContext> options;

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Location> Locations { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        //public DbSet<User> Users { get; set; }

        //public DbSet<Person> People { get; set; }
        //public DbSet<ExperiencePeople> ExperiencePeople { get; set; }

        public GummiDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Startup.ConnectionString);
        }

        public GummiDbContext(DbContextOptions<GummiDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
