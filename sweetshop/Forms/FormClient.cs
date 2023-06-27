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
    public partial class FormClient : Form
    {
        private readonly FormClients _parent;
        public string id, name, surname, phone, address;

        public FormClient(FormClients parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            txtName.Text = txtSurname.Text = txtPhone.Text = txtAddress.Text = string.Empty;
        }

        public void UpdateInfo()
        {
            lblNewCl.Text = "Оновлення клієнта";
            btnSave.Text = "Оновити";
            txtName.Text = name;
            txtSurname.Text = surname;
            txtPhone.Text = phone;
            txtAddress.Text = address;
        }

        public void SaveInfo()
        {
            lblNewCl.Text = "Новий клієнт";
            btnSave.Text = "Зберегти";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Введіть Ім'я клієнта!");
                return;
            }
            if (txtSurname.Text.Trim().Length < 3)
            {
                MessageBox.Show("Введіть Прізвище клієнта!");
                return;
            }
            if (txtPhone.Text.Trim().Length < 11)
            {
                MessageBox.Show("Введіть телефон клієнта!");
                return;
            }
            if (txtAddress.Text.Trim().Length < 9)
            {
                MessageBox.Show("Введіть адресу клієнта!");
                return;
            }
            if (btnSave.Text == "Зберегти")
            {
                ClientsInfo frm = new ClientsInfo();
                Client std = new Client(txtName.Text.Trim(), txtSurname.Text.Trim(), txtPhone.Text.Trim(), txtAddress.Text.Trim());
                DBClients.addClient(std);
                frm.clientName = txtName.Text.Trim();
                frm.clientSurname = txtSurname.Text.Trim();
                Clear();
            }
            if(btnSave.Text == "Оновити")
            {
                Client std = new Client(txtName.Text.Trim(), txtSurname.Text.Trim(), txtPhone.Text.Trim(), txtAddress.Text.Trim());
                DBClients.updateClient(std, id);
            }
            _parent.Display();
        }
    }
}
