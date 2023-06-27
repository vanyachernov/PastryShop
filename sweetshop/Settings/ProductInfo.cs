using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweetshop
{
    class txtCurrentInfo
    {
        public string nameProduct { get; set; }
        public string describeProduct { get; set; }
        public txtCurrentInfo(string nameProduct, string describeProduct)
        {
            this.nameProduct = nameProduct;
            this.describeProduct = describeProduct;
        }
    }
}
