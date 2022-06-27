using System;
using System.Collections.Generic;
using System.Linq;

namespace MyShop
{
    class Program
    {
        static void ShowUsers()
        {
            Console.WriteLine("ID Name Last Name Email");
            using (var result = new Context())
            {
                List<User> users = result.Users.ToList();
                foreach (User item in users)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.LastName} {item.Email}");
                }
            }
            return;
        }
        static void ShowProducts()
        {
            Console.WriteLine("ID   Name    Prize   UserID");
            using (var result = new Context())
            {
                List<Product> product = result.Products.ToList();
                foreach (Product item in product)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Prize}      {item.UserId}");
                }
            }
            return;
        }
        static void ShowCategories()
        {
            Console.WriteLine("ID Name");
            using (var result = new Context())
            {
                List<Category> categories = result.Categories.ToList();
                foreach (Category item in categories)
                {                   
                    Console.WriteLine($"{item.Id} {item.Name}");
                }
            }
            return;
        }
        static void ShowAddresses()
        {
            Console.WriteLine("ID Country City Street Postal Code");
            using (var result = new Context())
            {
                List<Address> addresses = result.Adresses.ToList();
                foreach (Address item in addresses)
                {
                    Console.WriteLine($"{item.Id} {item.Cntry} {item.City} {item.Street} {item.PostalCode}");
                }
            }
            return;
        }

        static void AddUsers()
        {
            
            User newUser = new User();
            Console.WriteLine("Type name:");
            newUser.Name = Console.ReadLine();
            Console.WriteLine("Type last name:");
            newUser.LastName = Console.ReadLine();
            Console.WriteLine("Type email:");
            newUser.Email = Console.ReadLine();

            using (var result = new Context())
            {
                result.Attach<User>(newUser);
                result.SaveChanges();
            }
            
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hi! This is app thus you can manage database.\n" +
                "Which catalogue do you want change? Please type one of below:\nUser, Product, Category or Address");

            string[] catalogue = { "User", "Product", "Category", "Address" };
            string[] actions = { "User", "Product", "Category", "Address" };
            string userChoice = Console.ReadLine();

            if (userChoice == "User")
            {
                Console.WriteLine("You're in catalogue User\nWhat do you want to do? Please type action below:\nAdd, Update, Delete, Show");
                string userAction = Console.ReadLine();
                if (userAction == "Show")
                {
                    ShowUsers();
                }
                else if (userAction == "Add")
                {                    
                    AddUsers();
                }
            }
            else if (userChoice == "Product")
            {
                Console.WriteLine("You're in catalogue Product\nWhat do you want to do? Please type option below:\nAdd, Update, Delete, Show");
                string userAction = Console.ReadLine();
                if (userAction == "Show")
                {                   
                    ShowProducts();
                }
            }
            else if (userChoice == "Category")
            {
                Console.WriteLine("You're in catalogue Category\nWhat do you want to do? Please type option below:\nAdd, Update, Delete, Show");
                string userAction = Console.ReadLine();
                if (userAction == "Show")
                {
                    ShowCategories();
                }
            }
            else if (userChoice == "Address")
            {
                Console.WriteLine("You're in catalogue Address\nWhat do you want to do? Please type option below:\nAdd, Update, Delete, Show");
                string userAction = Console.ReadLine();
                if (userAction == "Show")
                {
                    ShowAddresses();
                }
            }
            else
            {
                Console.WriteLine("Sorry, incorret catalogue");
            }


            Console.ReadKey();


        }
    }
}
