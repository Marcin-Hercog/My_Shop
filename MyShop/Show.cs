using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    class Show
    {
        public static void ShowUsers()
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
        public static void ShowProducts()
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
        public static void ShowCategories()
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
        public static void ShowAddresses()
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
    }
}
