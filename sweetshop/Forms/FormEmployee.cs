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
    public partial class FormEmployee : Form
    {
        private readonly Employees _parent;
        public string id, name, surname, post, address, phone, birth_date;

        public FormEmployee(Employees parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            txtName.Text = txtSurname.Text = birthDate.Text = cmbPost.Text = txtPhone.Text = txtAddress.Text = string.Empty;
        }

        public void SaveInfo()
        {
            lblNewEmpl.Text = "Новий працівник";
            btnSave.Text = "Зберегти";
        }

        public void UpdateInfo()
        {
            lblNewEmpl.Text = "Оновлення працівника";
            btnSave.Text = "Оновити";
            txtName.Text = name;
            txtSurname.Text = surname;
            birthDate.Text = Convert.ToDateTime(birth_date).ToString("dd.MM.yyyy");
            cmbPost.Text = post;
            txtPhone.Text = phone;
            txtAddress.Text = address;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Введіть Ім'я працівника!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSurname.Text.Trim().Length < 3)
            {
                MessageBox.Show("Введіть Прізвище працівника!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbPost.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Введіть посаду працівника!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPhone.Text.Trim().Length < 10)
            {
                MessageBox.Show("Введіть телефон працівника!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtAddress.Text.Trim().Length < 9)
            {
                MessageBox.Show("Введіть адресу працівника!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (btnSave.Text == "Зберегти")
            {
                EmployeesSettings std = new EmployeesSettings(txtName.Text.Trim(), txtSurname.Text.Trim(), Convert.ToDateTime(birthDate.Text.Trim()).ToString("yyyy-MM-dd"), cmbPost.Text.Trim(), txtPhone.Text.Trim(), txtAddress.Text.Trim());
                DBEmployees.addEmployee(std);
                Clear();
            }
            if (btnSave.Text == "Оновити")
            {
                EmployeesSettings std = new EmployeesSettings(txtName.Text.Trim(), txtSurname.Text.Trim(), birthDate.Text.Trim(), cmbPost.Text.Trim(), txtPhone.Text.Trim(), txtAddress.Text.Trim());
                DBEmployees.updateEmployee(std, id);
            }
            _parent.Display();
        }
    }
}
