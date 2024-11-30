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
    public partial class Attendance : Form
    {

        int memberId;
        SqlClass sql = new SqlClass();
        int rowindex;
        public Attendance()
        {
            InitializeComponent();
        }

        private void attendance_Load(object sender, EventArgs e)
        {
            AttendanceGridView.DataSource = sql.GetAttendance();
            AttendanceGridView.Columns["Attended"].ReadOnly = true;
        }


        //Events
        private void AttSearch_TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (AttSearch_TxtBox.Text != "")
            {

                if (int.TryParse(AttSearch_TxtBox.Text, out int parsed))
                {
                    memberId = parsed;
                    AttendanceGridView.DataSource = sql.checkAttended(memberId);
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                memberId = 0;
            }
        }

        public void SelctedMemberRow(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(memberId);
            if (e.RowIndex >= -1)
            {
                rowindex = e.RowIndex;
                DataGridViewRow row = AttendanceGridView.Rows[e.RowIndex];
                memberId = (int)row.Cells[0].Value;
            }
        }



        //Button
        private void CheckedInBtn_Click(object sender, EventArgs e)
        {
            if (memberId != 0)
            {
                sql.Attended(memberId);
            }
            else { MessageBox.Show("error "); }
            attendance_Load(sender, e);
        }

        //ViewThisMonth_Click
        private void ViewThisMonth_Click(object sender, EventArgs e)
        {
            Console.WriteLine(memberId);
            if (memberId != 0)
            {
                AttendanceGridView.DataSource = sql.ViewThisMonth(memberId);
            }
            else
            { MessageBox.Show("Select a member id to view this Month attendance", "Info"); }
        }

        //ViewToDay_Click
        private void ViewToDay_Click(object sender, EventArgs e) => attendance_Load(sender, e);

        //ReportBtn_Click
        private void ReportBtn_Click(object sender, EventArgs e)
        {
            ReportForm reportform = new ReportForm(AttendanceGridView);
            reportform.ShowDialog();
        }
    }
}
