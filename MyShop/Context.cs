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
    }
}
