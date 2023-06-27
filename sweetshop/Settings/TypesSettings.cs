using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweetshop
{
    class TypesSettings
    {
        public string productType { get; set; }

        public string productRep { get; set; }

        public TypesSettings(string productType, string productRep)
        {
            this.productType = productType;
            this.productRep = productRep;
        }
    }
}
