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
    public partial class StoreReceipts : Form
    {
        DataSet ds = new DataSet();
        MySqlDataAdapter receipt = new MySqlDataAdapter();
        public string totalPrice, Employee, OrdNum, EmplNum;
        public DateTime DateOrd;

        public StoreReceipts()
        {
            InitializeComponent();
        }

        private void StoreReceipts_Shown(object sender, EventArgs e)
        {
            Display();
            EmplNum = OrderSettings.employeeID;
            lblDate.Text = DateOrd.ToString("dd.MM.yyyy");
            lblTime.Text = DateOrd.ToString("hh:mm");
            lblOrder.Text = OrdNum;
            lblEmployee.Text = Employee;
            lblCheckOut.Text = EmplNum;
            lblTotal.Text = lblTotalSum.Text = totalPrice + " грн";
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
            e.Graphics.DrawImage(memoryimg, 0, 0);
        }

        private Bitmap memoryimg;

        private void printToolTip_Click(object sender, EventArgs e)
        {
            Print(this.mainPnl);
        }

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void Display()
        {
            DBOrders.displayReceipt(dataGridView, ds, receipt, OrdNum);
            dataGridView.ClearSelection();
        }

        private void exitToolTip_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
