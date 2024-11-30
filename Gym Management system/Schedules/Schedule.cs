using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_system.Schedules
{
    public partial class Schedule : Form
    {
        SqlClass sql = new SqlClass();
        public Schedule()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timerlabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            ScheduleGrid.DataSource = sql.SchedulesList();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(ScheduleGrid);
            reportForm.ShowDialog();
        }
    }
}
