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
    public partial class Memberships : Form
    {
        int rowindex;
        int MemberCellID;
        string SearchFilter = "firstname";
        SqlClass sql = new SqlClass();
        Dictionary<string, List<object>>? plansdata = new Dictionary<string, List<object>>();

        public Memberships(Dictionary<string, List<object>>? plansdata)
        {
            InitializeComponent();
            this.plansdata = plansdata;
        }


        //Events
        //memberships_Load
        private void memberships_Load(object sender, EventArgs e)
        {
            string query = @"select * from Customer_info";
            dataGridView1.DataSource = sql.GetMembersData(query);
        }

        //MemberClosed
        public void MemberClosed(object sender, EventArgs e)
        {
            memberships_Load(sender, e);
        }

        //MemberColumnCombobox_SelectedIndexChanged
        public void MemberColumnCombobox_SelectedIndexChanged(object sender, EventArgs args)
        {
            SearchFilter = ColumnCombobox.SelectedItem.ToString();
        }

        //SelctedMemberRow
        public void SelctedMemberRow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                rowindex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                MemberCellID = (int)row.Cells[0].Value;
            }
        }

        //SearchTxtBox_Member
        public void SearchTxtBox_Member(object sender, EventArgs e)
        {

            string SrhTxt = SearchTxtBox.Text;
            string query = $@"Select * from Customer_info where {SearchFilter} like '{SrhTxt}%'";
            List<Database.MemberShipModal>? memberlist = sql.GetMembersData(query);
            if (memberlist is not null)
            {
                dataGridView1.DataSource = sql.GetMembersData(query);
            }
        }



        //Button
        //NewMemberBtn_Click
        public void NewMemberBtn_Click(object sender, EventArgs e)
        {
            AddMember addmember = new AddMember(plansdata);
            addmember.FormClosed += MemberClosed;
            addmember.ShowDialog();
        }

        //EditMemberBtn_Click
        public void EditMemberBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[rowindex];
            EditMember editMemberform = new EditMember(row, plansdata);
            editMemberform.FormClosed += MemberClosed;
            editMemberform.ShowDialog();
        }

        //DeleteMemberBtn_Click
        public void DeleteMemberBtn_Click(object sender, EventArgs e)
        {
            string query = $@"DELETE from Customer_info where id = {MemberCellID};";
            sql.ExcuteQuery(query);
            memberships_Load(sender, e);
        }

        //ReportBtn_Click
        private void ReportBtn_Click(object sender, EventArgs e)
        {
            ReportForm reportform = new ReportForm(dataGridView1);
            reportform.ShowDialog();
        }
    }
}
