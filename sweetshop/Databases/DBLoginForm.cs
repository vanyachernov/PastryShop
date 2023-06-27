using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace sweetshop
{
    class DBLoginForm
    {
        public bool checker = false;

        public void LoginSys(string st1, string st2)
        {
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlConnection connectionTwo = ConnectToDatabase.GetConnection();

            string query = "SELECT * FROM users WHERE u_login = @userLogin AND u_pass = @userPassword";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = st1;
            command.Parameters.Add("@userPassword", MySqlDbType.VarChar).Value = st2;

            string result = $"SELECT e.e_lname, e.e_fname, u_mode FROM users u JOIN employees e ON u.u_name = e.id_em WHERE u_login = @userLogin";
            MySqlCommand showResult = new MySqlCommand(result, connectionTwo);
            showResult.CommandType = CommandType.Text;
            showResult.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = st1;

            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        MySqlDataReader resultReader = showResult.ExecuteReader();
                        while(resultReader.Read())
                        {
                            LoginSettings.userLastName = resultReader.GetString(0);
                            LoginSettings.userFirstName = resultReader.GetString(1);
                            LoginSettings.userMode = resultReader.GetString(2);
                        }
                        connectionTwo.Close();
                        checker = true;
                    }
                }
                else
                {
                    MessageBox.Show("Неправильний логін або пароль!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
