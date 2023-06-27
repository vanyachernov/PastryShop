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
    public partial class FormUsers : Form
    {
        DataSet ds = new DataSet();
        MySqlDataAdapter ordersTable = new MySqlDataAdapter();

        public FormUsers()
        {
            InitializeComponent();
        }

        private void Display()
        {
            ds.Clear();
            DBUsers.display(dataGridView, ds, ordersTable);
        }

        private void FormUsers_Shown(object sender, EventArgs e)
        {
            DBUsers.getEmplBoxInfo(cmbEmpl);
            Display();
            shownInfo();
        }

        private void exitToolTip_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            shownInfo();
        }

        private void Clear()
        {
            cmbEmpl.SelectedIndex = cmbMode.SelectedIndex = -1;
            txtLogin.Text = txtPass.Text = string.Empty;
        }

        private void shownInfo()
        {
            UsersSettings std = new UsersSettings(cmbEmpl.Text.Trim(), txtLogin.Text.Trim(), txtPass.Text.Trim(), cmbMode.Text.Trim());
            DBUsers.getUserInfo(std, dataGridView);
            cmbEmpl.Text = std.Surname;
            txtLogin.Text = std.Login;
            txtPass.Text = std.Password;
            cmbMode.Text = std.Mode;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UsersSettings std = new UsersSettings(cmbEmpl.Text.Trim(), txtLogin.Text.Trim(), txtPass.Text.Trim(), cmbMode.Text.Trim());
            DBUsers.getUserID(std);
            if (txtLogin.Text.Length < 3 || txtPass.Text.Length < 5 || cmbMode.Text == "")
            {
                MessageBox.Show("Щоб змінити дані, потрібно ввести всі параметри, \nабо дані повинні відповідати нормам!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBUsers.updateUser(std);
            Display();
            dataGridView.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LoginSettings.userLastName == dataGridView.CurrentRow.Cells[0].Value.ToString() && LoginSettings.userFirstName == dataGridView.CurrentRow.Cells[1].Value.ToString()) {
                MessageBox.Show("Неможливо видалити поточний обліковий запис!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UsersSettings std = new UsersSettings(cmbEmpl.Text.Trim(), txtLogin.Text.Trim(), txtPass.Text.Trim(), cmbMode.Text.Trim());
            DBUsers.getUserID(std);
            DBUsers.deleteUser(std);
            Display();
            dataGridView.ClearSelection();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DBUsers frm = new DBUsers();
            UsersSettings std = new UsersSettings(cmbEmpl.Text.Trim(), txtLogin.Text.Trim(), txtPass.Text.Trim(), cmbMode.Text.Trim());
            DBUsers.getUserID(std);
            frm.checkerUserExist(std);
            if (cmbEmpl.Text == "")
            {
                MessageBox.Show("Оберіть прізвище працівника!");
                return;
            }
            if (txtLogin.Text.Length < 3)
            {
                MessageBox.Show("Введіть логін нового користувача!");
                return;
            }
            if (txtPass.Text.Length < 5)
            {
                MessageBox.Show("Введіть пароль нового користувача!");
                return;
            }
            if (cmbMode.Text == "")
            {
                MessageBox.Show("Оберіть бажаний режим нового користувача!");
                return;
            }
            if (!frm.checker)
            {
                DBUsers.addUser(std);
                Clear();
                Display();
            }
            else
            {
                MessageBox.Show("Аккаунт цього користувача вже існує", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
