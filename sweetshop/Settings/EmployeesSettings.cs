using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweetshop
{
    class EmployeesSettings
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Birth { get; set; }

        public string Post { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }


        public EmployeesSettings(string name, string surname, string birth, string post, string phone, string address)
        {
            Name = name;
            Surname = surname;
            Birth = birth;
            Post = post;
            Phone = phone;
            Address = address;
        }
    }
}
