using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_system
{
    public partial class Staff : Form
    {
        int rowindex;
        int StaffCellID;
        SqlClass sql = new SqlClass();
        string SearchFilter = "firstName";

        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM staff_information";
            dataGridView1.DataSource = sql.GetStaffData(query);
        }


        public void SelctedStaffRow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                rowindex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                StaffCellID = (int)row.Cells[0].Value;
            }
        }
        public void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            string SrhTxt = SearchTxtBox.Text;
            string query = $@"Select * from staff_information where {SearchFilter} like '{SrhTxt}%'";
            dataGridView1.DataSource = sql.GetStaffData(query);
        }
        public void StaffColumnCombobox_SelectedIndexChanged(object sender, EventArgs args)
        {
            SearchFilter = ColumnCombobox.SelectedItem.ToString();
        }


        private void StaffClosedEvent(object sender, FormClosedEventArgs e)
        {
            Staff_Load(sender, e);
        }


        public void NewStaffBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("New Is Click");
            AddStaff addstaff = new AddStaff();
            addstaff.FormClosed += StaffClosedEvent;
            addstaff.ShowDialog();
        }
        public void EditStaffBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[rowindex];
            EditStaff editStaffform = new EditStaff(row);
            editStaffform.FormClosed += StaffClosedEvent;
            editStaffform.ShowDialog();
        }
        public void DeleteStaffBtn_Click(object sender, EventArgs e)
        {
            string query = $@"DELETE from staff_information where id = {StaffCellID};";
            sql.ExcuteQuery(query);
            Staff_Load(sender, e);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm(dataGridView1);
            report.ShowDialog();
        }
    }
}
