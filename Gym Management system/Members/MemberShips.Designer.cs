namespace Gym_Management_system
{
    partial class Memberships
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
            NewMemberBtn = new FontAwesome.Sharp.IconButton();
            SearchTxtBox = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            ColumnCombobox = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            EditMemberBtn = new FontAwesome.Sharp.IconButton();
            DeleteMemberBtn = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ReportBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1563, 621);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += SelctedMemberRow;
            // 
            // NewMemberBtn
            // 
            NewMemberBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            NewMemberBtn.IconColor = Color.Black;
            NewMemberBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NewMemberBtn.Location = new Point(572, 3);
            NewMemberBtn.Name = "NewMemberBtn";
            NewMemberBtn.Size = new Size(107, 55);
            NewMemberBtn.TabIndex = 2;
            NewMemberBtn.TextAlign = ContentAlignment.MiddleRight;
            NewMemberBtn.UseVisualStyleBackColor = true;
            NewMemberBtn.Click += NewMemberBtn_Click;
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
            SearchTxtBox.TextChanged += SearchTxtBox_Member;
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
            ColumnCombobox.SelectedIndexChanged += MemberColumnCombobox_SelectedIndexChanged;
            // 
            // EditMemberBtn
            // 
            EditMemberBtn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            EditMemberBtn.IconColor = Color.Black;
            EditMemberBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditMemberBtn.Location = new Point(685, 3);
            EditMemberBtn.Name = "EditMemberBtn";
            EditMemberBtn.Size = new Size(107, 55);
            EditMemberBtn.TabIndex = 7;
            EditMemberBtn.UseVisualStyleBackColor = true;
            EditMemberBtn.Click += EditMemberBtn_Click;
            // 
            // DeleteMemberBtn
            // 
            DeleteMemberBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            DeleteMemberBtn.IconColor = Color.Black;
            DeleteMemberBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteMemberBtn.Location = new Point(798, 3);
            DeleteMemberBtn.Name = "DeleteMemberBtn";
            DeleteMemberBtn.Size = new Size(107, 55);
            DeleteMemberBtn.TabIndex = 8;
            DeleteMemberBtn.TextAlign = ContentAlignment.MiddleRight;
            DeleteMemberBtn.UseVisualStyleBackColor = true;
            DeleteMemberBtn.Click += DeleteMemberBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(SearchTxtBox);
            flowLayoutPanel1.Controls.Add(ColumnCombobox);
            flowLayoutPanel1.Controls.Add(NewMemberBtn);
            flowLayoutPanel1.Controls.Add(EditMemberBtn);
            flowLayoutPanel1.Controls.Add(DeleteMemberBtn);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(10, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1563, 65);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // ReportBtn
            // 
            ReportBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ReportBtn.AutoSize = true;
            ReportBtn.BackColor = Color.FromArgb(255, 64, 129);
            ReportBtn.FlatAppearance.BorderSize = 0;
            ReportBtn.FlatStyle = FlatStyle.Flat;
            ReportBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReportBtn.ForeColor = Color.White;
            ReportBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            ReportBtn.IconColor = Color.Black;
            ReportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ReportBtn.Location = new Point(10, 708);
            ReportBtn.Name = "ReportBtn";
            ReportBtn.Size = new Size(112, 54);
            ReportBtn.TabIndex = 10;
            ReportBtn.Text = "Report";
            ReportBtn.UseVisualStyleBackColor = false;
            ReportBtn.Click += ReportBtn_Click;
            // 
            // Memberships
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 243, 244);
            ClientSize = new Size(1583, 785);
            Controls.Add(ReportBtn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Memberships";
            Padding = new Padding(10);
            FormClosed += MemberClosed;
            Load += memberships_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridView1;
        public FontAwesome.Sharp.IconButton NewMemberBtn;
        public MaterialSkin2DotNet.Controls.MaterialMaskedTextBox SearchTxtBox;
        public MaterialSkin2DotNet.Controls.MaterialComboBox ColumnCombobox;
        public FontAwesome.Sharp.IconButton EditMemberBtn;
        public FontAwesome.Sharp.IconButton DeleteMemberBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton ReportBtn;
    }
}
