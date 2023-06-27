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
    public partial class AddToSupply : Form
    {
        DataTable con = new DataTable();
        private readonly Supplies _parent;
        public string productID;

        public AddToSupply(Supplies parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void AddToSupply_Shown(object sender, EventArgs e)
        {
            DBSupplies.getConfBoxInfo(productBox2, con);
        }

        private void Clear()
        {
            productBox2.SelectedIndex = -1;
            txtQuantity2.Text = string.Empty;
        }

        public string InitializeData
        {
            get { return txtNumOrder.Text; }
            set { txtNumOrder.Text = value; }
        }

        public void initializeBoxes()
        {
            con.Clear();
            DBOrders.getConfBoxInfo(productBox2, con);
        }

        private void LoadFunct()
        {
            _parent.dataSetClear();
            _parent.Display();
            _parent.selectRow();
            _parent.shownInfoGrid();
            _parent.getCommonPrice();
            _parent.TotalNumProd();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (productBox2.Text.Trim().Length < 5)
            {
                MessageBox.Show("Не обран бажаний виріб!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtQuantity2.Text.Trim().Length < 1)
            {
                MessageBox.Show("Відсутня бажана кількість виробу!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SuppliesSettings ost = new SuppliesSettings(null, productBox2.Text.Trim(), txtQuantity2.Text.Trim());
            DBSupplies.addToSupply(ost);
            LoadFunct();
            Clear();
        }
    }
}
