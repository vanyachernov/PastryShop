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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = txtUsername.MaxLength = 30;
            txtUsername.Select();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            DBLoginForm frm = new DBLoginForm();
            frm.LoginSys(txtUsername.Text, txtPassword.Text);
            if(frm.checker)
            {
                FormOrders ordersForm = new FormOrders();
                ordersForm.Show();
                this.Hide();
            }
        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            txtUsername.Text = txtPassword.Text = string.Empty;
            txtUsername.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLog.PerformClick();
                txtPassword.Text = string.Empty;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Select();
                e.SuppressKeyPress = true;
            }
        }
    }
}
