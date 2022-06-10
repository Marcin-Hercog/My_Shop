using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Prize { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public List<ProductUser> ProductUsers { get; set; } = new List<ProductUser>();
    }
}
