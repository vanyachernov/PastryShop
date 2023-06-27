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
    public partial class FormProductTypes : Form
    {
        private readonly FormConfectionery _conf;
        DataSet ds = new DataSet();
        MySqlDataAdapter types = new MySqlDataAdapter();
        public string typeName;
        

        public FormProductTypes(FormConfectionery conf)
        {
            InitializeComponent();
            _conf = conf;
        }

        private void FormProductTypes_Shown(object sender, EventArgs e)
        {
            Display();
            getInfo();
        }

        private void Clear()
        {
            txtCat.Text = string.Empty;
        }

        private void Display()
        {
            ds.Clear();
            DBProdTypes.display(dataGridView, ds, types);
        }

        private void getInfo()
        {
            TypesSettings std = new TypesSettings(txtCat.Text.Trim(), null);
            DBProdTypes.getTypeInfo(std, dataGridView);
            txtCat.Text = std.productType;
            typeName = std.productType;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            TypesSettings std = new TypesSettings(txtCat.Text.Trim(), null);
            DBProdTypes prod = new DBProdTypes();
            prod.checkTypeExists(std);
            if (txtCat.Text.Length < 3)
            {
                MessageBox.Show("Введіть назву категорії!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!prod.checkerList)
            {
                DBProdTypes.makeType(std);
                Display();
                _conf.Display();
                dataGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Заданий тип вже існує!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = dataGridView.CurrentRow.Cells[0].Value.ToString();
            TypesSettings std = new TypesSettings(txtCat.Text.Trim(), null);
            if (txtCat.Text.Length < 3)
            {
                MessageBox.Show("Введіть назву категорії!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCat.Text == typeName)
            {
                MessageBox.Show("Назву категорії не було змінено!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBProdTypes.updateType(std, id);
            typeName = std.productType;
            Display();
            _conf.Display();
        }

        private void deleteTypeToolTip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете видалити тип?", "Кондитерська", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string type = dataGridView.CurrentRow.Cells[1].Value.ToString();
                TypesSettings std = new TypesSettings(type, null);
                DBProdTypes types = new DBProdTypes();
                types.checkFirmExistsInConf(std);
                if (!types.checkerConf)
                {
                    string typeID = dataGridView.CurrentRow.Cells[0].Value.ToString();
                    DBProdTypes.deleteType(typeID);
                    Display();
                    _conf.Display();
                    dataGridView.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Неможливо видалити тип продукту!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            getInfo();
        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
