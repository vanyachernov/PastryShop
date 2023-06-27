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
    class DBProdTypes
    {
        public bool checkerList = false;
        public bool checkerConf = false;

        public static void makeType(TypesSettings std)
        {
            string query = "INSERT INTO con_types VALUES (NULL, @typeName)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@typeName", MySqlDbType.VarChar).Value = std.productType;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Категорію успішно додано!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка під час додавання категорії! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void updateType(TypesSettings std, string id)
        {
            string query = "UPDATE con_types SET type_name = @typeName WHERE id_typecon = @typeID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@typeName", MySqlDbType.VarChar).Value = std.productType;
            command.Parameters.Add("@typeID", MySqlDbType.VarChar).Value = id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Категорію оновлено!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка під час оновлення категорії! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void deleteType(string id)
        {
            string query = "DELETE FROM con_types WHERE id_typecon = @typeID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@typeID", MySqlDbType.VarChar).Value = id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Тип продукту видалений!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при видаленні типу продукту! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void display(DataGridView dgv, DataSet ds, MySqlDataAdapter usersTable)
        {
            string query = "SELECT id_typecon, type_name FROM con_types";
            MySqlConnection connection = ConnectToDatabase.GetConnection();

            MySqlCommand command = new MySqlCommand(query, connection);
            usersTable.SelectCommand = command;
            usersTable.Fill(ds, "types");

            dgv.DataSource = ds.Tables["types"];
        }

        public void checkTypeExists(TypesSettings std)
        {
            string query = "SELECT id_typecon FROM con_types WHERE @typeName IN (type_name)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@typeName", MySqlDbType.VarChar).Value = std.productType;
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

        public void checkFirmExistsInConf(TypesSettings std)
        {
            string query = "SELECT id_typecon FROM con_types ctypes JOIN confectionery conf ON ctypes.id_typecon = conf.type_con WHERE (SELECT id_typecon FROM con_types WHERE type_name = @typeName) IN (conf.type_con)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@typeName", MySqlDbType.VarChar).Value = std.productType;
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

        public static void getTypeInfo(TypesSettings std, DataGridView dgv)
        {
            std.productType = dgv.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
