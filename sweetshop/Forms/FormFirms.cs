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
    public partial class FormFirms : Form
    {
        private readonly FormConfectionery _conf;
        DataSet ds = new DataSet();
        MySqlDataAdapter firms = new MySqlDataAdapter();

        public FormFirms(FormConfectionery conf)
        {
            InitializeComponent();
            _conf = conf;
        }

        private void Clear()
        {
            txtFirm.Text = txtCity.Text = string.Empty;
        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Display()
        {
            ds.Clear();
            DBFirms.display(dataGridView, ds, firms);
        }

        private void FormFirms_Shown(object sender, EventArgs e)
        {
            Display();
            getInfo();
        }

        private void getInfo()
        {
            FirmsSettings std = new FirmsSettings(txtFirm.Text.Trim(), null, txtCity.Text.Trim());
            DBFirms.getFirmInfo(std, dataGridView);
            txtFirm.Text = std.firmName;
            txtCity.Text = std.firmCity;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FirmsSettings std = new FirmsSettings(txtFirm.Text.Trim(), null, txtCity.Text.Trim());
            DBFirms firms = new DBFirms();
            firms.checkFirmExistsInList(std);
            if (txtFirm.Text.Length < 3)
            {
                MessageBox.Show("Введіть назву фірми!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCity.Text.Length < 4)
            {
                MessageBox.Show("Введіть місце-розташування фірми!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!firms.checkerList)
            {
                DBFirms.makeFirm(std);
                Display();
                _conf.Display();
                dataGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Задана фірма вже існує!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string firmID = dataGridView.CurrentRow.Cells[0].Value.ToString();
            string firm = dataGridView.CurrentRow.Cells[1].Value.ToString();
            string city = dataGridView.CurrentRow.Cells[2].Value.ToString();
            FirmsSettings std = new FirmsSettings(txtFirm.Text.Trim(), null, txtCity.Text.Trim());
            if (txtFirm.Text.Length < 3)
            {
                MessageBox.Show("Введіть назву фірми!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCity.Text.Length < 3)
            {
                MessageBox.Show("Введіть місто-розташування фірми!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtFirm.Text == firm && txtCity.Text == city)
            {
                MessageBox.Show("Назву фірми не було змінено!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBFirms.updateFirm(std, firmID);
            Display();
            _conf.Display();
        }

        private void deleteFirmToolTip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете видалити фірму?", "Кондитерська", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string firm = dataGridView.CurrentRow.Cells[1].Value.ToString();
                FirmsSettings std = new FirmsSettings(firm, null, null);
                DBFirms firms = new DBFirms();
                firms.checkFirmExistsInConf(std);
                if (!firms.checkerConf)
                {
                    string firmID = dataGridView.CurrentRow.Cells[0].Value.ToString();
                    DBFirms.deleteFirm(firmID);
                    Display();
                    _conf.Display();
                    dataGridView.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Неможливо видалити фірму!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            getInfo();
        }
    }
}
