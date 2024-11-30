using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gym_Management_system
{
    public partial class AddMember : Form
    {
        string? FirstName;
        string? LastName;
        string? Dob;
        string? Tell;
        string? Email;
        string? Sex;
        string? City;
        float? Weight;
        string? Village;
        string? Em_Contact;
        string? Em_Tell;
        string? Em_Relation;
        int? PlanId;
        Dictionary<string, List<object>>? PlanData;
        


        SqlClass sqlClass = new SqlClass();

        public AddMember(Dictionary<string, List<object>>? PlanData)
        {
            InitializeComponent();
            this.PlanData = PlanData;

            foreach (List<object> value in PlanData.Values)
            {
                PlansComboBox.Items.Add(value[0]);
            }
            SexComboBox.Items.Add("Female");
            SexComboBox.Items.Add("Male");
        }



        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FirstName = FirstNameTextBox.Text;
        }

        private void LastNameText_TextChanged(object sender, EventArgs e)
        {
            LastName = LastNameTextBox.Text;
        }
        private void TellTxtBox_TextChanged(object sender, EventArgs e)
        {
            Tell = TellTxtBox.Text;
        }
        private void EmailTextBox_TextChanged(object sender, EventArgs args)
        {
            Email = EmailTextBox.Text;
        }

        private void CityText_TextChanged(object sender, EventArgs args)
        {
            City = CityTextBox.Text;
        }

        private void dateTimePicker1_TextChanged(object sender, EventArgs args)
        {
            Dob = dateTimePicker1.Text;
        }

        private void SexComboBox_TextChanged(object sender, EventArgs args)
        {
            Sex = SexComboBox.SelectedItem.ToString();
        }
        private void VillageTextBox_TextChanged(object sender, EventArgs args)
        {
            Village = VillageTextBox.Text;
        }
        private void ContactTextBox_TextChanged(object sender, EventArgs args)
        {
            Em_Contact = ContactTextBox.Text;
        }

        private void RelationComboBox_TextChanged(object sender, EventArgs args)
        {
            Em_Relation = RelationComboBox.SelectedItem.ToString();
        }
        private void ContactTellTextBox_TextChanged(object sender, EventArgs args)
        {
            Em_Tell = ContactTellTextBox.Text;
        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if(float.TryParse(WeightTextBox.Text, out float parsed))
            {
                Weight = parsed;
            } else
            {
                WeightTextBox.Text = string.Empty;
            }
        }
        private void PlansComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlanId = (int)PlanData[PlansComboBox.SelectedItem.ToString()][9];
        }


        private void AddStaffBtn_Click(object sender, EventArgs e)
        {

            if( string.IsNullOrEmpty(FirstName) ||
                string.IsNullOrEmpty(LastName) ||
                string.IsNullOrEmpty(Dob) ||
                string.IsNullOrEmpty(Tell) ||
                string.IsNullOrEmpty(Email) ||
                string.IsNullOrEmpty(Sex) ||
                string.IsNullOrEmpty(City) ||
                string.IsNullOrEmpty(Village) ||
                string.IsNullOrEmpty(Em_Contact) ||
                string.IsNullOrEmpty(Em_Tell) ||
                string.IsNullOrEmpty(Em_Relation) ||
                PlanId == null ||
                Weight == null )
            {
                MessageBox.Show("Fill All Fields");
                return;
            }

            string query = $@"INSERT into Customer_info(firstname, lastname, dob, Tell, email, sex, weight, city, village, emergency_contact, emergency_name, emergency_relation, planId)
              VALUES('{FirstName}','{LastName}',Date('{Dob}'),'{Tell}','{Email}','{Sex}',{Weight},'{City}','{Village}','{Em_Contact}','{Em_Tell}','{Em_Relation}',{PlanId});";
            

            
            MessageBox.Show(sqlClass.ExcuteQuery(query));


        }


    }
}
