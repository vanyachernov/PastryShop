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
    public partial class FormConfectionery : Form
    {
        FormProduct prod;
        FormProductTypes types;
        FormFirms firms;

        public FormConfectionery(FormOrders ord)
        {
            InitializeComponent();
            prod = new FormProduct(this);
            types = new FormProductTypes(this);
            firms = new FormFirms(this);
            ord.Hide();
        }

        private void FormConfectionery_Load(object sender, EventArgs e)
        {
            dataGridView.ContextMenuStrip.Opening += menuStrip2_Opening;
        }

        private void FormConfectionery_Shown(object sender, EventArgs e)
        {
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersHeight = 24;
            Display();
            productInfo();
            if (LoginSettings.userMode == "Касир")
            {
                editProductToolTip.Enabled = false;
                deleteProductToolTip.Enabled = false;
                btnNewProd.Enabled = false;
            }
        }

        public void Display()
        {
            DBConfectionery.displayAndSearch("SELECT conf.id_con as '#', conf.con_name as 'Назва', conf.con_describe as 'Опис', conf.con_weight as 'Вага', conf.con_price as 'Ціна', typecon.type_name as 'Категорія', fm.firm_name as 'Фірма-виробник', CONCAT(conf.total_amount, ' шт') as 'Поточна кількість' FROM ((confectionery conf JOIN con_types typecon ON conf.type_con = typecon.id_typecon) JOIN firms fm ON conf.con_firm = fm.id_firm)", dataGridView);
        }

        public void Clear()
        {
            txtValueMin.Text = txtValueMax.Text = txtSearchByValues.Text = string.Empty;
        }

        private void txtSearchByValues_TextChanged(object sender, EventArgs e)
        {
            DBConfectionery.displayAndSearch("SELECT conf.id_con as '#', conf.con_name as 'Назва', conf.con_describe as 'Опис', conf.con_weight as 'Вага', conf.con_price as 'Ціна',  typecon.type_name as 'Категорія', fm.firm_name as 'Фірма-виробник' FROM((confectionery conf JOIN con_types typecon ON conf.type_con = typecon.id_typecon) JOIN firms fm ON conf.con_firm = fm.id_firm) WHERE conf.con_name LIKE CONCAT('%', '" + txtSearchByValues.Text + "', '%') OR fm.firm_name LIKE CONCAT('%', '" + txtSearchByValues.Text + "', '%') OR typecon.type_name LIKE CONCAT('%', '" + txtSearchByValues.Text + "', '%')", dataGridView);
        }

        private void FormConfectionery_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormOrders ord = new FormOrders();
            ord.Show();
            ord.initializeBoxes();
        }

        private void menuStrip2_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = dataGridView.RowCount == 0;
        }

        private void productInfo()
        {
            if (dataGridView.Rows.Count != 0)
            {
                txtCurrentInfo std = new txtCurrentInfo(txtNameProduct.Text.Trim(), txtDescribeProduct.Text.Trim());
                DBConfectionery.getProductInfo(std, dataGridView);
                txtNameProduct.Text = std.nameProduct;
                txtDescribeProduct.Text = std.describeProduct;
            }
        }

        private void exitToolTip_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrders ord = new FormOrders();
            ord.Show();
            ord.initializeBoxes();
        }

        private void btnNewProd_Click(object sender, EventArgs e)
        {
            prod.InitializaData();
            prod.SaveInfo();
            prod.Clear();
            prod.ShowDialog();
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            Clear();
            prod.SaveInfo();
            Display();
        }

        private void btnNewCat_Click(object sender, EventArgs e)
        {
            types.ShowDialog();
        }

        private void btnNewFirm_Click(object sender, EventArgs e)
        {
            firms.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtValueMin.Text.Trim().Length < 2)
            {
                MessageBox.Show("Введіть мінімальну ціну!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtValueMax.Text.Trim().Length < 2)
            {
                MessageBox.Show("Введіть максимальну ціну!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtValueMin.Text.Trim().Length > 4)
            {
                MessageBox.Show("Мінімальна ціна занадто велика!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtValueMax.Text.Trim().Length > 4)
            {
                MessageBox.Show("Максимальна ціна занадто велика!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Prices std = new Prices(txtValueMin.Text.Trim(), txtValueMax.Text.Trim());
            DBConfectionery.getPriceValues(std, dataGridView);
        }

        private void editProductToolTip_Click(object sender, EventArgs e)
        {
            prod.InitializaData();
            prod.Clear();
            prod.id = dataGridView.CurrentRow.Cells[0].Value.ToString();
            prod.productName = dataGridView.CurrentRow.Cells[1].Value.ToString();
            prod.productCat = dataGridView.CurrentRow.Cells[5].Value.ToString();
            prod.productDesc = dataGridView.CurrentRow.Cells[2].Value.ToString();
            prod.productWeight = dataGridView.CurrentRow.Cells[3].Value.ToString();
            prod.productFirm = dataGridView.CurrentRow.Cells[6].Value.ToString();
            prod.productPrice = dataGridView.CurrentRow.Cells[4].Value.ToString();
            prod.UpdateInfo();
            prod.ShowDialog();
            return;
        }

        private void deleteProductToolTip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете видалити продукт?", "Кондитерська", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DBConfectionery.deleteProduct(dataGridView.CurrentRow.Cells[0].Value.ToString());
                Display();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productInfo();
        }
    }
}
