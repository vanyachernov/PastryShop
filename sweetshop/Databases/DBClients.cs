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
    class DBClients
    {
        public static void addClient(Client std)
        {
            string query = "INSERT INTO clients VALUES (NULL, @ClientSurname, @ClientName, @ClientPhone, @ClientAddress)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@ClientSurname", MySqlDbType.VarChar).Value = std.Surname;
            command.Parameters.Add("@ClientName", MySqlDbType.VarChar).Value = std.Name;
            command.Parameters.Add("@ClientPhone", MySqlDbType.VarChar).Value = std.Phone;
            command.Parameters.Add("@ClientAddress", MySqlDbType.VarChar).Value = std.Address;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Клієнт успішно доданий!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при додаванні! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void updateClient(Client std, string id)
        {
            string query = "UPDATE clients SET cl_fname = @ClientName, cl_lname = @ClientSurname, cl_phone = @ClientPhone, cl_address = @ClientAddress WHERE id_cl = @ClientID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@ClientID", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@ClientSurname", MySqlDbType.VarChar).Value = std.Surname;
            command.Parameters.Add("@ClientName", MySqlDbType.VarChar).Value = std.Name;
            command.Parameters.Add("@ClientPhone", MySqlDbType.VarChar).Value = std.Phone;
            command.Parameters.Add("@ClientAddress", MySqlDbType.VarChar).Value = std.Address;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Запис оновлено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка під час оновлення! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void deleteClient(string id)
        {
            string query = "DELETE FROM clients WHERE id_cl = @ClientID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@ClientID", MySqlDbType.VarChar).Value = id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Запис видалено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при видаленні! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void displayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
            connection.Close();
        }
    }
}
