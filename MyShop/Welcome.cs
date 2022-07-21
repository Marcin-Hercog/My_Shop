using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public class Welcome
    {
        public void UserWelcome()
        {
            Console.WriteLine("Hi! This is an app with which you can manage the database.\n" +
                "Which catalogue do you want to choose? Please type one of given below:\nUser, Product, Category or Address");
            
            string userChoice = Console.ReadLine();

            if (userChoice == "User")
            {
                Console.WriteLine("You're in catalogue User\nWhat do you want to do? " +
                    "Please type action below:\nAdd, Update, Delete, Show or Back");
                string userAction = Console.ReadLine();
                if (userAction == "Show")
                {
                    Show.ShowUsers();
                    Return.ReturnToMainMenu();
                }
                else if (userAction == "Add")
                {
                    Add.AddUsers();
                    Return.ReturnToMainMenu();
                }
                else if (userAction == "Back")
                {
                    Return.ReturnToMainMenu();
                }
                else if (userAction == "Delete")
                {
                    Show.ShowUsers();
                    Delete.DeleteUser();
                    Show.ShowUsers();
                    Return.ReturnToMainMenu();
                }
                else
                {
                    Console.WriteLine("You typed a wrong command.");
                    Return.ReturnToMainMenu();
                }
            }
            else if (userChoice == "Product")
            {
                Console.WriteLine("You're in catalogue Product\nWhat do you want to do? " +
                    "Please type action below:\nDelete, Show or Back");
                string userAction = Console.ReadLine();
                if (userAction == "Show")
                {
                    Show.ShowProducts();
                    Return.ReturnToMainMenu();
                }
                else if (userAction == "Back")
                {
                    Return.ReturnToMainMenu();
                }
                else if (userAction == "Delete")
                {
                    Show.ShowProducts();
                    Delete.DeleteProduct();
                    Show.ShowProducts();
                    Return.ReturnToMainMenu();
                }
                else
                {
                    Console.WriteLine("You typed a wrong command.");
                    Return.ReturnToMainMenu();
                }
            }
            else if (userChoice == "Category")
            {
                Console.WriteLine("You're in catalogue Category\nWhat do you want to do? " +
                    "Please type action below:\nAdd, Delete, Show or Back");
                string userAction = Console.ReadLine();
                if (userAction == "Show")
                {
                    Show.ShowCategories();
                    Return.ReturnToMainMenu();
                }
                else if (userAction == "Add")
                {
                    Add.AddCategories();
                    Return.ReturnToMainMenu();
                }
                else if (userAction == "Back")
                {
                    Return.ReturnToMainMenu(); ;
                }
                else if (userAction == "Delete")
                {
                    Show.ShowCategories();
                    Delete.DeleteCategory();
                    Show.ShowCategories();
                    Return.ReturnToMainMenu(); ;
                }
                else
                {
                    Console.WriteLine("You typed a wrong command.");
                    Return.ReturnToMainMenu();
                }
            }
            else if (userChoice == "Address")
            {
                Console.WriteLine("You're in catalogue Address\nWhat do you want to do? " +
                    "Please type action below:\nDelete, Show or Back");
                string userAction = Console.ReadLine();
                if (userAction == "Show")
                {
                    Show.ShowAddresses();
                    Return.ReturnToMainMenu();
                }                
                else if (userAction == "Back")
                {
                    Return.ReturnToMainMenu();
                }
                else if (userAction == "Delete")
                {
                    Show.ShowAddresses();
                    Delete.DeleteAddress();
                    Show.ShowAddresses();
                    Return.ReturnToMainMenu();
                }
                else
                {
                    Console.WriteLine("You typed a wrong command.");
                    Return.ReturnToMainMenu();
                }
            }
            else
            {
                Console.WriteLine("Sorry, incorret catalogue");
                Return.ReturnToMainMenu();
            }
        }
    }
}
