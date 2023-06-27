using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweetshop
{
    class SuppliersSettings
    {
        public string supName { get; set; }

        public string address { get; set; }

        public string phone { get; set; }

        public static string supID { get; set; }

        public SuppliersSettings(string supName, string address, string phone)
        {
            this.supName = supName;
            this.address = address;
            this.phone = phone;
        }
    }
}
