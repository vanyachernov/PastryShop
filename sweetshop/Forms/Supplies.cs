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
    public partial class Supplies : Form
    {
        private readonly FormOrders _parent;
        AddToSupply adder;
        DataSet ds = new DataSet();
        DataTable con = new DataTable();
        DataTable sup = new DataTable();
        MySqlDataAdapter supplies = new MySqlDataAdapter();
        MySqlDataAdapter supplies_list = new MySqlDataAdapter();
        FormSuppliers suppliers;

        private void Supplies_Shown(object sender, EventArgs e)
        {
            dataSetClear();
            Display();
            TotalNumProd();
            initializeBoxes();
            shownInfoGrid();
            getCommonPrice();
        }

        private void Supplies_Load(object sender, EventArgs e)
        {
            dataGridView.ContextMenuStrip.Opening += contextMenuStrip1_Opening;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = dataGridView.RowCount == 0;
        }

        public Supplies(FormOrders parent)
        {
            InitializeComponent();
            _parent = parent;
            adder = new AddToSupply(this);
            suppliers = new FormSuppliers(this);
            parent.Hide();
        }

        private void suppliersToolTip_Click(object sender, EventArgs e)
        {
            
            suppliers.ShowDialog();
        }

        private void exitToolTip_Click(object sender, EventArgs e)
        {
            FormOrders ord = new FormOrders();
            ord.Show();
            ord.initializeBoxes();
        }

        public void Display()
        {
            ds.Clear();
            DBSupplies.display(dataGridView, ds, supplies, supplies_list);
        }

        public void Clear()
        {
            supplierBox1.SelectedIndex = productBox1.SelectedIndex = -1;
            txtQuant.Text = string.Empty;
        }

        public void dataSetClear()
        {
            ds.Clear();
        }

        public void TotalNumProd()
        {
            int total = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                total += Convert.ToInt32(dataGridView.Rows[i].Cells[4].Value);
            }
            lblTotal.Text = total.ToString() + " грн";
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            shownInfoGrid();
            getCommonPrice();
        }

        public void initializeBoxes()
        {
            con.Clear();
            DBSupplies.getConfBoxInfo(productBox1, con);
            DBSupplies.getSupplierInfo(supplierBox1, sup);
            supplierBox1.SelectedIndex = -1;
            productBox1.SelectedIndex = -1;
        }

        public void selectRow()
        {
            dataGridView.CurrentCell = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[2];
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

        private void Supplies_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormOrders ord = new FormOrders();
            ord.Show();
            ord.initializeBoxes();
        }

        public void shownInfoGrid()
        {
            if (dataGridView.Rows.Count != 0)
            {
                ds.Tables["supplies_list"].DefaultView.RowFilter = $"[{dgvSub.Columns[0].HeaderText}] = {Convert.ToString(dataGridView.CurrentRow.Cells[0].Value)}";
                dgvSub.DataSource = ds.Tables["supplies_list"];
            }
            dgvSub.ClearSelection();
        }

        private void addToSupToolTip_Click(object sender, EventArgs e)
        {
            adder.InitializeData = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[0].Value.ToString();
            adder.ShowDialog();
        }

        private void makeConsignment_Click(object sender, EventArgs e)
        {
            Receipts rec = new Receipts();
            rec.SupNum = dataGridView.CurrentRow.Cells[0].Value.ToString();
            rec.Supplier = dataGridView.CurrentRow.Cells[1].Value.ToString();
            DBSupplies.typePhone(rec.Supplier);
            rec.Employee = dataGridView.CurrentRow.Cells[2].Value.ToString();
            rec.DateSup = Convert.ToDateTime(dataGridView.CurrentRow.Cells[3].Value);
            rec.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (productBox1.Text.Trim().Length < 5)
            {
                MessageBox.Show("Не обран бажаний виріб!", "Центр постачань", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtQuant.Text.Trim().Length < 1)
            {
                MessageBox.Show("Відсутня бажана кількість виробу!", "Центр постачань", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SuppliesSettings std = new SuppliesSettings(supplierBox1.Text.Trim(), productBox1.Text.Trim(), txtQuant.Text.Trim());
            DBSupplies.makeSupply(std);
            Clear();
            dataSetClear();
            Display();
            TotalNumProd();
            selectRow();
            shownInfoGrid();
            dataGridView.ClearSelection();
        }
    }
}
