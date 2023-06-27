using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sweetshop
{
    class ConnectToDatabase
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=10072001v;database=littleshop";
            MySqlConnection connection = new MySqlConnection(sql);
            try
            {
                connection.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка з'єднання! \n\n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }
    }
}
