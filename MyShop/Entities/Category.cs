using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
     public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //relation one to many, one Category to many Product
        
        public List<Product> Products { get; set; }
            //create empty list of products instead of null values
            //usefull when we want concern to list of products for any catregory
            //for e.g. to add new product or take already existing
            = new List<Product>();
        
    }
}
