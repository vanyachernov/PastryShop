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
    class DBUsers
    {
        public bool checker = false;

        public static void addUser(UsersSettings std)
        {
            string query = "INSERT INTO users(u_login, u_name, u_pass, u_mode) VALUES (@userLogin, @userID, @userPassword, @userMode)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = std.Login;
            command.Parameters.Add("@userID", MySqlDbType.VarChar).Value = std.userID;
            command.Parameters.Add("@userPassword", MySqlDbType.VarChar).Value = std.Password;
            command.Parameters.Add("@userMode", MySqlDbType.VarChar).Value = std.Mode;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Новий користувач успішно доданий!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при створені користувача! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void deleteUser(UsersSettings std)
        {
            string query = "DELETE FROM users WHERE u_name = @userID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@userID", MySqlDbType.VarChar).Value = std.userID;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Користувач був вилучений!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при видаленні користувача! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void updateUser(UsersSettings std)
        {
            string query = "UPDATE users SET u_login = @userLogin, u_pass = @userPass, u_mode = @userMode WHERE u_name = @id";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = std.userID;
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = std.Login;
            command.Parameters.Add("@userPass", MySqlDbType.VarChar).Value = std.Password;
            command.Parameters.Add("@userMode", MySqlDbType.VarChar).Value = std.Mode;
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

        public void checkerUserExist(UsersSettings subStd)
        {
            string query = "SELECT em.e_lname FROM employees em JOIN users u ON em.id_em = u.u_name WHERE @userSurname IN (em.e_lname)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@userSurname", MySqlDbType.VarChar).Value = subStd.Surname;
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    checker = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при створені користувача! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void getUserID(UsersSettings std)
        {
            string query = "SELECT id_em FROM employees WHERE e_lname = @userSurname";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@userSurname", MySqlDbType.VarChar).Value = std.Surname;
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    std.userID = Convert.ToInt32(reader.GetString(0));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при зчитуванні! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void getUserInfo(UsersSettings std, DataGridView dgv)
        {
            std.Surname = dgv.CurrentRow.Cells[0].Value.ToString();
            std.Login = dgv.CurrentRow.Cells[2].Value.ToString();
            std.Password = dgv.CurrentRow.Cells[3].Value.ToString();
            std.Mode = dgv.CurrentRow.Cells[4].Value.ToString();
        }

        public static void display(DataGridView dgv, DataSet ds, MySqlDataAdapter usersTable)
        {
            string query = "SELECT em.e_lname, em.e_fname, u_login, u_pass, u_mode FROM employees em JOIN users u ON u.u_name = em.id_em";
            MySqlConnection connection = ConnectToDatabase.GetConnection();

            MySqlCommand command = new MySqlCommand(query, connection);
            usersTable.SelectCommand = command;
            usersTable.Fill(ds, "users");

            dgv.DataSource = ds.Tables["users"];
        }

        public static void getEmplBoxInfo(ComboBox cmb)
        {
            string query = "SELECT e_lname FROM employees";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string sColumn = reader.GetString(0);
                cmb.Items.Add(sColumn);
            }
        }
    }
}
