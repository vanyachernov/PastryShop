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
    class DBSupplies
    {
        public static void makeSupply(SuppliesSettings sup)
        {
            string query = "call makeSupplies((SELECT id_sup FROM supplier WHERE sup_name = @supplierName), (SELECT id_em FROM employees WHERE e_lname = @userLName AND e_fname = @userFName), (SELECT id_con FROM confectionery WHERE con_name = @productName), @productQuantity)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@supplierName", MySqlDbType.VarChar).Value = sup.supplierName;
            command.Parameters.Add("@userLName", MySqlDbType.VarChar).Value = LoginSettings.userLastName;
            command.Parameters.Add("@userFName", MySqlDbType.VarChar).Value = LoginSettings.userFirstName;
            command.Parameters.Add("@productName", MySqlDbType.VarChar).Value = sup.productName;
            command.Parameters.Add("@productQuantity", MySqlDbType.VarChar).Value = sup.productQuantity;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Нове постачання успішно створено!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при створені постачання! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void addToSupply(SuppliesSettings sup)
        {
            string query = "call addToSupplies((SELECT id_con FROM confectionery WHERE con_name = @productName), @productQuantity)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@productName", MySqlDbType.VarChar).Value = sup.productName;
            command.Parameters.Add("@productQuantity", MySqlDbType.VarChar).Value = sup.productQuantity;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Продукт успішно доданий!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при додаванні продукта! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void typePhone(string name)
        {
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            string query = "SELECT sup_phone FROM supplier WHERE sup_name = @supName";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@supName", MySqlDbType.VarChar).Value = name;
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SuppliesSettings.supPhone = reader.GetString(0);  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public static void display(DataGridView dgv1, DataSet ds, MySqlDataAdapter suppliesTable, MySqlDataAdapter supplies_list_table)
        {
            string query = "SELECT s.id_sup, sup.sup_name AS 'Постачальник', CONCAT(em.e_lname, ' ', em.e_fname) AS 'Працівник', s.date_of_delivery AS 'Дата постачання', (SELECT SUM(sl.num_of_prod * conf.con_price) FROM supplies supp JOIN supplies_list sl USING(id_sup) JOIN confectionery conf ON sl.con_id = conf.id_con WHERE supp.id_sup = s.id_sup) AS 'Підсумок' FROM(supplies s JOIN employees em ON s.em_id = em.id_em) JOIN supplier sup ON s.sup_id = sup.id_sup";
            string querySub = "SELECT s.id_sup AS 'Номер замовлення', con.con_name AS 'Назва продукту', num_of_prod AS 'Кількість продукту', con.con_price AS 'Ціна' FROM (supplies_list sl JOIN confectionery con ON sl.con_id = con.id_con) JOIN supplies s USING(id_sup)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();

            MySqlCommand command = new MySqlCommand(query, connection);
            suppliesTable.SelectCommand = command;
            suppliesTable.Fill(ds, "supplies");

            MySqlCommand commandSub = new MySqlCommand(querySub, connection);
            supplies_list_table.SelectCommand = commandSub;
            supplies_list_table.Fill(ds, "supplies_list");

            dgv1.DataSource = ds.Tables["supplies"];
        }

        public static void displayReceipt(DataGridView dgv, DataSet ds, MySqlDataAdapter receipt, string id)
        {
            string query = "SELECT conf.con_name as 'Повна назва товару', 'грн' as 'Вимір', supList.num_of_prod as 'Кількість продукту', conf.con_price as 'Ціна за одиницю', supList.num_of_prod * conf.con_price as 'Всього' FROM confectionery conf JOIN supplies_list supList ON conf.id_con = supList.con_id JOIN supplies sup USING(id_sup) WHERE supList.con_id = conf.id_con AND sup.id_sup = @suppliesID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@suppliesID", MySqlDbType.VarChar).Value = id;
            receipt.SelectCommand = command;
            receipt.Fill(ds, "receiptSupply");
            dgv.DataSource = ds.Tables["receiptSupply"];
            connection.Close();
        }

        public static void getConfBoxInfo(ComboBox cmb, DataTable dt)
        {
            if (dt != null)
            {
                cmb.DataSource = null;
                cmb.Refresh();
                dt.Clear();
            }
            string query = "SELECT id_con, con_name FROM confectionery";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(dt);
            cmb.DisplayMember = dt.Columns[1].ToString();
            cmb.ValueMember = dt.Columns[0].ToString(); ;
            cmb.DataSource = dt;
            connection.Close();
        }

        public static void getSupplierInfo(ComboBox cmb, DataTable dt)
        {
            if (dt != null)
            {
                cmb.DataSource = null;
                cmb.Refresh();
                dt.Clear();
            }
            string query = "SELECT id_sup, sup_name FROM supplier";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(dt);
            cmb.DisplayMember = dt.Columns[1].ToString();
            cmb.ValueMember = dt.Columns[0].ToString(); ;
            cmb.DataSource = dt;
            connection.Close();
        }
    }
}
