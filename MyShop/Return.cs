﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public class Return
    {
        public static void ReturnToMainMenu()
        {
            Welcome welcome = new Welcome();
            welcome.UserWelcome();
        }
    }
}
