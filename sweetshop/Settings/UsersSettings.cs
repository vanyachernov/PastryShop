using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweetshop
{
    class UsersSettings
    {
        public int userID { get; set; }

        public string Surname { get; set; }
        
        public string Login { get; set; }

        public string Password { get; set; }

        public string Mode { get; set; }

        public UsersSettings(string surname, string login, string password, string mode)
        {
            Surname = surname;
            Login = login;
            Password = password;
            Mode = mode;
        }
    }
}
