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
    public partial class DashboardForm : Form
    {
        SqlClass sql = new SqlClass();
        //member ID
        int memberId = 0;
        Dictionary<string, List<object>>? plansdata = new Dictionary<string, List<object>>();



        public DashboardForm()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> counts = sql.dashboardSummary();

            TotalMember.Text = counts["Cus_Count"].ToString();
            StaffTotal.Text = counts["Stf_Count"].ToString();
            AttToday.Text = counts["today_Count"].ToString();

            //Attendance
            AttGridView.DataSource = sql.GetAttendLast10();
            DshSchGrid.DataSource = sql.SchedulesList();

        }



        private void dshSearch_TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (DshSearch_TxtBox.Text != "")
            {
                if (int.TryParse(DshSearch_TxtBox.Text, out int parsed))
                {
                    Console.WriteLine(memberId);
                    memberId = parsed;
                    AttGridView.DataSource = sql.checkAttended(memberId);
                    AttGridView.Columns["Attended"].ReadOnly = true;
                }
                else
                {
                    DshSearch_TxtBox.Text = "";
                }
            }
            else
            {
                AttGridView.DataSource = sql.GetAttendLast10();
                memberId = 0;
            }
        }




        //Buttons
        private void dshCheckedInBtn_Click(object sender, EventArgs e)
        {
            if (memberId != 0)
            {
                sql.Attended(memberId);
            }
            else { MessageBox.Show("error else"); }
            DshSearch_TxtBox.Clear();
            Dashboard_Load(sender, e);
        }

        //
        private void NewMemberBtn_Click(object sender, EventArgs e)
        {
            AddMember addmember = new AddMember(plansdata);
            addmember.ShowDialog();
        }

       
    }
}
