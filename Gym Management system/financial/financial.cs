using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_system.Salary
{
    public partial class Financial : Form
    {
        SqlClass sql = new SqlClass();
        Dictionary<string, float> FinanceSummary = new Dictionary<string, float>();
        int UserId;
        int MemberId = 0;
        int rowindex;
        int staffId = 0;

        public Financial(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void Financial_Load(object sender, EventArgs e)
        {


            Dictionary<string, float> FinanceSummary = sql.FinanceSummary();

            ExpenseTotal.Text = FinanceSummary["TotalExp"].ToString() + "$";
            ThisMonExp.Text = FinanceSummary["MonExp"].ToString() + "$";
            ThisYearExp.Text = FinanceSummary["YearExp"].ToString() + "$";

            TotalRevenue.Text = FinanceSummary["TotalRev"].ToString() + "$";
            ThisMonRev.Text = FinanceSummary["MonRev"].ToString() + "$";
            ThisYearRev.Text = FinanceSummary["YearRev"].ToString() + "$";


            PayedGrid.DataSource = sql.PayedMember();
            NonPayedGrid.DataSource = sql.NonPayedMember();
            Stafffinance.DataSource = sql.StaffSalaryGrid();

            FillComboIds();

        }

        public void FillComboIds()
        {
            List<int> ids = sql.staffIds();
            foreach (int id in ids)
            {
                StaffIDcombobox.Items.Add(id);
            }
        }

        private void MemPayed_Click(object sender, EventArgs e)
        {
            if (MemberId != 0)
            {
                string query = @$"INSERT INTO revenue(customer_id, date_created, user_id)VALUES({MemberId}, date('now'), {UserId});";
                sql.ExcuteQuery(query);
            }
            else
            {
                MessageBox.Show("Select the Payed Member from the Non Payed table");
            }
        }

        private void NonPayedGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                rowindex = e.RowIndex;
                DataGridViewRow row = NonPayedGrid.Rows[e.RowIndex];
                MemberId = (int)row.Cells[2].Value;
            }
        }

        private void StaffExpenseBtn_Click(object sender, EventArgs e)
        {

            if (staffId != 0)
            {
                string query = @$"INSERT INTO salaries(staff_id, date_created)VALUES( {staffId},date('now'))";
                sql.ExcuteQuery(query);
            }
            else
            {
                MessageBox.Show("Select Staff from the Staff_Salary table");
            }
        }

        private void StaffIDcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            staffId = StaffIDcombobox.SelectedIndex;
        }

        private void Stafffinance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            ReportForm reportform = new ReportForm(Stafffinance);
            reportform.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<DataGridView> gridList = new List<DataGridView> { PayedGrid, NonPayedGrid };
            ReportForm reportform = new ReportForm(gridList);
            reportform.ShowDialog();
        }
    }
}
