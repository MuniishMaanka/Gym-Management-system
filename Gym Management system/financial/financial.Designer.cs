namespace Gym_Management_system.Salary
{
    partial class Financial
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
            panel2 = new Panel();
            MemPayed = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            PayedGrid = new DataGridView();
            NonPayedGrid = new DataGridView();
            label7 = new Label();
            label4 = new Label();
            l = new Label();
            ThisYearRev = new Label();
            label12 = new Label();
            ThisMonRev = new Label();
            label10 = new Label();
            TotalRevenue = new Label();
            label6 = new Label();
            panel1 = new Panel();
            ReportBtn = new FontAwesome.Sharp.IconButton();
            StaffIDcombobox = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            StaffExpenseBtn = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            Stafffinance = new DataGridView();
            label3 = new Label();
            ThisMonExp = new Label();
            label2 = new Label();
            label1 = new Label();
            ThisYearExp = new Label();
            label5 = new Label();
            ExpenseTotal = new Label();
            panel4 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PayedGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NonPayedGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Stafffinance).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(MemPayed);
            panel2.Controls.Add(PayedGrid);
            panel2.Controls.Add(NonPayedGrid);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(l);
            panel2.Controls.Add(ThisYearRev);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(ThisMonRev);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(TotalRevenue);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(17, 724);
            panel2.Name = "panel2";
            panel2.Size = new Size(1405, 697);
            panel2.TabIndex = 13;
            // 
            // MemPayed
            // 
            MemPayed.Depth = 0;
            MemPayed.Icon = Properties.Resources.dollar_sign_17027;
            MemPayed.Location = new Point(1314, 620);
            MemPayed.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            MemPayed.Name = "MemPayed";
            MemPayed.Size = new Size(62, 62);
            MemPayed.TabIndex = 27;
            MemPayed.Text = "materialFloatingActionButton1";
            MemPayed.UseVisualStyleBackColor = true;
            MemPayed.Click += MemPayed_Click;
            // 
            // PayedGrid
            // 
            PayedGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PayedGrid.BackgroundColor = Color.White;
            PayedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PayedGrid.Location = new Point(23, 235);
            PayedGrid.Name = "PayedGrid";
            PayedGrid.RowHeadersWidth = 62;
            PayedGrid.RowTemplate.Height = 33;
            PayedGrid.Size = new Size(657, 379);
            PayedGrid.TabIndex = 26;
            // 
            // NonPayedGrid
            // 
            NonPayedGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            NonPayedGrid.BackgroundColor = Color.White;
            NonPayedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NonPayedGrid.Location = new Point(734, 235);
            NonPayedGrid.Name = "NonPayedGrid";
            NonPayedGrid.RowHeadersWidth = 62;
            NonPayedGrid.RowTemplate.Height = 33;
            NonPayedGrid.Size = new Size(642, 379);
            NonPayedGrid.TabIndex = 25;
            NonPayedGrid.CellContentClick += NonPayedGrid_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Open Sans Extrabold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(734, 188);
            label7.Name = "label7";
            label7.Size = new Size(389, 43);
            label7.TabIndex = 23;
            label7.Text = "Non-Payed This Month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sans Extrabold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 188);
            label4.Name = "label4";
            label4.Size = new Size(311, 43);
            label4.TabIndex = 22;
            label4.Text = "Payed This Month";
            // 
            // l
            // 
            l.AutoSize = true;
            l.BackColor = Color.Transparent;
            l.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            l.ForeColor = Color.FromArgb(255, 64, 129);
            l.Location = new Point(724, 97);
            l.Name = "l";
            l.Size = new Size(116, 32);
            l.TabIndex = 17;
            l.Text = "This Year";
            // 
            // ThisYearRev
            // 
            ThisYearRev.Anchor = AnchorStyles.Right;
            ThisYearRev.BackColor = Color.Transparent;
            ThisYearRev.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ThisYearRev.ForeColor = SystemColors.ActiveCaptionText;
            ThisYearRev.Location = new Point(528, 81);
            ThisYearRev.Margin = new Padding(3, 15, 3, 8);
            ThisYearRev.Name = "ThisYearRev";
            ThisYearRev.Size = new Size(183, 58);
            ThisYearRev.TabIndex = 16;
            ThisYearRev.Text = "00";
            ThisYearRev.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(255, 64, 129);
            label12.Location = new Point(1050, 97);
            label12.Name = "label12";
            label12.Size = new Size(150, 32);
            label12.TabIndex = 21;
            label12.Text = "This Month ";
            // 
            // ThisMonRev
            // 
            ThisMonRev.Anchor = AnchorStyles.Right;
            ThisMonRev.BackColor = Color.Transparent;
            ThisMonRev.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ThisMonRev.ForeColor = SystemColors.ActiveCaptionText;
            ThisMonRev.Location = new Point(851, 81);
            ThisMonRev.Margin = new Padding(3, 15, 3, 8);
            ThisMonRev.Name = "ThisMonRev";
            ThisMonRev.Size = new Size(176, 58);
            ThisMonRev.TabIndex = 20;
            ThisMonRev.Text = "00";
            ThisMonRev.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(255, 64, 129);
            label10.Location = new Point(337, 97);
            label10.Name = "label10";
            label10.Size = new Size(174, 32);
            label10.TabIndex = 19;
            label10.Text = "Total Revenue";
            // 
            // TotalRevenue
            // 
            TotalRevenue.Anchor = AnchorStyles.Right;
            TotalRevenue.BackColor = Color.Transparent;
            TotalRevenue.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            TotalRevenue.ForeColor = SystemColors.ActiveCaptionText;
            TotalRevenue.Location = new Point(150, 76);
            TotalRevenue.Margin = new Padding(3, 15, 3, 8);
            TotalRevenue.Name = "TotalRevenue";
            TotalRevenue.Size = new Size(172, 63);
            TotalRevenue.TabIndex = 18;
            TotalRevenue.Text = "00";
            TotalRevenue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Open Sans Extrabold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(-1, 0);
            label6.Name = "label6";
            label6.Size = new Size(219, 55);
            label6.TabIndex = 16;
            label6.Text = "Members";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ReportBtn);
            panel1.Controls.Add(StaffIDcombobox);
            panel1.Controls.Add(StaffExpenseBtn);
            panel1.Controls.Add(Stafffinance);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ThisMonExp);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ThisYearExp);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ExpenseTotal);
            panel1.Location = new Point(22, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 647);
            panel1.TabIndex = 12;
            // 
            // ReportBtn
            // 
            ReportBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ReportBtn.AutoSize = true;
            ReportBtn.BackColor = Color.FromArgb(255, 64, 129);
            ReportBtn.FlatAppearance.BorderSize = 0;
            ReportBtn.FlatStyle = FlatStyle.Flat;
            ReportBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReportBtn.ForeColor = Color.White;
            ReportBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            ReportBtn.IconColor = Color.Black;
            ReportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ReportBtn.Location = new Point(18, 575);
            ReportBtn.Name = "ReportBtn";
            ReportBtn.Size = new Size(112, 54);
            ReportBtn.TabIndex = 16;
            ReportBtn.Text = "Report";
            ReportBtn.UseVisualStyleBackColor = false;
            ReportBtn.Click += ReportBtn_Click;
            // 
            // StaffIDcombobox
            // 
            StaffIDcombobox.AutoResize = false;
            StaffIDcombobox.BackColor = Color.FromArgb(255, 255, 255);
            StaffIDcombobox.Depth = 0;
            StaffIDcombobox.DrawMode = DrawMode.OwnerDrawVariable;
            StaffIDcombobox.DropDownHeight = 174;
            StaffIDcombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            StaffIDcombobox.DropDownWidth = 121;
            StaffIDcombobox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            StaffIDcombobox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            StaffIDcombobox.FormattingEnabled = true;
            StaffIDcombobox.Hint = "Staff Id";
            StaffIDcombobox.IntegralHeight = false;
            StaffIDcombobox.ItemHeight = 43;
            StaffIDcombobox.Location = new Point(1110, 567);
            StaffIDcombobox.MaxDropDownItems = 4;
            StaffIDcombobox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            StaffIDcombobox.Name = "StaffIDcombobox";
            StaffIDcombobox.Size = new Size(182, 49);
            StaffIDcombobox.StartIndex = 0;
            StaffIDcombobox.TabIndex = 19;
            StaffIDcombobox.SelectedIndexChanged += StaffIDcombobox_SelectedIndexChanged;
            // 
            // StaffExpenseBtn
            // 
            StaffExpenseBtn.Depth = 0;
            StaffExpenseBtn.Icon = Properties.Resources.dollar_sign_17027;
            StaffExpenseBtn.Location = new Point(1311, 567);
            StaffExpenseBtn.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            StaffExpenseBtn.Name = "StaffExpenseBtn";
            StaffExpenseBtn.Size = new Size(60, 62);
            StaffExpenseBtn.TabIndex = 18;
            StaffExpenseBtn.Text = "materialFloatingActionButton1";
            StaffExpenseBtn.UseVisualStyleBackColor = true;
            StaffExpenseBtn.Click += StaffExpenseBtn_Click;
            // 
            // Stafffinance
            // 
            Stafffinance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Stafffinance.BackgroundColor = Color.White;
            Stafffinance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Stafffinance.Location = new Point(18, 144);
            Stafffinance.Name = "Stafffinance";
            Stafffinance.RowHeadersWidth = 62;
            Stafffinance.RowTemplate.Height = 33;
            Stafffinance.Size = new Size(1367, 404);
            Stafffinance.TabIndex = 16;
            Stafffinance.CellContentClick += Stafffinance_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 64, 129);
            label3.Location = new Point(1043, 95);
            label3.Name = "label3";
            label3.Size = new Size(143, 32);
            label3.TabIndex = 15;
            label3.Text = "This Month";
            // 
            // ThisMonExp
            // 
            ThisMonExp.BackColor = Color.Transparent;
            ThisMonExp.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ThisMonExp.ForeColor = SystemColors.ActiveCaptionText;
            ThisMonExp.Location = new Point(860, 70);
            ThisMonExp.Margin = new Padding(3, 15, 3, 8);
            ThisMonExp.Name = "ThisMonExp";
            ThisMonExp.Size = new Size(175, 64);
            ThisMonExp.TabIndex = 14;
            ThisMonExp.Text = "00";
            ThisMonExp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans Extrabold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 55);
            label2.TabIndex = 13;
            label2.Text = "Staffs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 64, 129);
            label1.Location = new Point(713, 96);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 13;
            label1.Text = "This Year";
            // 
            // ThisYearExp
            // 
            ThisYearExp.BackColor = Color.Transparent;
            ThisYearExp.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ThisYearExp.ForeColor = SystemColors.ActiveCaptionText;
            ThisYearExp.Location = new Point(535, 73);
            ThisYearExp.Margin = new Padding(3, 15, 3, 8);
            ThisYearExp.Name = "ThisYearExp";
            ThisYearExp.Size = new Size(185, 60);
            ThisYearExp.TabIndex = 12;
            ThisYearExp.Text = "00";
            ThisYearExp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 64, 129);
            label5.Location = new Point(325, 95);
            label5.Name = "label5";
            label5.Size = new Size(177, 32);
            label5.TabIndex = 11;
            label5.Text = "Total Expense ";
            // 
            // ExpenseTotal
            // 
            ExpenseTotal.BackColor = Color.Transparent;
            ExpenseTotal.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ExpenseTotal.ForeColor = SystemColors.ActiveCaptionText;
            ExpenseTotal.Location = new Point(159, 73);
            ExpenseTotal.Margin = new Padding(3, 15, 3, 8);
            ExpenseTotal.Name = "ExpenseTotal";
            ExpenseTotal.Size = new Size(171, 61);
            ExpenseTotal.TabIndex = 10;
            ExpenseTotal.Text = "00";
            ExpenseTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.Location = new Point(12, 1369);
            panel4.Name = "panel4";
            panel4.Size = new Size(1423, 96);
            panel4.TabIndex = 15;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            iconButton1.AutoSize = true;
            iconButton1.BackColor = Color.FromArgb(255, 64, 129);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(23, 624);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(112, 54);
            iconButton1.TabIndex = 20;
            iconButton1.Text = "Report";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // Financial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1473, 1106);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Financial";
            Text = "financial";
            Load += Financial_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PayedGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)NonPayedGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Stafffinance).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        public Label l;
        public Label ThisYearRev;
        public Label label10;
        public Label TotalRevenue;
        private Label label6;
        public Label label12;
        public Label ThisMonRev;
        private Label label7;
        private Label label4;
        private Panel panel1;
        public Label label3;
        public Label ThisMonExp;
        private Label label2;
        public Label label1;
        public Label ThisYearExp;
        public Label label5;
        public Label ExpenseTotal;
        private DataGridView NonPayedGrid;
        private Panel panel3;
        private Label label11;
        public Label label15;
        public Label label16;
        private DataGridView PayedGrid;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton MemPayed;
        private DataGridView Stafffinance;
        private Panel panel4;
        private MaterialSkin2DotNet.Controls.MaterialComboBox StaffIDcombobox;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton StaffExpenseBtn;
        private FontAwesome.Sharp.IconButton ReportBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}