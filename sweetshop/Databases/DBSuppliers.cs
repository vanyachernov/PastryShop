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
    class DBSuppliers
    {
        public bool checkerSupplies = false;

        public static void addSupplier(SuppliersSettings std)
        {
            string query = "INSERT INTO supplier(sup_name, sup_address, sup_phone) VALUES (@supName, @supAddress, @supPhone)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@supName", MySqlDbType.VarChar).Value = std.supName;
            command.Parameters.Add("@supAddress", MySqlDbType.VarChar).Value = std.address;
            command.Parameters.Add("@supPhone", MySqlDbType.VarChar).Value = std.phone;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Новий постачальник успішно доданий!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при додаванні постачальника! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void deleteSupplier(string id)
        {
            string query = "DELETE FROM supplier WHERE id_sup = @supID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@supID", MySqlDbType.VarChar).Value = id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Постачальник успішно видалений!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при видаленні постачальника! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
        
        public static void updateSupplier(SuppliersSettings std)
        {
            string query = "UPDATE supplier SET sup_name = @supName, sup_address = @supAddress, sup_phone = @supPhone WHERE id_sup = @supID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@supID", MySqlDbType.VarChar).Value = SuppliersSettings.supID;
            command.Parameters.Add("@supName", MySqlDbType.VarChar).Value = std.supName;
            command.Parameters.Add("@supAddress", MySqlDbType.VarChar).Value = std.address;
            command.Parameters.Add("@supPhone", MySqlDbType.VarChar).Value = std.phone;
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

        public static void display(DataGridView dgv, DataSet ds, MySqlDataAdapter usersTable)
        {
            string query = "SELECT id_sup, sup_name, sup_address, sup_phone FROM supplier";
            MySqlConnection connection = ConnectToDatabase.GetConnection();

            MySqlCommand command = new MySqlCommand(query, connection);
            usersTable.SelectCommand = command;
            usersTable.Fill(ds, "suppliers");

            dgv.DataSource = ds.Tables["suppliers"];
        }

        public static void getSupInfo(SuppliersSettings std, DataGridView dgv)
        {
            SuppliersSettings.supID = dgv.CurrentRow.Cells[0].Value.ToString();
            std.supName = dgv.CurrentRow.Cells[1].Value.ToString();
            std.address = dgv.CurrentRow.Cells[2].Value.ToString();
            std.phone = dgv.CurrentRow.Cells[3].Value.ToString();
        }

        public void checkFirmExistsInSup(SuppliersSettings std)
        {
            string query = "SELECT sup_id FROM supplies WHERE (SELECT id_sup FROM supplier WHERE sup_name = @supName) IN (sup_id) LIMIT 1";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@supName", MySqlDbType.VarChar).Value = std.supName;
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    checkerSupplies = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Сталася помилка! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
    }
}
