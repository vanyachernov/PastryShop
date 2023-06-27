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
    class DBFirms
    {
        public bool checkerList = false;
        public bool checkerConf = false;

        public static void makeFirm(FirmsSettings std)
        {
            string query = "INSERT INTO firms VALUES (NULL, @firmName, @firmCity)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@firmName", MySqlDbType.VarChar).Value = std.firmName;
            command.Parameters.Add("@firmCity", MySqlDbType.VarChar).Value = std.firmCity;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Фірму успішно додано!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка під час додавання фірми! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void updateFirm(FirmsSettings std, string id)
        {
            string query = "UPDATE firms SET firm_name = @firmName, firm_city = @firmCity WHERE id_firm = @firmID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@firmID", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@firmName", MySqlDbType.VarChar).Value = std.firmName;
            command.Parameters.Add("@firmCity", MySqlDbType.VarChar).Value = std.firmCity;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Інформацію про фірму оновлено!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка під час оновлення фірми! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void deleteFirm(string id)
        {
            string query = "DELETE FROM firms WHERE id_firm = @firmID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@firmID", MySqlDbType.VarChar).Value = id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Фірма видалена!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при видаленні фірми! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void display(DataGridView dgv, DataSet ds, MySqlDataAdapter usersTable)
        {
            string query = "SELECT id_firm, firm_name, firm_city FROM firms";
            MySqlConnection connection = ConnectToDatabase.GetConnection();

            MySqlCommand command = new MySqlCommand(query, connection);
            usersTable.SelectCommand = command;
            usersTable.Fill(ds, "firms");

            dgv.DataSource = ds.Tables["firms"];
        }

        public void checkFirmExistsInList(FirmsSettings std)
        {
            string query = "SELECT id_firm FROM firms WHERE @firmName IN (firm_name)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@firmName", MySqlDbType.VarChar).Value = std.firmName;
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    checkerList = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Сталася помилка! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public void checkFirmExistsInConf(FirmsSettings std)
        {
            string query = "SELECT id_firm FROM firms JOIN confectionery conf ON firms.id_firm = conf.con_firm WHERE (SELECT id_firm FROM firms WHERE firm_name = @firmName) IN (conf.con_firm)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@firmName", MySqlDbType.VarChar).Value = std.firmName;
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    checkerConf = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Сталася помилка! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void getFirmInfo(FirmsSettings std, DataGridView dgv)
        {
            std.firmName = dgv.CurrentRow.Cells[1].Value.ToString();
            std.firmCity = dgv.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
