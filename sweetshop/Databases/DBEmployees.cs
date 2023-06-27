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
    class DBEmployees
    {
        public bool checkerUserExists = false;

        public static void addEmployee(EmployeesSettings std)
        {
            string query = "INSERT INTO employees VALUES (NULL, @EmplSurname, @EmplName, @EmplPost, @EmplAddress, @EmplPhone, @EmplBirthDate)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@EmplSurname", MySqlDbType.VarChar).Value = std.Surname;
            command.Parameters.Add("@EmplName", MySqlDbType.VarChar).Value = std.Name;
            command.Parameters.Add("@EmplPost", MySqlDbType.VarChar).Value = std.Post;
            command.Parameters.Add("@EmplAddress", MySqlDbType.VarChar).Value = std.Address;
            command.Parameters.Add("@EmplPhone", MySqlDbType.VarChar).Value = std.Phone;
            command.Parameters.Add("@EmplBirthDate", MySqlDbType.String).Value = std.Birth;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Працівник успішно доданий!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при додаванні! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        public static void updateEmployee(EmployeesSettings std, string id)
        {
            string query = "UPDATE employees SET e_lname = @EmplSurname, e_fname = @EmplName, e_post = @EmplPost, e_address = @EmplAddress, e_phone = @EmplPhone, date_of_birth = @EmplBirthDate WHERE id_em = @EmplID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@EmplID", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@EmplSurname", MySqlDbType.VarChar).Value = std.Surname;
            command.Parameters.Add("@EmplName", MySqlDbType.VarChar).Value = std.Name;
            command.Parameters.Add("@EmplPost", MySqlDbType.VarChar).Value = std.Post;
            command.Parameters.Add("@EmplAddress", MySqlDbType.VarChar).Value = std.Address;
            command.Parameters.Add("@EmplPhone", MySqlDbType.VarChar).Value = std.Phone;
            command.Parameters.Add("@EmplBirthDate", MySqlDbType.VarChar).Value = std.Birth;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Запис оновлено!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка під час оновлення! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        public static void deleteEmployee(string id)
        {
            string query = "DELETE FROM employees WHERE id_em = @EmplID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@EmplID", MySqlDbType.VarChar).Value = id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Запис видалено!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при видаленні! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        public void checkEmplExistsInUsers(EmployeesSettings std)
        {
            string query = "SELECT u_name FROM users WHERE (SELECT id_em FROM employees WHERE e_lname = @emLName AND e_fname = @emFName) IN (u_name) LIMIT 1";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@emLName", MySqlDbType.VarChar).Value = std.Surname;
            command.Parameters.Add("@emFName", MySqlDbType.VarChar).Value = std.Name;
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    checkerUserExists = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Сталася помилка! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
