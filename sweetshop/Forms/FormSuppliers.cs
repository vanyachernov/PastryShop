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
    public partial class FormSuppliers : Form
    {
        DataSet ds = new DataSet();
        MySqlDataAdapter suppliers = new MySqlDataAdapter();
        private readonly Supplies _sup;

        public FormSuppliers(Supplies sup)
        {
            InitializeComponent();
            _sup = sup;
        }

        private void FormSuppliers_Shown(object sender, EventArgs e)
        {
            Display();
            if (dataGridView.Rows.Count != 0)
                shownInfo();
        }

        public void Display()
        {
            ds.Clear();
            DBSuppliers.display(dataGridView, ds, suppliers);
        }

        public void Clear()
        {
            txtSupplier.Text = txtAddress.Text = txtPhone.Text = string.Empty;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            shownInfo();
        }

        private void shownInfo()
        {
            SuppliersSettings std = new SuppliersSettings(txtSupplier.Text.Trim(), txtAddress.Text.Trim(), txtPhone.Text.Trim());
            DBSuppliers.getSupInfo(std, dataGridView);
            txtSupplier.Text = std.supName;
            txtAddress.Text = std.address;
            txtPhone.Text = std.phone;
        }

        private void exitToolTip_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SuppliersSettings std = new SuppliersSettings(txtSupplier.Text.Trim(), txtAddress.Text.Trim(), txtPhone.Text.Trim());
            if (txtSupplier.Text.Length < 3)
            {
                MessageBox.Show("Введіть назву постачальника!");
                return;
            }
            if (txtAddress.Text.Length < 5)
            {
                MessageBox.Show("Введіть адресу постачальника!");
                return;
            }
            if (txtPhone.Text.Length < 10)
            {
                MessageBox.Show("Введіть номер телефону постачальника!");
                return;
            }
            DBSuppliers.addSupplier(std);
            Clear();
            Display();
            _sup.initializeBoxes();
            dataGridView.ClearSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SuppliersSettings std = new SuppliersSettings(txtSupplier.Text.Trim(), txtAddress.Text.Trim(), txtPhone.Text.Trim());
            if (txtSupplier.Text.Length < 3 || txtAddress.Text.Length < 5 || txtPhone.Text.Length < 10)
            {
                MessageBox.Show("Щоб змінити дані, потрібно ввести всі параметри!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBSuppliers.updateSupplier(std);
            Display();
            _sup.Display();
        }

        private void deleteSupplierToolTip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете видалити тип?", "Кондитерська", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string type = dataGridView.CurrentRow.Cells[1].Value.ToString();
                SuppliersSettings std = new SuppliersSettings(type, null, null);
                DBSuppliers sup = new DBSuppliers();
                sup.checkFirmExistsInSup(std);
                if (!sup.checkerSupplies)
                {
                    string supID = dataGridView.CurrentRow.Cells[0].Value.ToString();
                    DBSuppliers.deleteSupplier(supID);
                    Display();
                    _sup.Display();
                    dataGridView.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Неможливо видалити постачальника!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
    }
}
