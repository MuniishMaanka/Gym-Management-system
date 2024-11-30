namespace Gym_Management_system
{
    partial class Attendance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ViewThisMonth = new FontAwesome.Sharp.IconButton();
            ViewToDay = new FontAwesome.Sharp.IconButton();
            ReportBtn = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            AttSearch_TxtBox = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            CheckedInBtn = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            AttendanceGridView = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AttendanceGridView).BeginInit();
            SuspendLayout();
            // 
            // ViewThisMonth
            // 
            ViewThisMonth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewThisMonth.FlatAppearance.BorderSize = 0;
            ViewThisMonth.FlatStyle = FlatStyle.Flat;
            ViewThisMonth.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            ViewThisMonth.IconColor = Color.Black;
            ViewThisMonth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ViewThisMonth.Location = new Point(1389, 29);
            ViewThisMonth.Name = "ViewThisMonth";
            ViewThisMonth.Size = new Size(62, 48);
            ViewThisMonth.TabIndex = 3;
            ViewThisMonth.UseVisualStyleBackColor = true;
            ViewThisMonth.Click += ViewThisMonth_Click;
            // 
            // ViewToDay
            // 
            ViewToDay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewToDay.FlatAppearance.BorderSize = 0;
            ViewToDay.FlatStyle = FlatStyle.Flat;
            ViewToDay.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            ViewToDay.IconColor = Color.Black;
            ViewToDay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ViewToDay.Location = new Point(1321, 28);
            ViewToDay.Name = "ViewToDay";
            ViewToDay.Size = new Size(62, 48);
            ViewToDay.TabIndex = 4;
            ViewToDay.UseVisualStyleBackColor = true;
            ViewToDay.Click += ViewToDay_Click;
            // 
            // ReportBtn
            // 
            ReportBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ReportBtn.AutoSize = true;
            ReportBtn.BackColor = Color.FromArgb(255, 64, 129);
            ReportBtn.FlatAppearance.BorderSize = 0;
            ReportBtn.FlatStyle = FlatStyle.Flat;
            ReportBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReportBtn.ForeColor = Color.White;
            ReportBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            ReportBtn.IconColor = Color.Black;
            ReportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ReportBtn.Location = new Point(10, 772);
            ReportBtn.Name = "ReportBtn";
            ReportBtn.Size = new Size(112, 54);
            ReportBtn.TabIndex = 11;
            ReportBtn.Text = "Report";
            ReportBtn.UseVisualStyleBackColor = false;
            ReportBtn.Click += ReportBtn_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(AttSearch_TxtBox);
            panel2.Controls.Add(CheckedInBtn);
            panel2.Location = new Point(10, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(1431, 77);
            panel2.TabIndex = 10;
            // 
            // AttSearch_TxtBox
            // 
            AttSearch_TxtBox.AllowPromptAsInput = true;
            AttSearch_TxtBox.AnimateReadOnly = false;
            AttSearch_TxtBox.AsciiOnly = false;
            AttSearch_TxtBox.BackgroundImageLayout = ImageLayout.None;
            AttSearch_TxtBox.BeepOnError = false;
            AttSearch_TxtBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            AttSearch_TxtBox.Depth = 0;
            AttSearch_TxtBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            AttSearch_TxtBox.HidePromptOnLeave = false;
            AttSearch_TxtBox.HideSelection = true;
            AttSearch_TxtBox.Hint = "Member ID";
            AttSearch_TxtBox.InsertKeyMode = InsertKeyMode.Default;
            AttSearch_TxtBox.LeadingIcon = null;
            AttSearch_TxtBox.Location = new Point(16, 13);
            AttSearch_TxtBox.Mask = "";
            AttSearch_TxtBox.MaxLength = 32767;
            AttSearch_TxtBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            AttSearch_TxtBox.Name = "AttSearch_TxtBox";
            AttSearch_TxtBox.PasswordChar = '\0';
            AttSearch_TxtBox.PrefixSuffixText = null;
            AttSearch_TxtBox.PromptChar = '_';
            AttSearch_TxtBox.ReadOnly = false;
            AttSearch_TxtBox.RejectInputOnFirstFailure = false;
            AttSearch_TxtBox.ResetOnPrompt = true;
            AttSearch_TxtBox.ResetOnSpace = true;
            AttSearch_TxtBox.RightToLeft = RightToLeft.No;
            AttSearch_TxtBox.SelectedText = "";
            AttSearch_TxtBox.SelectionLength = 0;
            AttSearch_TxtBox.SelectionStart = 0;
            AttSearch_TxtBox.ShortcutsEnabled = true;
            AttSearch_TxtBox.Size = new Size(328, 48);
            AttSearch_TxtBox.SkipLiterals = true;
            AttSearch_TxtBox.TabIndex = 10;
            AttSearch_TxtBox.TabStop = false;
            AttSearch_TxtBox.TextAlign = HorizontalAlignment.Left;
            AttSearch_TxtBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            AttSearch_TxtBox.TrailingIcon = null;
            AttSearch_TxtBox.UseSystemPasswordChar = false;
            AttSearch_TxtBox.ValidatingType = null;
            AttSearch_TxtBox.TextChanged += AttSearch_TxtBox_TextChanged;
            // 
            // CheckedInBtn
            // 
            CheckedInBtn.Depth = 0;
            CheckedInBtn.Icon = Properties.Resources.pngegg__2_;
            CheckedInBtn.Location = new Point(362, 9);
            CheckedInBtn.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            CheckedInBtn.Name = "CheckedInBtn";
            CheckedInBtn.Size = new Size(59, 58);
            CheckedInBtn.TabIndex = 9;
            CheckedInBtn.Text = "materialFloatingActionButton2";
            CheckedInBtn.UseVisualStyleBackColor = true;
            CheckedInBtn.Click += CheckedInBtn_Click;
            // 
            // AttendanceGridView
            // 
            AttendanceGridView.AllowUserToAddRows = false;
            AttendanceGridView.AllowUserToDeleteRows = false;
            AttendanceGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AttendanceGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AttendanceGridView.BackgroundColor = Color.White;
            AttendanceGridView.BorderStyle = BorderStyle.Fixed3D;
            AttendanceGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            AttendanceGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            AttendanceGridView.ColumnHeadersHeight = 32;
            AttendanceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AttendanceGridView.Location = new Point(10, 179);
            AttendanceGridView.Name = "AttendanceGridView";
            AttendanceGridView.ReadOnly = true;
            AttendanceGridView.RowHeadersWidth = 80;
            AttendanceGridView.Size = new Size(1431, 587);
            AttendanceGridView.TabIndex = 1;
            AttendanceGridView.CellClick += SelctedMemberRow;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1451, 836);
            Controls.Add(AttendanceGridView);
            Controls.Add(ReportBtn);
            Controls.Add(panel2);
            Controls.Add(ViewToDay);
            Controls.Add(ViewThisMonth);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Attendance";
            Padding = new Padding(10);
            Load += attendance_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AttendanceGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public FontAwesome.Sharp.IconButton ViewThisMonth;
        public FontAwesome.Sharp.IconButton ViewToDay;
        private FontAwesome.Sharp.IconButton ReportBtn;
        private Panel panel2;
        public MaterialSkin2DotNet.Controls.MaterialMaskedTextBox AttSearch_TxtBox;
        public MaterialSkin2DotNet.Controls.MaterialFloatingActionButton CheckedInBtn;
        public DataGridView AttendanceGridView;
    }
}
