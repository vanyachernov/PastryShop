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
    public partial class FormProduct : Form
    {
        private readonly FormConfectionery _conf;
        public string id, productName, productCat, productDesc, productWeight, productFirm, productPrice;

        public FormProduct(FormConfectionery conf)
        {
            InitializeComponent();
            _conf = conf;
        }

        public void Clear()
        {
            txtProdName.Text = cmbProdCat.Text = txtProdDescirbe.Text = txtProdWeight.Text = cmbProdFirm.Text = txtProdPrice.Text = string.Empty;
        }

        public void InitializaData()
        {
            DBConfectionery.getProductType(cmbProdCat);
            DBConfectionery.getProductFirm(cmbProdFirm);
            cmbProdCat.SelectedIndex = cmbProdFirm.SelectedIndex = - 1;
        }

        public void UpdateInfo()
        {
            lblNewProd.Text = "Оновлення товару";
            btnSave.Text = "Оновити";
            txtProdName.Text = productName;
            cmbProdCat.Text = productCat;
            txtProdDescirbe.Text = productDesc;
            txtProdWeight.Text = Convert.ToDecimal(productWeight).ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            cmbProdFirm.Text = productFirm;
            txtProdPrice.Text = Convert.ToDecimal(productPrice).ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")); ;
        }

        public void SaveInfo()
        {
            lblNewProd.Text = "Новий продукт";
            btnSave.Text = "Зберегти";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProdName.Text.Trim().Length < 2)
            {
                MessageBox.Show("Введіть назву продукта!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbProdCat.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Оберіть категорію продукту!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtProdDescirbe.Text.Trim().Length < 2)
            {
                MessageBox.Show("Введіть вагу продукту!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbProdFirm.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Оберіть фірму-виробника продукту!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtProdPrice.Text.Trim().Length < 2)
            {
                MessageBox.Show("Введіть ціну на товар!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (btnSave.Text == "Зберегти")
            {
                ConfSettings std = new ConfSettings(txtProdName.Text.Trim(), cmbProdCat.Text.Trim(), txtProdDescirbe.Text.Trim(), txtProdWeight.Text.Trim(), cmbProdFirm.Text.Trim(), txtProdPrice.Text.Trim());
                DBConfectionery.addProduct(std);
                Clear();
            }
            if (btnSave.Text == "Оновити")
            {
                ConfSettings std = new ConfSettings(txtProdName.Text.Trim(), cmbProdCat.Text.Trim(), txtProdDescirbe.Text.Trim(), txtProdWeight.Text.Trim(), cmbProdFirm.Text.Trim(), txtProdPrice.Text.Trim());
                DBConfectionery.updateProduct(std, id);
            }
            _conf.Display(); 
        }
    }
}
