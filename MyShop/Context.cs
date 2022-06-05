using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    //this class represents all database
    //add tables(classes) in database
    class Context : DbContext
    {
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        //our connection to local db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)" +
                "\\mssqllocaldb;Datebase=EFUDemyDB;Trusted_Connection=True;");
        }

        //using Fluent API here
        //instead of Data Annotiation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(eb =>
            {
                //With EntityTypeBuilder i can configurate properties of the Adress class
                eb.Property(adress => adress.Cntry).IsRequired().HasColumnName("Country");
                eb.Property(adress => adress.Street).IsRequired();
                eb.Property(adress => adress.City).IsRequired();
                eb.Property(adress => adress.PostalCode).IsRequired();
            });

            modelBuilder.Entity<User>(eb =>
            {
                eb.Property(u => u.Name).IsRequired();
                eb.Property(u => u.LastName).IsRequired();
                eb.Property(u => u.Email).IsRequired();
            });

            modelBuilder.Entity<Product>(eb =>
            {
                eb.Property(p => p.Name).IsRequired();
                eb.Property(p => p.Prize).IsRequired();
            });
        }
    }
}
