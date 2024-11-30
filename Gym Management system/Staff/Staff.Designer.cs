namespace Gym_Management_system
{
    partial class Staff
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
            dataGridView1 = new DataGridView();
            NewStaffBtn = new FontAwesome.Sharp.IconButton();
            SearchTxtBox = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            ColumnCombobox = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            EditStaffBtn = new FontAwesome.Sharp.IconButton();
            DeleteStaffBtn = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            ReportBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1563, 656);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += SelctedStaffRow;
            // 
            // NewStaffBtn
            // 
            NewStaffBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            NewStaffBtn.IconColor = Color.Black;
            NewStaffBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NewStaffBtn.Location = new Point(572, 3);
            NewStaffBtn.Name = "NewStaffBtn";
            NewStaffBtn.Size = new Size(107, 55);
            NewStaffBtn.TabIndex = 2;
            NewStaffBtn.TextAlign = ContentAlignment.MiddleRight;
            NewStaffBtn.UseVisualStyleBackColor = true;
            NewStaffBtn.Click += NewStaffBtn_Click;
            // 
            // SearchTxtBox
            // 
            SearchTxtBox.AllowPromptAsInput = true;
            SearchTxtBox.AnimateReadOnly = false;
            SearchTxtBox.AsciiOnly = false;
            SearchTxtBox.BackgroundImageLayout = ImageLayout.None;
            SearchTxtBox.BeepOnError = false;
            SearchTxtBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            SearchTxtBox.Depth = 0;
            SearchTxtBox.Font = new Font("Open Sans Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTxtBox.HidePromptOnLeave = false;
            SearchTxtBox.HideSelection = true;
            SearchTxtBox.Hint = "Search";
            SearchTxtBox.InsertKeyMode = InsertKeyMode.Default;
            SearchTxtBox.LeadingIcon = null;
            SearchTxtBox.Location = new Point(3, 3);
            SearchTxtBox.Mask = "";
            SearchTxtBox.MaxLength = 32767;
            SearchTxtBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            SearchTxtBox.Name = "SearchTxtBox";
            SearchTxtBox.PasswordChar = '\0';
            SearchTxtBox.PrefixSuffixText = null;
            SearchTxtBox.PromptChar = '_';
            SearchTxtBox.ReadOnly = false;
            SearchTxtBox.RejectInputOnFirstFailure = false;
            SearchTxtBox.ResetOnPrompt = true;
            SearchTxtBox.ResetOnSpace = true;
            SearchTxtBox.RightToLeft = RightToLeft.No;
            SearchTxtBox.SelectedText = "";
            SearchTxtBox.SelectionLength = 0;
            SearchTxtBox.SelectionStart = 0;
            SearchTxtBox.ShortcutsEnabled = true;
            SearchTxtBox.Size = new Size(375, 48);
            SearchTxtBox.SkipLiterals = true;
            SearchTxtBox.TabIndex = 5;
            SearchTxtBox.TabStop = false;
            SearchTxtBox.TextAlign = HorizontalAlignment.Left;
            SearchTxtBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            SearchTxtBox.TrailingIcon = null;
            SearchTxtBox.UseSystemPasswordChar = false;
            SearchTxtBox.ValidatingType = null;
            SearchTxtBox.TextChanged += SearchTxtBox_TextChanged;
            // 
            // ColumnCombobox
            // 
            ColumnCombobox.AutoResize = false;
            ColumnCombobox.BackColor = Color.FromArgb(255, 255, 255);
            ColumnCombobox.Depth = 0;
            ColumnCombobox.DrawMode = DrawMode.OwnerDrawVariable;
            ColumnCombobox.DropDownHeight = 174;
            ColumnCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            ColumnCombobox.DropDownWidth = 121;
            ColumnCombobox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ColumnCombobox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ColumnCombobox.FormattingEnabled = true;
            ColumnCombobox.IntegralHeight = false;
            ColumnCombobox.ItemHeight = 43;
            ColumnCombobox.Items.AddRange(new object[] { "firstname", "lastname", "dob", "tell", "email", "sex", "city", "village", "emmergence_contact", "emmergency_name", "emergency_relation", "shift", "staff_type", "salary" });
            ColumnCombobox.Location = new Point(384, 3);
            ColumnCombobox.MaxDropDownItems = 4;
            ColumnCombobox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            ColumnCombobox.Name = "ColumnCombobox";
            ColumnCombobox.Size = new Size(182, 49);
            ColumnCombobox.StartIndex = 0;
            ColumnCombobox.TabIndex = 6;
            ColumnCombobox.SelectedIndexChanged += StaffColumnCombobox_SelectedIndexChanged;
            // 
            // EditStaffBtn
            // 
            EditStaffBtn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            EditStaffBtn.IconColor = Color.Black;
            EditStaffBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditStaffBtn.Location = new Point(685, 3);
            EditStaffBtn.Name = "EditStaffBtn";
            EditStaffBtn.Size = new Size(107, 55);
            EditStaffBtn.TabIndex = 7;
            EditStaffBtn.UseVisualStyleBackColor = true;
            EditStaffBtn.Click += EditStaffBtn_Click;
            // 
            // DeleteStaffBtn
            // 
            DeleteStaffBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            DeleteStaffBtn.IconColor = Color.Black;
            DeleteStaffBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteStaffBtn.Location = new Point(798, 3);
            DeleteStaffBtn.Name = "DeleteStaffBtn";
            DeleteStaffBtn.Size = new Size(107, 55);
            DeleteStaffBtn.TabIndex = 8;
            DeleteStaffBtn.TextAlign = ContentAlignment.MiddleRight;
            DeleteStaffBtn.UseVisualStyleBackColor = true;
            DeleteStaffBtn.Click += DeleteStaffBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(SearchTxtBox);
            flowLayoutPanel1.Controls.Add(ColumnCombobox);
            flowLayoutPanel1.Controls.Add(NewStaffBtn);
            flowLayoutPanel1.Controls.Add(EditStaffBtn);
            flowLayoutPanel1.Controls.Add(DeleteStaffBtn);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(10, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1563, 76);
            flowLayoutPanel1.TabIndex = 9;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(10, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(1563, 656);
            panel1.TabIndex = 10;
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
            ReportBtn.Location = new Point(13, 760);
            ReportBtn.Name = "ReportBtn";
            ReportBtn.Size = new Size(112, 54);
            ReportBtn.TabIndex = 12;
            ReportBtn.Text = "Report";
            ReportBtn.UseVisualStyleBackColor = false;
            ReportBtn.Click += ReportBtn_Click;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 243, 244);
            ClientSize = new Size(1583, 827);
            Controls.Add(ReportBtn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff";
            Padding = new Padding(10);
            FormClosed += StaffClosedEvent;
            Load += Staff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridView1;
        public FontAwesome.Sharp.IconButton NewStaffBtn;
        public MaterialSkin2DotNet.Controls.MaterialMaskedTextBox SearchTxtBox;
        public MaterialSkin2DotNet.Controls.MaterialComboBox ColumnCombobox;
        public FontAwesome.Sharp.IconButton EditStaffBtn;
        public FontAwesome.Sharp.IconButton DeleteStaffBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton ReportBtn;
    }
}
