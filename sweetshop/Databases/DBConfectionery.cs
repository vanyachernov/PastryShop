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
    class DBConfectionery
    {
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

        public static void addProduct(ConfSettings std)
        {
            string query = "INSERT INTO confectionery VALUES (NULL, @ProductName, @ProductWeight, @ProductPrice, @ProductDescribe, (SELECT id_firm FROM firms WHERE firm_name = @ProductFirm), (SELECT id_typecon FROM con_types WHERE type_name = @ProductType), 0)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@ProductName", MySqlDbType.VarChar).Value = std.productName;
            command.Parameters.Add("@ProductWeight", MySqlDbType.VarChar).Value = std.productWeight;
            command.Parameters.Add("@ProductPrice", MySqlDbType.VarChar).Value = std.productPrice;
            command.Parameters.Add("@ProductDescribe", MySqlDbType.VarChar).Value = std.productDescribe;
            command.Parameters.Add("@ProductFirm", MySqlDbType.VarChar).Value = std.productFirm;
            command.Parameters.Add("@ProductType", MySqlDbType.VarChar).Value = std.productCategory;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Продукт успішно доданий!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при додаванні! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void updateProduct(ConfSettings std, string id)
        {
            string query = "UPDATE confectionery SET con_name = @ProductName, con_weight = @ProductWeight, con_price = @ProductPrice, con_describe = @ProductDescribe, con_firm = (SELECT id_firm FROM firms WHERE firm_name = @ProductFirm), type_con = (SELECT id_typecon FROM con_types WHERE type_name = @ProductType) WHERE id_con = @productID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@productID", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@ProductName", MySqlDbType.VarChar).Value = std.productName;
            command.Parameters.Add("@ProductWeight", MySqlDbType.VarChar).Value = std.productWeight;
            command.Parameters.Add("@ProductPrice", MySqlDbType.VarChar).Value = std.productPrice;
            command.Parameters.Add("@ProductDescribe", MySqlDbType.VarChar).Value = std.productDescribe;
            command.Parameters.Add("@ProductFirm", MySqlDbType.VarChar).Value = std.productFirm;
            command.Parameters.Add("@ProductType", MySqlDbType.VarChar).Value = std.productCategory;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Продукт успішно оновлено!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка під час оновлення! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void deleteProduct(string id)
        {
            string query = "DELETE FROM confectionery WHERE id_con = @productID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@productID", MySqlDbType.VarChar).Value = id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Продукт успішно видалено!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при видаленні! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void getProductType(ComboBox cmb)
        {
            string query = "SELECT id_typecon, type_name FROM con_types";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable firms = new DataTable();
            adapter.Fill(firms);
            cmb.DisplayMember = firms.Columns[1].ToString();
            cmb.ValueMember = firms.Columns[0].ToString(); ;
            cmb.DataSource = firms;
            connection.Close();
        }

        public static void getProductFirm(ComboBox cmb)
        {
            string query = "SELECT id_firm, firm_name FROM firms";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable firms = new DataTable();
            adapter.Fill(firms);
            cmb.DisplayMember = firms.Columns[1].ToString();
            cmb.ValueMember = firms.Columns[0].ToString(); ;
            cmb.DataSource = firms;
            connection.Close();
        }

        public static void getPriceValues(Prices std, DataGridView dgv)
        {
            string query = "SELECT conf.id_con as '#', conf.con_name as 'Назва', typecon.type_name as 'Категорія', conf.con_describe as 'Опис', conf.con_weight as 'Вага', conf.con_price as 'Ціна', fm.firm_name as 'Фірма-виробник' FROM ((confectionery conf JOIN con_types typecon ON conf.type_con = typecon.id_typecon) JOIN firms fm ON conf.con_firm = fm.id_firm) WHERE conf.con_price BETWEEN @MinValue AND @MaxValue";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@MinValue", MySqlDbType.Decimal).Value = std.MinValue;
            command.Parameters.Add("@MaxValue", MySqlDbType.Decimal).Value = std.MaxValue;
            adapter.Fill(table);
            dgv.DataSource = table;
            connection.Close();
        }

        public static void getProductInfo(txtCurrentInfo std, DataGridView dgv)
        {
            std.nameProduct = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            std.describeProduct = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
        }
    }
}
