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
    public partial class FormClients : Form
    {
        FormClient frm;
        public FormClients()
        {
            InitializeComponent();
            frm = new FormClient(this);
        }

        private void FormClients_Shown(object sender, EventArgs e)
        {
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersHeight = 24;
            Display();
        }

        public void Display()
        {
            DBClients.displayAndSearch("SELECT id_cl, cl_lname, cl_fname, cl_phone, cl_address FROM clients", dataGridView);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DBClients.displayAndSearch("SELECT id_cl, cl_lname, cl_fname, cl_phone, cl_address FROM clients WHERE cl_lname LIKE'%" + txtSearch.Text + "%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                frm.Clear();
                frm.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.surname = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.name = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.phone = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.address = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.UpdateInfo();
                frm.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Ви впевнені, що хочете видалити запис?", "Кондитерська", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBClients.deleteClient(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frm.Clear();
            frm.SaveInfo();
            frm.ShowDialog();
        }
    }
}
