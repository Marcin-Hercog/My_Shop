using System;
using System.Collections.Generic;
using System.Linq;

namespace MyShop
{
    class Program
    {
        //static void ShowUsers()
        //{
        //    Console.WriteLine("ID Name Last Name Email");
        //    using (var result = new Context())
        //    {
        //        List<User> users = result.Users.ToList();
        //        foreach (User item in users)
        //        {
        //            Console.WriteLine($"{item.Id} {item.Name} {item.LastName} {item.Email}");
        //        }
        //    }
        //    return;
        //}
        //static void ShowProducts()
        //{
        //    Console.WriteLine("ID   Name    Prize   UserID");
        //    using (var result = new Context())
        //    {
        //        List<Product> product = result.Products.ToList();
        //        foreach (Product item in product)
        //        {
        //            Console.WriteLine($"{item.Id} {item.Name} {item.Prize}      {item.UserId}");
        //        }
        //    }
        //    return;
        //}
        //static void ShowCategories()
        //{
        //    Console.WriteLine("ID Name");
        //    using (var result = new Context())
        //    {
        //        List<Category> categories = result.Categories.ToList();
        //        foreach (Category item in categories)
        //        {                   
        //            Console.WriteLine($"{item.Id} {item.Name}");
        //        }
        //    }
        //    return;
        //}
        //static void ShowAddresses()
        //{
        //    Console.WriteLine("ID Country City Street Postal Code");
        //    using (var result = new Context())
        //    {
        //        List<Address> addresses = result.Adresses.ToList();
        //        foreach (Address item in addresses)
        //        {
        //            Console.WriteLine($"{item.Id} {item.Cntry} {item.City} {item.Street} {item.PostalCode}");
        //        }
        //    }
        //    return;
        //}

        //static void AddUsers()
        //{
            
        //    User newUser = new User();
        //    Console.WriteLine("Type name:");
        //    newUser.Name = Console.ReadLine();
        //    Console.WriteLine("Type last name:");
        //    newUser.LastName = Console.ReadLine();
        //    Console.WriteLine("Type email:");
        //    newUser.Email = Console.ReadLine();

        //    using (var result = new Context())
        //    {
        //        result.Attach<User>(newUser);
        //        result.SaveChanges();
        //    }
            
        //}
        //static void AddProducts()
        //{

        //    Product newProduct = new Product();
        //    Console.WriteLine("Type name of product:");
        //    newProduct.Name = Console.ReadLine();
        //    Console.WriteLine("Type prize:");           
        //    try
        //    {
        //        newProduct.Prize = int.Parse(Console.ReadLine());
        //    }
        //    catch (FormatException)
        //    {               
        //        Console.WriteLine("Wrong format of data! Type again:");
        //        newProduct.Prize = int.Parse(Console.ReadLine());
        //    }

        //    using (var result = new Context())
        //    {
        //        result.Attach<Product>(newProduct);
        //        result.SaveChanges();
        //    }
        //    Console.WriteLine("Do you want add ID of user? Type yes or no:");
        //    string userChoice = Console.ReadLine();
        //    if (userChoice == "yes")
        //    {
        //        Console.WriteLine("Type ID of user:");
        //        newProduct.UserId = byte.Parse(Console.ReadLine());
        //        ShowProducts();
        //    }
        //    else
        //    {
        //        ShowProducts();
        //    }
        //}
        //static void AddCategories()
        //{
        //    Category newCategory = new Category();
        //    Console.WriteLine("Type name of category:");
        //    newCategory.Name = Console.ReadLine();

        //    using (var result = new Context())
        //    {
        //        result.Attach<Category>(newCategory);
        //        result.SaveChanges();
        //    }
        //    Show.ShowCategories();
        //}

        //static void AddAddresses()
        //{
        //    Address newAddress = new Address();
        //    Console.WriteLine("Type country:");
        //    newAddress.Cntry = Console.ReadLine();
        //    Console.WriteLine("Type City:");
        //    newAddress.City = Console.ReadLine();
        //    Console.WriteLine("Type street:");
        //    newAddress.Street = Console.ReadLine();
        //    Console.WriteLine("Type postal code:");
        //    newAddress.PostalCode = Console.ReadLine();

        //    using (var result = new Context())
        //    {
        //        result.Attach<Address>(newAddress);
        //        try
        //        {
        //            result.SaveChanges();
        //        }
        //        catch (Microsoft.EntityFrameworkCore.DbUpdateException)
        //        {
        //            Console.WriteLine("You can't add new address becouse you have to" +
        //                " add user first ");
        //            AddUsers();
        //            AddAddresses();
        //            result.SaveChanges();
        //        }
                
        //    }
        //    ShowAddresses();
        //}
      
        static void Main(string[] args)
        {

            //Console.WriteLine("Hi! This is app thus you can manage database.\n" +
            //    "Which catalogue do you want change? Please type one of below:\nUser, Product, Category or Address");

            //string[] catalogue = { "User", "Product", "Category", "Address" };
            //string[] actions = { "User", "Product", "Category", "Address" };
            //string userChoice = Console.ReadLine();

            //while(userChoice != "User" || userChoice != "Product"
            //    || userChoice != "Category" || userChoice != "Address")
            //{
            //    Console.WriteLine("Wrong command! Try again");
            //}

            //if (userChoice == "User")
            //{
            //    Console.WriteLine("You're in catalogue User\nWhat do you want to do? Please type action below:\nAdd, Update, Delete, Show or Back");
            //    string userAction = Console.ReadLine();
            //    if (userAction == "Show")
            //    {
            //        Show.ShowUsers();
            //    }
            //    else if (userAction == "Add")
            //    {                    
            //        AddUsers();
            //    }
            //    else if (userAction == "Back")
            //    {
            //        Console.WriteLine("Which catalogue do you want change? Please type one of below:\nUser, Product, Category or Address");
            //    }
            //}
            //else if (userChoice == "Product")
            //{
            //    Console.WriteLine("You're in catalogue Product\nWhat do you want to do? Please type option below:\nAdd, Update, Delete, Show");
            //    string userAction = Console.ReadLine();
            //    if (userAction == "Show")
            //    {                   
            //        Show.ShowProducts();
            //    }
            //    else if (userAction == "Add")
            //    {

            //        //AddProducts();
            //    }

            //}
            //else if (userChoice == "Category")
            //{
            //    Console.WriteLine("You're in catalogue Category\nWhat do you want to do? Please type option below:\nAdd, Update, Delete, Show");
            //    string userAction = Console.ReadLine();
            //    if (userAction == "Show")
            //    {
            //        Show.ShowCategories();
            //    }
            //    else if (userAction == "Add")
            //    {
            //        AddCategories();
            //    }
            //}
            //else if (userChoice == "Address")
            //{
            //    Console.WriteLine("You're in catalogue Address\nWhat do you want to do? Please type option below:\nAdd, Update, Delete, Show");
            //    string userAction = Console.ReadLine();
            //    if (userAction == "Show")
            //    {
            //        Show.ShowAddresses();
            //    }
            //    else if(userAction == "Add")
            //    {
            //        //AddAddresses();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, incorret catalogue");
            //}
            Welcome welcome = new Welcome();
            welcome.UserWelcome();

            Console.ReadKey();


        }
    }
}
