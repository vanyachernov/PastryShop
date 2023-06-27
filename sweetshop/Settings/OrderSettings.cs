using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweetshop
{
    class OrderSettings
    {
        public string productName { get; set; }

        public string clientID { get; set; }

        public string productQuantity { get; set; }

        public string deliveryDate { get; set; }

        public static string employeeID { get; set; }

        public static string checkProductQuantity { get; set; }
        
        public OrderSettings(string productName, string productQuantity, string deliveryDate)
        {
            this.productName = productName;
            this.productQuantity = productQuantity;
            this.deliveryDate = deliveryDate;
        }
    }
}
