using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweetshop
{
    class ConfSettings
    {
        public string productName { get; set; }

        public string productCategory { get; set; }

        public string productDescribe { get; set; }

        public string productWeight { get; set; }

        public string productFirm { get; set; }

        public string productPrice { get; set; }

        public ConfSettings(string productName, string productCategory, string productDescribe, string productWeight, string productFirm, string productPrice)
        {
            this.productName = productName;
            this.productCategory = productCategory;
            this.productDescribe = productDescribe;
            this.productWeight = productWeight;
            this.productFirm = productFirm;
            this.productPrice = productPrice;
        }
    }
}
