using System.ComponentModel;
using MaterialSkin2DotNet.Animations;
using MaterialSkin2DotNet;
using System.Data;
using MaterialSkin2DotNet.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Gym_Management_system.Salary;
using Gym_Management_system.Schedules;

namespace Gym_Management_system
{

    public partial class MainForm : Form
    {
        //fields
        Dictionary<string, List<object>>? plansdata = new Dictionary<string, List<object>>();
        SqlClass sql = new SqlClass();

        //userInfo
        string Username;
        string UserType;
        int UserId;
        //default search filter
        string SearchFilter = "firstName";

        public MainForm(string Username, string UserType, int Userid)
        {
            InitializeComponent();
            timer1.Start();

            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightGreen400, TextShade.BLACK);



            this.Username = Username;
            this.UserType = UserType;
            this.UserId = Userid;

            plansdata = sql.getPlansDshBdData() ?? null;
            UserNameLbl.Text = Username;

            if (UserType == "SuperAdmin")
            {

            }
            else
            {
                StaffBtn.Enabled = false;
                StaffBtn.BackColor = Color.FromArgb(51, 60, 67);
            }
        }


        //Switch btw Forms
        public void Switcher(object Form)
        {
            if (this.DisplayPanel.Controls.Count > 0)
            {
                this.DisplayPanel.Controls.RemoveAt(0);
            }

            Form Wform = Form as Form;
            Wform.TopLevel = false;
            Wform.Dock = DockStyle.Fill;
            this.DisplayPanel.Controls.Add(Wform);
            this.DisplayPanel.Tag = Wform;
            Wform.Show();
        }


        //############################################################################
        //Add load Functions to their associted tab
        //Duplicate errors
        //############################################################################


        // Tabs
        //22, 26, 29
        //private void Dashboard_Click(object sender, EventArgs e) => Switcher(new DashboardForm());

        private void RemoveActiveColor()
        {
            System.Collections.IList list = this.flowLayoutBtn.Controls;
            for (int i = 1; i < list.Count; i++)
            {
                FontAwesome.Sharp.IconButton item = (FontAwesome.Sharp.IconButton)list[i];
                if (item.GetType().ToString() == "FontAwesome.Sharp.IconButton")
                {
                    item.BackColor = Color.FromArgb(22, 26, 29);
                    item.ForeColor = Color.White;
                    item.IconColor = Color.White;
                }
            }
        }

        private void ActiveTab(FontAwesome.Sharp.IconButton control)
        {
            control.BackColor = Color.FromArgb(245, 243, 244);
            control.ForeColor = Color.Black;
            control.IconColor = Color.Black;
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            RemoveActiveColor();
            Switcher(new DashboardForm());
            ActiveTab(Dashboard);
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            RemoveActiveColor();
            Switcher(new Attendance());
            ActiveTab(Attendance);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            RemoveActiveColor();
            Switcher(new DashboardForm());
            ActiveTab(Dashboard);
        }
        private void PlansBtn_Click(object sender, EventArgs e)
        {
            RemoveActiveColor();
            Switcher(new PlansDashboard(ref plansdata));
            ActiveTab(PlansBtn);
        }
        private void StaffBtn_Click(object sender, EventArgs e)
        {
            RemoveActiveColor();
            Switcher(new Staff());
            ActiveTab(StaffBtn);
        }
        private void financial_Click(object sender, EventArgs e)
        {
            RemoveActiveColor();
            Switcher(new Financial(UserId));
            ActiveTab(financialBtn);
        }
        private void MemberShips_Click(object sender, EventArgs e)
        {
            RemoveActiveColor();
            Switcher(new Memberships(plansdata));
            ActiveTab(MemberShips);
        }
        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            RemoveActiveColor();
            Switcher(new Schedule());
            ActiveTab(ScheduleBtn);
        }

        private void Reporttab_Click(object sender, EventArgs e)
        {
            
        }





        //Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            Timerlabel.Text = DateTime.Now.ToString("hh:mm tt");
        }

        //Close Window
        private void iconButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
