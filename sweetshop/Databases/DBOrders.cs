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
    class DBOrders
    {
        public static bool checker = false;

        public static void addOrderOffline(OrderSettings ordStd)
        {
            string query = "call makeOrders((SELECT id_em FROM employees WHERE e_lname = @userLName AND e_fname = @userFName), (SELECT id_con FROM confectionery WHERE con_name = @productName), @productQuantity)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@userLName", MySqlDbType.VarChar).Value = LoginSettings.userLastName;
            command.Parameters.Add("@userFName", MySqlDbType.VarChar).Value = LoginSettings.userFirstName;
            command.Parameters.Add("@productName", MySqlDbType.VarChar).Value = ordStd.productName;
            command.Parameters.Add("@productQuantity", MySqlDbType.VarChar).Value = ordStd.productQuantity;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Замовлення успішно створено!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при створені замовлення! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void addOrderOnline(OrderSettings ordStd)
        {
            string query = "call makeOrdersOnline((SELECT id_em FROM employees WHERE e_lname = @userLName AND e_fname = @userFName), (SELECT id_con FROM confectionery WHERE con_name = @productName), @clientID, @productQuantity, @deliveryDate)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@userLName", MySqlDbType.VarChar).Value = LoginSettings.userLastName;
            command.Parameters.Add("@userFName", MySqlDbType.VarChar).Value = LoginSettings.userFirstName;
            command.Parameters.Add("@productName", MySqlDbType.VarChar).Value = ordStd.productName;
            command.Parameters.Add("@clientID", MySqlDbType.Int32).Value = ordStd.clientID;
            command.Parameters.Add("@productQuantity", MySqlDbType.VarChar).Value = ordStd.productQuantity;
            command.Parameters.Add("@deliveryDate", MySqlDbType.VarChar).Value = ordStd.deliveryDate;
            if (checker)
            {
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Замовлення успішно створено!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Помилка при створені замовлення! \n" + ex.Message, "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        public static void addToOrder(OrderSettings std)
        {
            string query = "call addToOrder((SELECT id_con FROM confectionery WHERE con_name = @productName), @productQuantity)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@productName", MySqlDbType.VarChar).Value = std.productName;
            command.Parameters.Add("@productQuantity", MySqlDbType.VarChar).Value = std.productQuantity;
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

        public static void deleteOrder(string id)
        {
            string query = "call deleteOrders(@orderID)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@orderID", MySqlDbType.VarChar).Value = id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Замовлення видалено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при видаленні замовлення! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        public static void display(DataGridView dgv1, DataSet ds, MySqlDataAdapter ordersTable, MySqlDataAdapter list_orders)
        {
            string query = "SELECT o.id_o, CONCAT(em.e_lname, ' ', em.e_fname) AS 'Працівник', o.date_of_order AS 'Дата замовлення', o.order_type AS 'Тип замовлення', IFNULL((SELECT CONCAT(cl_lname, ' ', cl_fname) FROM clients c JOIN orders ord ON c.id_cl = ord.cl_id WHERE ord.cl_id = o.cl_id limit 1), null) AS 'Клієнт', o.delivery_date AS 'Дата доставки', (SELECT SUM(lo.num_of_prod * conf.con_price) FROM orders ord JOIN list_orders lo USING(id_o) JOIN confectionery conf USING(id_con) WHERE ord.id_o = o.id_o) AS 'Підсумок' FROM(orders o JOIN employees em ON o.em_id = em.id_em)";
            string querySub = "SELECT o.id_o AS 'Номер замовлення', con.con_name AS 'Назва продукту', num_of_prod AS 'Кількість продукту', con.con_price AS 'Ціна' FROM (list_orders lo JOIN confectionery con USING(id_con)) JOIN orders o USING(id_o)";
            MySqlConnection connection = ConnectToDatabase.GetConnection();

            MySqlCommand command = new MySqlCommand(query, connection);
            ordersTable.SelectCommand = command;
            ordersTable.Fill(ds, "orders");

            MySqlCommand commandSub = new MySqlCommand(querySub, connection);
            list_orders.SelectCommand = commandSub;
            list_orders.Fill(ds, "list_orders");

            dgv1.DataSource = ds.Tables["orders"];
        }

        public static void displayReceipt(DataGridView dgv, DataSet ds, MySqlDataAdapter receipt, string id)
        {
            string query = "SELECT conf.con_name AS 'Повна назва товару', CONCAT('x', ordList.num_of_prod) AS 'Кількість продукту', ordList.num_of_prod * conf.con_price AS 'Всього' FROM confectionery conf JOIN list_orders ordList USING(id_con) JOIN orders o USING(id_o) WHERE ordList.id_con = conf.id_con AND o.id_o = @orderID";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@orderID", MySqlDbType.VarChar).Value = id;
            receipt.SelectCommand = command;
            receipt.Fill(ds, "receiptOrder");
            dgv.DataSource = ds.Tables["receiptOrder"];
            connection.Close();
        }

        public static void getPriceValues(DateTimePicker pc1, DateTimePicker pc2, DataGridView dgv)
        {
            string query = "SELECT o.id_o, CONCAT(em.e_lname, ' ', em.e_fname) AS 'Працівник', o.date_of_order AS 'Дата замовлення', o.order_type AS 'Тип замовлення', IFNULL((SELECT CONCAT(cl_lname, ' ', cl_fname) FROM clients c JOIN orders ord ON c.id_cl = ord.cl_id WHERE ord.cl_id = o.cl_id limit 1), null) AS 'Клієнт', o.delivery_date AS 'Дата доставки', (SELECT SUM(lo.num_of_prod * conf.con_price) FROM orders ord JOIN list_orders lo USING(id_o) JOIN confectionery conf USING(id_con) WHERE ord.id_o = o.id_o) AS 'Підсумок' FROM(orders o JOIN employees em ON o.em_id = em.id_em) WHERE o.date_of_order BETWEEN '" + pc1.Value.ToString("yyyy-MM-dd") + "' AND DATE_ADD('" + pc2.Value.ToString("yyyy-MM-dd") + "', interval 1 day);";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
            connection.Close();
        }

        public static void typeEmplID(string id)
        {
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            string query = "SELECT id_em FROM employees em JOIN orders o ON em.id_em = o.em_id WHERE o.id_o = @orderID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@orderID", MySqlDbType.VarChar).Value = id;
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    OrderSettings.employeeID = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public static void checkProductQuantity(OrderSettings std)
        {
            string query = "SELECT total_amount FROM confectionery WHERE con_name = @productName";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@productName", MySqlDbType.VarChar).Value = std.productName;
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    OrderSettings.checkProductQuantity = reader.GetString(0);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при зчитуванні! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void getClientID(ClientsInfo std, OrderSettings subStd)
        {
            string query = "SELECT id_cl from clients WHERE cl_lname = @clientSurname";
            MySqlConnection connection = ConnectToDatabase.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@clientSurname", MySqlDbType.VarChar).Value = std.clientSurname;
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("Такого клієнта у базі даних не існує!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                while(reader.Read())
                {
                    subStd.clientID = reader.GetString(0);
                    checker = true;
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при знаходженні коду! \n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string query = "SELECT id_con, con_name FROM confectionery WHERE total_amount <> 0";
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
