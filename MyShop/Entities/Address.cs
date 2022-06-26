using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public class Address
    {
        public int Id { get; set; }
        public string Cntry { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }

        //this will be relation one to one
        //I have to create reference to User and in class User create reference to Address
        //and configurate api in Context
        public User User { get; set; }
        //this will be foreign key
        //type of this key have to be like ID in class User
        public int UserID { get; set; }
    }
}
