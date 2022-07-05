using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public class Welcome
    {
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
        static void AddCategories()
        {
            Category newCategory = new Category();
            Console.WriteLine("Type name of category:");
            newCategory.Name = Console.ReadLine();

            using (var result = new Context())
            {
                result.Attach<Category>(newCategory);
                result.SaveChanges();
            }
            Show.ShowCategories();
        }
        public static void Return()
        {
            Welcome welcome = new Welcome();
            welcome.UserWelcome();
        }
        public void UserWelcome()
        {
            Console.WriteLine("Hi! This is app thus you can manage database.\n" +
                "Which catalogue do you want change? Please type one of below:\nUser, Product, Category or Address");

            string[] catalogue = { "User", "Product", "Category", "Address" };
            string[] actions = { "User", "Product", "Category", "Address" };
            string userChoice = Console.ReadLine();

            

            if (userChoice == "User")
            {
                Console.WriteLine("You're in catalogue User\nWhat do you want to do? " +
                    "Please type action below:\nAdd, Update, Delete, Show or Back");
                string userAction = Console.ReadLine();
                if (userAction == "Show")
                {
                    Show.ShowUsers();
                }
                else if (userAction == "Add")
                {
                    AddUsers();
                }
                else if (userAction == "Back")
                {
                    Return();
                }
                else
                {
                    Console.WriteLine("You typed wrong data command. Please type action below:\nAdd, Update, Delete, Show or Back");
                    string chooseAgain = Console.ReadLine();
                }
            }
            else if (userChoice == "Product")
            {
                Console.WriteLine("You're in catalogue Product\nWhat do you want to do? " +
                    "Please type option below:\nAdd, Update, Delete, Show or Back");
                string userAction = Console.ReadLine();
                if (userAction == "Show")
                {
                    Show.ShowProducts();
                }
                else if (userAction == "Add")
                {

                    //AddProducts();
                }
                else if (userAction == "Back")
                {
                    Return();
                }

            }
            else if (userChoice == "Category")
            {
                Console.WriteLine("You're in catalogue Category\nWhat do you want to do? " +
                    "Please type option below:\nAdd, Update, Delete, Show or Back");
                string userAction = Console.ReadLine();
                if (userAction == "Show")
                {
                    Show.ShowCategories();
                }
                else if (userAction == "Add")
                {
                    AddCategories();
                }
                else if (userAction == "Back")
                {
                    Return();
                }
            }
            else if (userChoice == "Address")
            {
                Console.WriteLine("You're in catalogue Address\nWhat do you want to do? " +
                    "Please type option below:\nAdd, Update, Delete, Show or Back");
                string userAction = Console.ReadLine();
                if (userAction == "Show")
                {
                    Show.ShowAddresses();
                }
                else if (userAction == "Add")
                {
                    //AddAddresses();
                }
                else if (userAction == "Back")
                {
                    Return();
                }
            }
            else
            {
                Console.WriteLine("Sorry, incorret catalogue");
                Return();
            }
        }
    }
}
