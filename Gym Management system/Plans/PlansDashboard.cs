using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Gym_Management_system
{
    public partial class PlansDashboard : Form
    {
        SqlClass sql = new SqlClass();
        Dictionary<string, List<object>>? plansdata = new Dictionary<string, List<object>>();
        List<string>? plansList = new List<string>();

        public PlansDashboard(ref Dictionary<string, List<object>>? plansdata)
        {
            InitializeComponent();
            this.plansdata = plansdata;
        }

        private void Plans_Load(object sender, EventArgs e)
        {
            plansList = sql.getPlans();
            if (plansList.Count != 0)
            {
                foreach (string s in plansList)
                {
                    PlansComboBox.Items.Add(s);
                }
            }
            else
            {
                PlansComboBox.Items.Add("No Plans");
                PlansComboBox.SelectedItem = "No Plans";
            }
        }



        // Events
        public void PlansComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)PlansComboBox.SelectedItem;
            if (plansdata.Count != 0)
            {
                PlanNameResult.Text = plansdata[selected][0].ToString();
                SignUpFeeResult.Text = plansdata[selected][1].ToString();
                PriceResult.Text = plansdata[selected][2].ToString();
                PlanTypeResult.Text = plansdata[selected][3].ToString();
                TrainerResult.Text = plansdata[selected][4].ToString();
                TphoneResult.Text = plansdata[selected][5].ToString();
                S_EtimeResult.Text = plansdata[selected][7].ToString() + " to " + plansdata[selected][8].ToString();
            }
        }

        private void PlansClosedEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Closed Add event");
            PlansComboBox.Items.Clear();
            plansdata = sql.getPlansDshBdData() ?? null;
            Plans_Load(sender, e);
        }


        public void AddPlan_Click(object sender, EventArgs e)
        {
            AddPlanForm addPlanForm = new AddPlanForm();
            addPlanForm.FormClosed += PlansClosedEvent;
            addPlanForm.ShowDialog();
        }
        public void DeletePlan_Click(object sender, EventArgs e)
        {
            string selected = (string)PlansComboBox.SelectedItem;
            string DeleteQuery = $@"DELETE from plans where plan_name = '{selected}';";
            sql.ExcuteQuery(DeleteQuery);
            PlansComboBox.Items.Remove(selected);
        }
        public void EditPlan_Click(object sender, EventArgs e)
        {
            string selected = (string)PlansComboBox.SelectedItem;
            //Console.WriteLine(plansdata[selected][1]);
            if (selected != null)
            {
                EditPlanForm editPlanForm = new EditPlanForm(plansdata[selected]);
                editPlanForm.FormClosed += PlansClosedEvent;
                editPlanForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select Plan");
            }
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            DataGridView PlanGrid = new DataGridView();
            PlanGrid.DataSource = sql.PlansReportList();

            if (PlanGrid.Columns.Count < 0)
            {
                Console.WriteLine("Failed");
            }
            else
            {
                ReportForm report = new ReportForm(PlanGrid);
                report.ShowDialog();
            }
        }
    }
}
