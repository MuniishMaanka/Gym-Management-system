using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gym_Management_system
{
    public partial class EditStaff : Form
    {
        string? FirstName;
        string? LastName;
        string? Dob;
        string? Tell;
        string? Email;
        string? Sex;
        string? City;
        string? Village;
        string? Em_Contact;
        string? Em_Tell;
        string? Em_Relation;
        string? Shift;
        string? Staff_type;
        float Salary;
        int StaffId;
        

        SqlClass sqlclass = new SqlClass();

        public EditStaff(DataGridViewRow row)
        {
            InitializeComponent();

            StaffId = (int)row.Cells[0].Value;
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
            ShiftComboBox.SelectedItem = row.Cells[12].Value.ToString();
            StaffTypeComboBox.SelectedItem = row.Cells[13].Value.ToString();
            SalaryTextBox.Text = row.Cells[14].Value.ToString();
        }


        private void EditStaffBtn_Click(object sender, EventArgs e)
        {
            

            string query = $@"UPDATE  staff_information
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
                                shift = '{ShiftComboBox.SelectedItem}',
                                staff_type = '{StaffTypeComboBox.SelectedItem}',
                                salary = {Convert.ToSingle(SalaryTextBox.Text)}
	                            WHERE id = {StaffId};";

            sqlclass.ExcuteQuery(query);
        }

    }
}
