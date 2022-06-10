using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    class ProductUser
    {
        public User User { get; set; }
        public int UserID { get; set; }
        public Product Product  { get; set; }
        public int ProductID { get; set; }
        
    }
}
