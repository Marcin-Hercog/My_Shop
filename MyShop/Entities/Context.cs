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
        public DbSet<ProductUser> ProductUsers { get; set; }

        //our connection to local db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)" +
                "\\mssqllocaldb;Database=MyShopDB;Trusted_Connection=True;");
        }

        //using Fluent API here
        //instead of Data Annotiation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(eb =>
            {
                //With EntityTypeBuilder i can configurate properties of the class Address
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
                //HasOne - class User has one reference to class Address
                eb.HasOne(u => u.Address)
                //WithOne - class Adress has one reference to class User
                .WithOne(a => a.User)
                //set primary key to UserId in class Address
                .HasForeignKey<Address>(a => a.UserID);
            });
            
            modelBuilder.Entity<Product>(eb =>
            {
                eb.Property(p => p.Name).IsRequired();
                eb.Property(p => p.Prize).IsRequired();
                //eb.HasMany(p => p.Users).WithMany(u => u.Products);
            });
            
            //configurate relation one to many
            modelBuilder.Entity<Category>(eb =>
            {
                //category has many rerferences to products
                eb.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
            });

            //MODEL DATA SEED
            //the best use when we want put static data
            //this is data which appear from beginning
            modelBuilder.Entity<User>()
                .HasData(new User { Id = 1, Name = "Marcin", LastName = "Kowalski", Email = "someemail1@gmail.com" },
                new User { Id = 2, Name = "Anna", LastName = "Nowak", Email = "someemail2@gmail.com" },
                new User { Id = 3, Name = "Tomasz", LastName = "Wybicki", Email = "someemail3@gmail.com" },
                new User { Id = 4, Name = "Marek", LastName = "Nadgórski", Email = "someemail4@gmail.com" });

            modelBuilder.Entity<Address>()
                .HasData(new Address { Id = 1, Cntry = "Poland", City = "Katowice", Street = "Długa", PostalCode = "40-800", UserID = 1 },
                new Address { Id = 2, Cntry = "Poland", City = "Chorzów", Street = "Krótka", PostalCode = "42-900", UserID = 2 },
                new Address { Id = 3, Cntry = "Poland", City = "Siemianowice Śląskie", Street = "Szeroka", PostalCode = "43-900", UserID = 3 },
                new Address { Id = 4, Cntry = "Poland", City = "Katowice", Street = "Wąska", PostalCode = "44-880", UserID = 4 });


            //modelBuilder.Entity<ProductUser>()
            //primary (compound) key
            //.HasKey(pu => new { pu.UserId, pu.ProductId });



        }
    }
}
