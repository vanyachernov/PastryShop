using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweetshop
{
    class Client
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public Client(string name, string surname, string phone, string address)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Address = address;
        }
    }
}
