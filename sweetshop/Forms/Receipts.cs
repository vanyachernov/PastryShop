using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sweetshop
{
    public partial class Receipts : Form
    {
        DataSet ds = new DataSet();
        MySqlDataAdapter receipt = new MySqlDataAdapter();
        public string DateNow, SupNum, Supplier, Employee, Phone;
        public DateTime DateSup;

        public Receipts()
        {
            InitializeComponent();
            DateNow = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void Display()
        {
            DBSupplies.displayReceipt(dataGridView, ds, receipt, SupNum);
            dataGridView.ClearSelection();
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            mainPnl = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.mainPnl.Width / 2), this.mainPnl.Location.Y);
        }

        private void printToolTip_Click(object sender, EventArgs e)
        {
            Print(this.mainPnl);
        }

        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void getCommonPrice()
        {
            decimal price = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                price += Convert.ToDecimal(dataGridView.Rows[i].Cells[5].Value);
            }
            lblTotal.Text = price.ToString() + " грн";
            lblPdv.Text = Math.Round((price + (price * Convert.ToDecimal(0.2))), 2).ToString() + " грн";
        }

        private void Receipts_Load(object sender, EventArgs e)
        {
            Display();
            getCommonPrice();
            Phone = SuppliesSettings.supPhone;
            lblDate.Text = DateNow;
            lblDateSup.Text = DateSup.ToString("dd.MM.yyyy");
            lblNum.Text = "№ " + SupNum;
            lblSupplier.Text = Supplier;
            lblEmployee.Text = Employee;
            lblPhone.Text = "+38" + Phone;
        }
    }
}
