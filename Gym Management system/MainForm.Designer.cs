using System.Runtime.CompilerServices;


namespace Gym_Management_system
{

    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Timerlabel = new Label();
            financialBtn = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            PlansBtn = new FontAwesome.Sharp.IconButton();
            MemberShips = new FontAwesome.Sharp.IconButton();
            StaffBtn = new FontAwesome.Sharp.IconButton();
            ScheduleBtn = new FontAwesome.Sharp.IconButton();
            Attendance = new FontAwesome.Sharp.IconButton();
            Dashboard = new FontAwesome.Sharp.IconButton();
            UserNameLbl = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            DisplayPanel = new Panel();
            flowLayoutBtn = new FlowLayoutPanel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            flowLayoutBtn.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Timerlabel
            // 
            Timerlabel.AutoSize = true;
            Timerlabel.Font = new Font("LEMON MILK Medium", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Timerlabel.ForeColor = SystemColors.Window;
            Timerlabel.Location = new Point(3, 120);
            Timerlabel.Name = "Timerlabel";
            Timerlabel.Size = new Size(140, 46);
            Timerlabel.TabIndex = 8;
            Timerlabel.Text = "label7";
            // 
            // financialBtn
            // 
            financialBtn.BackColor = Color.FromArgb(22, 26, 29);
            financialBtn.BackgroundImageLayout = ImageLayout.None;
            financialBtn.FlatAppearance.BorderSize = 0;
            financialBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 26, 29);
            financialBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            financialBtn.FlatStyle = FlatStyle.Flat;
            financialBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            financialBtn.ForeColor = Color.White;
            financialBtn.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            financialBtn.IconColor = Color.White;
            financialBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            financialBtn.ImageAlign = ContentAlignment.MiddleLeft;
            financialBtn.Location = new Point(6, 622);
            financialBtn.Margin = new Padding(6, 2, 6, 6);
            financialBtn.Name = "financialBtn";
            financialBtn.Padding = new Padding(9, 0, 0, 0);
            financialBtn.Size = new Size(346, 61);
            financialBtn.TabIndex = 8;
            financialBtn.Text = "Financial ";
            financialBtn.UseVisualStyleBackColor = false;
            financialBtn.Click += financial_Click;
            // 
            // iconButton8
            // 
            iconButton8.BackColor = Color.FromArgb(22, 26, 29);
            iconButton8.BackgroundImageLayout = ImageLayout.None;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 26, 29);
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton8.ForeColor = Color.White;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconButton8.IconColor = Color.White;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton8.Location = new Point(2, 691);
            iconButton8.Margin = new Padding(2);
            iconButton8.Name = "iconButton8";
            iconButton8.Padding = new Padding(9, 0, 0, 0);
            iconButton8.Size = new Size(346, 61);
            iconButton8.TabIndex = 7;
            iconButton8.Text = "LogOut";
            iconButton8.UseVisualStyleBackColor = false;
            iconButton8.Click += iconButton8_Click;
            // 
            // PlansBtn
            // 
            PlansBtn.BackColor = Color.FromArgb(22, 26, 29);
            PlansBtn.BackgroundImageLayout = ImageLayout.None;
            PlansBtn.FlatAppearance.BorderSize = 0;
            PlansBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 26, 29);
            PlansBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            PlansBtn.FlatStyle = FlatStyle.Flat;
            PlansBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlansBtn.ForeColor = Color.White;
            PlansBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            PlansBtn.IconColor = Color.White;
            PlansBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PlansBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PlansBtn.Location = new Point(6, 484);
            PlansBtn.Margin = new Padding(6);
            PlansBtn.Name = "PlansBtn";
            PlansBtn.Padding = new Padding(9, 0, 0, 0);
            PlansBtn.Size = new Size(346, 61);
            PlansBtn.TabIndex = 6;
            PlansBtn.Text = "Plans";
            PlansBtn.UseMnemonic = false;
            PlansBtn.UseVisualStyleBackColor = false;
            PlansBtn.Click += PlansBtn_Click;
            // 
            // MemberShips
            // 
            MemberShips.BackColor = Color.FromArgb(22, 26, 29);
            MemberShips.BackgroundImageLayout = ImageLayout.None;
            MemberShips.FlatAppearance.BorderSize = 0;
            MemberShips.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 26, 29);
            MemberShips.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            MemberShips.FlatStyle = FlatStyle.Flat;
            MemberShips.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MemberShips.ForeColor = Color.White;
            MemberShips.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            MemberShips.IconColor = Color.White;
            MemberShips.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MemberShips.ImageAlign = ContentAlignment.MiddleLeft;
            MemberShips.Location = new Point(6, 338);
            MemberShips.Margin = new Padding(6);
            MemberShips.Name = "MemberShips";
            MemberShips.Padding = new Padding(9, 0, 0, 0);
            MemberShips.Size = new Size(346, 61);
            MemberShips.TabIndex = 5;
            MemberShips.Text = "MemberShip";
            MemberShips.UseVisualStyleBackColor = false;
            MemberShips.Click += MemberShips_Click;
            // 
            // StaffBtn
            // 
            StaffBtn.BackColor = Color.FromArgb(22, 26, 29);
            StaffBtn.BackgroundImageLayout = ImageLayout.None;
            StaffBtn.FlatAppearance.BorderSize = 0;
            StaffBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 26, 29);
            StaffBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            StaffBtn.FlatStyle = FlatStyle.Flat;
            StaffBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StaffBtn.ForeColor = Color.White;
            StaffBtn.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            StaffBtn.IconColor = Color.White;
            StaffBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            StaffBtn.ImageAlign = ContentAlignment.MiddleLeft;
            StaffBtn.Location = new Point(6, 553);
            StaffBtn.Margin = new Padding(6, 2, 6, 6);
            StaffBtn.Name = "StaffBtn";
            StaffBtn.Padding = new Padding(9, 0, 0, 0);
            StaffBtn.Size = new Size(346, 61);
            StaffBtn.TabIndex = 5;
            StaffBtn.Text = "Staff";
            StaffBtn.UseVisualStyleBackColor = false;
            StaffBtn.Click += StaffBtn_Click;
            // 
            // ScheduleBtn
            // 
            ScheduleBtn.BackColor = Color.FromArgb(22, 26, 29);
            ScheduleBtn.BackgroundImageLayout = ImageLayout.None;
            ScheduleBtn.FlatAppearance.BorderSize = 0;
            ScheduleBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 26, 29);
            ScheduleBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            ScheduleBtn.FlatStyle = FlatStyle.Flat;
            ScheduleBtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ScheduleBtn.ForeColor = Color.White;
            ScheduleBtn.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            ScheduleBtn.IconColor = Color.White;
            ScheduleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ScheduleBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ScheduleBtn.Location = new Point(6, 411);
            ScheduleBtn.Margin = new Padding(6);
            ScheduleBtn.Name = "ScheduleBtn";
            ScheduleBtn.Padding = new Padding(9, 0, 0, 0);
            ScheduleBtn.Size = new Size(346, 61);
            ScheduleBtn.TabIndex = 4;
            ScheduleBtn.Text = "Schedules";
            ScheduleBtn.UseVisualStyleBackColor = false;
            ScheduleBtn.Click += ScheduleBtn_Click;
            // 
            // Attendance
            // 
            Attendance.BackColor = Color.FromArgb(22, 26, 29);
            Attendance.BackgroundImageLayout = ImageLayout.None;
            Attendance.FlatAppearance.BorderSize = 0;
            Attendance.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 26, 29);
            Attendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Attendance.FlatStyle = FlatStyle.Flat;
            Attendance.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Attendance.ForeColor = Color.White;
            Attendance.IconChar = FontAwesome.Sharp.IconChar.List;
            Attendance.IconColor = Color.White;
            Attendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Attendance.ImageAlign = ContentAlignment.MiddleLeft;
            Attendance.Location = new Point(6, 265);
            Attendance.Margin = new Padding(6);
            Attendance.Name = "Attendance";
            Attendance.Padding = new Padding(9, 0, 0, 0);
            Attendance.Size = new Size(346, 61);
            Attendance.TabIndex = 3;
            Attendance.Text = "Attendance";
            Attendance.UseVisualStyleBackColor = false;
            Attendance.Click += Attendance_Click;
            // 
            // Dashboard
            // 
            Dashboard.BackColor = Color.FromArgb(22, 26, 29);
            Dashboard.BackgroundImageLayout = ImageLayout.None;
            Dashboard.FlatAppearance.BorderSize = 0;
            Dashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 26, 29);
            Dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Dashboard.FlatStyle = FlatStyle.Flat;
            Dashboard.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Dashboard.ForeColor = Color.White;
            Dashboard.IconChar = FontAwesome.Sharp.IconChar.BorderAll;
            Dashboard.IconColor = Color.White;
            Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard.Location = new Point(6, 192);
            Dashboard.Margin = new Padding(6);
            Dashboard.Name = "Dashboard";
            Dashboard.Padding = new Padding(9, 0, 0, 0);
            Dashboard.Size = new Size(346, 61);
            Dashboard.TabIndex = 1;
            Dashboard.Text = "Dashboard";
            Dashboard.UseVisualStyleBackColor = false;
            Dashboard.Click += Dashboard_Click;
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.BackColor = Color.Transparent;
            UserNameLbl.Font = new Font("Open Sans", 11F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLbl.ForeColor = Color.White;
            UserNameLbl.Location = new Point(108, 31);
            UserNameLbl.Margin = new Padding(2, 0, 2, 0);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(126, 30);
            UserNameLbl.TabIndex = 2;
            UserNameLbl.Text = "Username";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(0, 0, 64);
            iconPictureBox1.BackgroundImage = (Image)resources.GetObject("iconPictureBox1.BackgroundImage");
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 85;
            iconPictureBox1.Location = new Point(3, 2);
            iconPictureBox1.Margin = new Padding(2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(90, 85);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // DisplayPanel
            // 
            DisplayPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPanel.Location = new Point(349, 10);
            DisplayPanel.Margin = new Padding(0, 3, 3, 3);
            DisplayPanel.Name = "DisplayPanel";
            DisplayPanel.Size = new Size(1454, 891);
            DisplayPanel.TabIndex = 6;
            DisplayPanel.Paint += DisplayPanel_Paint;
            // 
            // flowLayoutBtn
            // 
            flowLayoutBtn.Controls.Add(panel2);
            flowLayoutBtn.Controls.Add(Dashboard);
            flowLayoutBtn.Controls.Add(Attendance);
            flowLayoutBtn.Controls.Add(MemberShips);
            flowLayoutBtn.Controls.Add(ScheduleBtn);
            flowLayoutBtn.Controls.Add(PlansBtn);
            flowLayoutBtn.Controls.Add(StaffBtn);
            flowLayoutBtn.Controls.Add(financialBtn);
            flowLayoutBtn.Controls.Add(iconButton8);
            flowLayoutBtn.Dock = DockStyle.Left;
            flowLayoutBtn.FlowDirection = FlowDirection.TopDown;
            flowLayoutBtn.Location = new Point(10, 10);
            flowLayoutBtn.MaximumSize = new Size(345, 900);
            flowLayoutBtn.Name = "flowLayoutBtn";
            flowLayoutBtn.Size = new Size(336, 891);
            flowLayoutBtn.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(UserNameLbl);
            panel2.Controls.Add(Timerlabel);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 180);
            panel2.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 26, 29);
            ClientSize = new Size(1813, 911);
            Controls.Add(flowLayoutBtn);
            Controls.Add(DisplayPanel);
            Margin = new Padding(2);
            Name = "MainForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            flowLayoutBtn.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton Dashboard;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label UserNameLbl;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton PlansBtn;
        private FontAwesome.Sharp.IconButton MemberShips;
        private FontAwesome.Sharp.IconButton StaffBtn;
        private FontAwesome.Sharp.IconButton ScheduleBtn;
        private FontAwesome.Sharp.IconButton Attendance;
        private FontAwesome.Sharp.IconButton financialBtn;
        private System.Windows.Forms.Timer timer1;
        public Label Timerlabel;
        private Panel DisplayPanel;
        private FlowLayoutPanel flowLayoutBtn;
        private Panel panel2;
    }
}