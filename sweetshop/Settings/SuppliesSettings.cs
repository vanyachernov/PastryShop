using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweetshop
{
    class SuppliesSettings
    {
        public string supplierName { get; set; }

        public string productName { get; set; }

        public string productQuantity { get; set; }

        public static string supPhone { get; set; }

        public SuppliesSettings(string supplierName, string productName, string productQuantity)
        {
            this.supplierName = supplierName;
            this.productName = productName;
            this.productQuantity = productQuantity;
        }
    }
}
