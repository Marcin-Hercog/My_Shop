using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public class Delete
    {
        public static void DeleteUser()
        {
            Console.WriteLine("Which one do you want to delete? Please type ID: ");
            try
            {
                var userDelete = new User() { Id = int.Parse(Console.ReadLine()) };
                var delete = new Context();
                delete.Attach<User>(userDelete);
                delete.Remove(userDelete);
                delete.SaveChanges();
            }
            catch (System.FormatException)
            {

                Console.WriteLine("Wrong format of data! Please type number");
                DeleteUser();
            }
            catch(Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
            {
                Console.WriteLine("Sorry there isn't any ID which you type. Try again.");
                DeleteUser();
            }
        }
        public static void DeleteProduct()
        {
            Console.WriteLine("Which one do you want to delete? Please type ID: ");
            try
            {
                var productDelete = new Product() { Id = int.Parse(Console.ReadLine()) };
                var delete = new Context();
                delete.Attach<Product>(productDelete);
                delete.Remove(productDelete);
                delete.SaveChanges();
            }
            catch (System.FormatException)
            {

                Console.WriteLine("Wrong format of data! Please type number");
                DeleteProduct();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
            {
                Console.WriteLine("Sorry there isn't any ID which you type. Try again.");
                DeleteProduct();
            }
        }
        public static void DeleteCategory()
        {
            Console.WriteLine("Which one do you want to delete? Please type ID: ");
            try
            {
                var categoryDelete = new Category() { Id = int.Parse(Console.ReadLine()) };
                var delete = new Context();
                delete.Attach<Category>(categoryDelete);
                delete.Remove(categoryDelete);
                delete.SaveChanges();
            }
            catch (System.FormatException)
            {

                Console.WriteLine("Wrong format of data! Please type number");
                DeleteCategory();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
            {
                Console.WriteLine("Sorry there isn't any ID which you type. Try again.");
                DeleteCategory();
            }
        }
        public static void DeleteAddress()
        {
            Console.WriteLine("Which one do you want to delete? Please type ID: ");
            try
            {
                var addressDelete = new Address() { Id = int.Parse(Console.ReadLine()) };
                var delete = new Context();
                delete.Attach<Address>(addressDelete);
                delete.Remove(addressDelete);
                delete.SaveChanges();
            }
            catch (System.FormatException)
            {

                Console.WriteLine("Wrong format of data! Please type number");
                DeleteAddress();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
            {
                Console.WriteLine("Sorry there isn't any ID which you type. Try again.");
                DeleteAddress();
            }
        }

    }
}
