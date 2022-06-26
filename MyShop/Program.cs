using System;
using System.Collections.Generic;
using System.Linq;

namespace MyShop
{
    class Program
    {   
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
            }
            else if (userChoice == "Product")
            {
                Console.WriteLine("You're in catalogue Product\nWhat do you want to do? Please type option below:\nAdd, Update, Delete, Show");
            }
            else if (userChoice == "Category")
            {
                Console.WriteLine("You're in catalogue Category\nWhat do you want to do? Please type option below:\nAdd, Update, Delete, Show");
            }
            else if (userChoice == "Address")
            {
                Console.WriteLine("You're in catalogue Address\nWhat do you want to do? Please type option below:\nAdd, Update, Delete, Show");
            }
            else
            {
                Console.WriteLine("Sorry, incorret catalogue");
            }


            Console.ReadKey();


        }
    }
}
