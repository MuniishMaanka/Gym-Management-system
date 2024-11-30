namespace Gym_Management_system
{
    partial class ReportForm
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
            button1 = new Button();
            FileName = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            FileTitle = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 64, 129);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(32, 246);
            button1.Name = "button1";
            button1.Size = new Size(174, 53);
            button1.TabIndex = 1;
            button1.Text = "Create Report";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FileName
            // 
            FileName.AnimateReadOnly = false;
            FileName.AutoCompleteMode = AutoCompleteMode.None;
            FileName.AutoCompleteSource = AutoCompleteSource.None;
            FileName.BackgroundImageLayout = ImageLayout.None;
            FileName.CharacterCasing = CharacterCasing.Normal;
            FileName.Depth = 0;
            FileName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            FileName.HideSelection = true;
            FileName.Hint = "File Name";
            FileName.LeadingIcon = null;
            FileName.Location = new Point(32, 59);
            FileName.MaxLength = 32767;
            FileName.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            FileName.Name = "FileName";
            FileName.PasswordChar = '\0';
            FileName.PrefixSuffixText = null;
            FileName.ReadOnly = false;
            FileName.RightToLeft = RightToLeft.No;
            FileName.SelectedText = "";
            FileName.SelectionLength = 0;
            FileName.SelectionStart = 0;
            FileName.ShortcutsEnabled = true;
            FileName.Size = new Size(375, 48);
            FileName.TabIndex = 2;
            FileName.TabStop = false;
            FileName.TextAlign = HorizontalAlignment.Left;
            FileName.TrailingIcon = null;
            FileName.UseSystemPasswordChar = false;
            FileName.TextChanged += FileName_TextChanged;
            // 
            // FileTitle
            // 
            FileTitle.AnimateReadOnly = false;
            FileTitle.AutoCompleteMode = AutoCompleteMode.None;
            FileTitle.AutoCompleteSource = AutoCompleteSource.None;
            FileTitle.BackgroundImageLayout = ImageLayout.None;
            FileTitle.CharacterCasing = CharacterCasing.Normal;
            FileTitle.Depth = 0;
            FileTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            FileTitle.HideSelection = true;
            FileTitle.Hint = "ReportTitle";
            FileTitle.LeadingIcon = null;
            FileTitle.Location = new Point(32, 122);
            FileTitle.MaxLength = 32767;
            FileTitle.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            FileTitle.Name = "FileTitle";
            FileTitle.PasswordChar = '\0';
            FileTitle.PrefixSuffixText = null;
            FileTitle.ReadOnly = false;
            FileTitle.RightToLeft = RightToLeft.No;
            FileTitle.SelectedText = "";
            FileTitle.SelectionLength = 0;
            FileTitle.SelectionStart = 0;
            FileTitle.ShortcutsEnabled = true;
            FileTitle.Size = new Size(375, 48);
            FileTitle.TabIndex = 3;
            FileTitle.TabStop = false;
            FileTitle.TextAlign = HorizontalAlignment.Left;
            FileTitle.TrailingIcon = null;
            FileTitle.UseSystemPasswordChar = false;
            FileTitle.TextChanged += FileTitle_textChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "landscape", "portrait" });
            comboBox1.Location = new Point(32, 186);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 4;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 344);
            Controls.Add(comboBox1);
            Controls.Add(FileTitle);
            Controls.Add(FileName);
            Controls.Add(button1);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ReportForm";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 FileName;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 FileTitle;
        private ComboBox comboBox1;
    }
}