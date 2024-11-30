using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gym_Management_system
{
    public partial class AddStaff : Form
    {
        string FirstName;
        string LastName;
        string Dob;
        string Tell;
        string Email;
        string Sex;
        string City;
        string Village;
        string Em_Contact;
        string Em_Tell;
        string Em_Relation;
        string Shift;
        string Staff_type;
        float Salary;

        SqlClass sqlclass = new SqlClass();

        public AddStaff()
        {
            InitializeComponent();
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
        private void SalaryTextBox_TextChanged(object sender, EventArgs args)
        {
            if (float.TryParse(SalaryTextBox.Text, out float parsed))
            {
                Salary = parsed;
            }
            else
            {
                SalaryTextBox.Text = string.Empty;
            }
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
        private void StaffTypeComboBox_TextChanged(object sender, EventArgs args)
        {
            Staff_type = StaffTypeComboBox.SelectedItem.ToString();
        }
        private void ShiftComboBox_TextChanged(object sender, EventArgs args)
        {
            Shift = ShiftComboBox.SelectedItem.ToString();
        }




        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(Dob);
            Console.WriteLine(Tell);
            Console.WriteLine(Email);
            Console.WriteLine(Sex);
            Console.WriteLine(City);
            Console.WriteLine(Village);
            Console.WriteLine(Em_Contact);
            Console.WriteLine(Em_Tell);
            Console.WriteLine(Em_Relation);
            Console.WriteLine(Shift);
            Console.WriteLine(Staff_type);
            Console.WriteLine(Salary);

            string query = $@"INSERT INTO staff_information (firstname, lastname, dob, tell, email, sex, city, village,
                                                            emergency_contact, emergency_name, emergency_relation,shift,
                                                            staff_type,salary)
                                                            VALUES('{FirstName}', '{LastName}', Date('{Dob}'), '{Tell}', '{Email}',
                                                                   '{Sex}', '{City}', '{Village}', '{Em_Contact}', '{Em_Tell}',
                                                                   '{Em_Relation}', '{Shift}', '{Staff_type}', {Salary});";
            // emmergence_contact
            sqlclass.ExcuteQuery(query);

        }
    }
}
