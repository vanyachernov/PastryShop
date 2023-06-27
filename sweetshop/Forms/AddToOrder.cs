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
    public partial class AddToOrder : Form
    {
        DataTable con = new DataTable();
        private readonly FormOrders _parent;
        public string productID;

        public AddToOrder(FormOrders parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void AddToOrder_Shown(object sender, EventArgs e)
        {
            DBOrders.getConfBoxInfo(productBox2, con);
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

        private void btnAddToOrder_Click(object sender, EventArgs e)
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
            OrderSettings ost = new OrderSettings(productBox2.Text.Trim(), txtQuantity2.Text.Trim(), "16.01.2022");
            DBOrders.checkProductQuantity(ost);
            DBOrders.addToOrder(ost);
            LoadFunct();
            Clear();
            initializeBoxes();
        }

        private void AddToOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
