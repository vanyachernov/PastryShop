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
    public partial class Employees : Form
    {
        FormEmployee frm;
        public Employees()
        {
            InitializeComponent();
            frm = new FormEmployee(this);
        }

        public void Display()
        {
            DBEmployees.displayAndSearch("SELECT id_em, e_lname, e_fname, e_post, date_of_birth, e_phone, e_address FROM employees", dataGridView);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frm.Clear();
            frm.SaveInfo();
            frm.ShowDialog();
        }

        private void Employees_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DBEmployees.displayAndSearch("SELECT id_em, e_lname, e_fname, e_post, date_of_birth, e_phone, e_address FROM employees WHERE e_lname LIKE'%" + txtSearch.Text + "%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                frm.Clear();
                frm.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.surname = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.name = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.post = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.birth_date = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.phone = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                frm.address = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                frm.UpdateInfo();
                frm.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Ви впевнені, що хочете видалити запис?", "Кондитерська", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    EmployeesSettings emSet = new EmployeesSettings(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), null, null, null, null);
                    DBEmployees empl = new DBEmployees();
                    empl.checkEmplExistsInUsers(emSet);
                    if (empl.checkerUserExists)
                    {
                        DBEmployees.deleteEmployee(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                        Display();
                        dataGridView.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Неможливо видалити працівника!", "Кондитерська", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                return;
            }
        }
    }
}
