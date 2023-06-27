using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sweetshop
{
    public partial class FormOrders : Form
    {
        DataSet ds = new DataSet();
        DataTable con = new DataTable();
        MySqlDataAdapter ordersTable = new MySqlDataAdapter();
        MySqlDataAdapter list_orders = new MySqlDataAdapter();
        FormClients frm;
        AddToOrder adder;

        public FormOrders()
        {
            InitializeComponent();
            initializeData();
            frm = new FormClients();
            adder = new AddToOrder(this);
        }
        
        private void FormOrders_Shown(object sender, EventArgs e)
        {
            Display();
            initializeBoxes();
            shownInfoGrid();
            getCommonPrice();
            //TotalNumProd();
            shownLoginStd();
            txtCommonPrice.Height = 21;
            txtDate.MinDate = DateTime.Today;
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            dataGridView.ContextMenuStrip.Opening += subMenuStrip_Opening;
        }

        private void subMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = dataGridView.RowCount == 0;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(dataGridView.CurrentRow.Cells[1].Value.ToString());
        }

        private void FormOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void wareHouseToolTip_Click(object sender, EventArgs e)
        {
            FormConfectionery frm = new FormConfectionery(this);
            frm.Show();
        }

        private void clientsToolTip_Click(object sender, EventArgs e)
        {
            FormClients frm = new FormClients();
            frm.ShowDialog();
        }

        private void userToolTip_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void addToOrderToolTip_Click(object sender, EventArgs e)
        {
            adder.InitializeData = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[0].Value.ToString();
            adder.ShowDialog();
        }

        private void exitToolTip_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeesTip_Click(object sender, EventArgs e)
        {
            Employees frm = new Employees();
            frm.ShowDialog();
        }

        private void suppliesToolTip_Click(object sender, EventArgs e)
        {
            Supplies sup = new Supplies(this);
            sup.Show();
        }

        private void usersToolTip_Click(object sender, EventArgs e)
        {
            FormUsers frm = new FormUsers();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DBOrders.getPriceValues(minDate, maxDate, dataGridView);
            dataGridView.ClearSelection();
            TotalNumProd();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ds.Clear();
            Display();
            TotalNumProd();
            dataGridView.ClearSelection();
            dgvSub.ClearSelection();
        }

        private void storeReceiptToolTip_Click(object sender, EventArgs e)
        {
            StoreReceipts rec = new StoreReceipts();
            rec.OrdNum = dataGridView.CurrentRow.Cells[0].Value.ToString();
            DBOrders.typeEmplID(rec.OrdNum);
            rec.Employee = dataGridView.CurrentRow.Cells[1].Value.ToString();
            rec.DateOrd = Convert.ToDateTime(dataGridView.CurrentRow.Cells[2].Value);
            rec.totalPrice = dataGridView.CurrentRow.Cells[6].Value.ToString();
            rec.ShowDialog();
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void deleteOrderToolTip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете видалити замовлення?", "Кондитерська", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string orderID = dataGridView.CurrentRow.Cells[0].Value.ToString();
                DBOrders.deleteOrder(orderID);
                dataSetClear();
                Display();
                TotalNumProd();
                shownInfoGrid();
                initializeBoxes();
            }
        }

        public void Display()
        {
            DBOrders.display(dataGridView, ds, ordersTable, list_orders);
        }

        public void Clear()
        {
            productBox1.SelectedIndex = clientStatusBox.SelectedIndex = -1;
            typeOrderBox.Text = txtQuantity1.Text = txtClLName.Text = txtClFName.Text = string.Empty;
        }

        public void dataSetClear()
        {
            ds.Clear();
        }

        public void selectRow()
        {
            dataGridView.CurrentCell = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[1];
        }

        private void blockTxtBox()
        {
            clientStatusBox.Enabled = txtDate.Enabled = txtClLName.Enabled = txtClFName.Enabled = false;
        }

        public void initializeBoxes()
        {
            con.Clear();
            DBOrders.getConfBoxInfo(productBox1, con);
            productBox1.SelectedIndex = -1;
        }

        public void initializeData()
        {
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersHeight = 24;
            blockTxtBox();
            if (LoginSettings.userMode == "Касир")
            {
                usersToolTip.Enabled = false;
                deleteOrderToolTip.Enabled = false;
                employeesToolTip.Enabled = false;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            shownInfoGrid();
            getCommonPrice();
        }

        public void getCommonPrice()
        {
            decimal price = 0;
            for (int i = 0; i < dgvSub.Rows.Count; i++)
            {
                price += Convert.ToDecimal(dgvSub.Rows[i].Cells[2].Value) * Convert.ToDecimal(dgvSub.Rows[i].Cells[3].Value);
            }
            txtCommonPrice.Text = price.ToString() + " грн";
        }
        
        public void TotalNumProd()
        {
            int total = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                total += Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value);
            }
            lblTotal.Text = total.ToString() + " грн";
        }

        private void shownLoginStd()
        {
            selectedUserToolTip.Text = LoginSettings.userMode + ": " + LoginSettings.userLastName + " " + LoginSettings.userFirstName;
        }

        public void shownInfoGrid()
        {
            if(dataGridView.Rows.Count != 0)
            {
                ds.Tables["list_orders"].DefaultView.RowFilter = $"[{dgvSub.Columns[0].HeaderText}] = {Convert.ToString(dataGridView.CurrentRow.Cells[0].Value)}";
                dgvSub.DataSource = ds.Tables["list_orders"];
            }
            dgvSub.ClearSelection();
        }

        private void typeOrderBox_TextChanged(object sender, EventArgs e)
        {
            if (typeOrderBox.Text == "У точці видачі")
            {
                clientStatusBox.Enabled = false;
                txtDate.Enabled = false;
            }
            if (typeOrderBox.Text == "Доставка")
            {
                clientStatusBox.Enabled = true;
                txtDate.Enabled = true;
            }
        }

        private void clientStatusBox_TextChanged(object sender, EventArgs e)
        {
            
            if (clientStatusBox.Text == "Існуючий")
            {
                txtClFName.Enabled = txtClLName.Enabled = true;
            }
            if (clientStatusBox.Text == "Новий")
            {
                ClientsInfo std = new ClientsInfo();
                frm.ShowDialog();
                txtClFName.Text = std.clientName;
                txtClLName.Text = std.clientSurname;
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (productBox1.Text.Trim().Length < 5)
            {
                MessageBox.Show("Не обран бажаний виріб!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtQuantity1.Text.Trim().Length < 1)
            {
                MessageBox.Show("Відсутня бажана кількість виробу!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string dt = txtDate.Value.ToString("yyyy-MM-dd");
            OrderSettings frm = new OrderSettings(productBox1.Text.Trim(), txtQuantity1.Text.Trim(), dt);
            ClientsInfo std = new ClientsInfo();
            DBOrders.checkProductQuantity(frm);
            if (typeOrderBox.Text == "У точці видачі")
            {
                if (Convert.ToInt32(OrderSettings.checkProductQuantity) >= Convert.ToInt32(txtQuantity1.Text))
                {
                    DBOrders.addOrderOffline(frm);
                }
                else
                {
                    MessageBox.Show("Вказана кількість продукту відсутня!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (typeOrderBox.Text == "Доставка")
            {
                if (Convert.ToInt32(OrderSettings.checkProductQuantity) >= Convert.ToInt32(txtQuantity1.Text))
                {
                    std.clientSurname = txtClLName.Text.Trim();
                    DBOrders.getClientID(std, frm);
                    DBOrders.addOrderOnline(frm);
                }
                else
                {
                    MessageBox.Show("Вказана кількість продукту відсутня!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Clear();
            dataSetClear();
            initializeBoxes();
            Display();
            TotalNumProd();
            if (dataGridView.Rows.Count != 0)
                selectRow();
            shownInfoGrid();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
