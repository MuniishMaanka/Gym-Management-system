using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gym_Management_system
{
    public partial class EditMember : Form
    {
        string FirstName;
        string LastName;
        string Dob;
        string Tell;
        string Email;
        string Sex;
        string City;
        float Weight;
        string Village;
        string Em_Contact;
        string Em_Tell;
        string Em_Relation;
        int PlanId;

        SqlClass sqlClass = new SqlClass();
        //memberid
        int Memberid;


        //plandata list of plans
        Dictionary<string, List<object>>? PlanData;



        public EditMember(DataGridViewRow row, Dictionary<string, List<object>>? PlanData)
        {
            InitializeComponent();
            Memberid = (int)row.Cells[0].Value;

            this.PlanData = PlanData;

            int rowid = (int)row.Cells[13].Value;
            string planName = "";

            //Add plan name to comobox
            foreach (List<object> value in PlanData.Values)
            {
                PlansComboBox.Items.Add(value[0]);

                if ((int)value[9] == rowid)
                {
                    planName = value[0].ToString();
                    PlanId = rowid;
                }
            }

            FirstNameTextBox.Text = row.Cells[1].Value.ToString();
            LastNameTextBox.Text = row.Cells[2].Value.ToString();
            dateTimePicker1.Text = row.Cells[3].Value.ToString();
            TellTxtBox.Text = row.Cells[4].Value.ToString();
            EmailTextBox.Text = row.Cells[5].Value.ToString();
            SexComboBox.SelectedItem = row.Cells[6].Value.ToString();
            CityTextBox.Text = row.Cells[7].Value.ToString();
            VillageTextBox.Text = row.Cells[8].Value.ToString();
            ContactTellTextBox.Text = row.Cells[9].Value.ToString();
            ContactTextBox.Text = row.Cells[10].Value.ToString();
            RelationComboBox.SelectedItem = row.Cells[11].Value.ToString();
            WeightTextBox.Text = row.Cells[12].Value.ToString();
            PlansComboBox.SelectedItem = planName;
        }




        //Events
        private void PlansComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlanId = (int)PlanData[PlansComboBox.SelectedItem.ToString()][9];
            Console.WriteLine(PlanId);
            Console.WriteLine(PlansComboBox.SelectedItem.ToString());
            Console.WriteLine(PlanData[PlansComboBox.SelectedItem.ToString()][9]);
        }


        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
            string query = $@"UPDATE Customer_info
                            SET firstname = '{FirstNameTextBox.Text}',
                                lastname = '{LastNameTextBox.Text}',
                                dob = '{dateTimePicker1.Text}',
                                tell = '{TellTxtBox.Text}',
                                email = '{EmailTextBox.Text}',
                                sex = '{SexComboBox.SelectedItem}',
                                city = '{CityTextBox.Text}',
                                village = '{VillageTextBox.Text}',
                                emergency_contact = '{ContactTellTextBox.Text}',
                                emergency_name = '{ContactTextBox.Text}',
                                emergency_relation = '{RelationComboBox.SelectedItem}',
                                weight = {Convert.ToSingle(WeightTextBox.Text)},
                                planId = {PlanId}
                                where id = {Memberid}";

            Console.WriteLine(query);
            MessageBox.Show(sqlClass.ExcuteQuery(query));
        }

        
    }
}
