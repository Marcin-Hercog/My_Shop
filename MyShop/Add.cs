using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public class Add
    {
        //create addproduct and add address
        public static void AddUsers()
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
        public static void AddCategories()
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
    }
}
