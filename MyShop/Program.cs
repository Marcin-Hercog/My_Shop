using System;
using System.Collections.Generic;
using System.Linq;

namespace MyShop
{
    class Program
    {    
        static void Main(string[] args)
        {           
            Welcome welcome = new Welcome();
            welcome.UserWelcome();

            Console.ReadKey();


        }
    }
}
