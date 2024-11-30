namespace Gym_Management_system
{
    partial class AddPlanForm
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
            label3 = new Label();
            label7 = new Label();
            PlanNameTxtBox = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            PriceTxtBox = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            SignUPFeeTxtBox = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            panel1 = new Panel();
            AddNewPlan = new FontAwesome.Sharp.IconButton();
            PlanTypeList = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            TrainerList = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            TimeOut = new DateTimePicker();
            TimeIn = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 315);
            label3.Name = "label3";
            label3.Size = new Size(82, 27);
            label3.TabIndex = 2;
            label3.Text = "Time-In";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Open Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(336, 315);
            label7.Name = "label7";
            label7.Size = new Size(99, 27);
            label7.TabIndex = 6;
            label7.Text = "Time-Out";
            // 
            // PlanNameTxtBox
            // 
            PlanNameTxtBox.AllowPromptAsInput = true;
            PlanNameTxtBox.AnimateReadOnly = false;
            PlanNameTxtBox.AsciiOnly = false;
            PlanNameTxtBox.BackgroundImageLayout = ImageLayout.None;
            PlanNameTxtBox.BeepOnError = false;
            PlanNameTxtBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            PlanNameTxtBox.Depth = 0;
            PlanNameTxtBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PlanNameTxtBox.HidePromptOnLeave = false;
            PlanNameTxtBox.HideSelection = true;
            PlanNameTxtBox.Hint = "Plan Name";
            PlanNameTxtBox.InsertKeyMode = InsertKeyMode.Default;
            PlanNameTxtBox.LeadingIcon = null;
            PlanNameTxtBox.LeaveOnEnterKey = true;
            PlanNameTxtBox.Location = new Point(83, 72);
            PlanNameTxtBox.Mask = "";
            PlanNameTxtBox.MaxLength = 32767;
            PlanNameTxtBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            PlanNameTxtBox.Name = "PlanNameTxtBox";
            PlanNameTxtBox.PasswordChar = '\0';
            PlanNameTxtBox.PrefixSuffixText = null;
            PlanNameTxtBox.PromptChar = '_';
            PlanNameTxtBox.ReadOnly = false;
            PlanNameTxtBox.RejectInputOnFirstFailure = false;
            PlanNameTxtBox.ResetOnPrompt = true;
            PlanNameTxtBox.ResetOnSpace = true;
            PlanNameTxtBox.RightToLeft = RightToLeft.No;
            PlanNameTxtBox.SelectedText = "";
            PlanNameTxtBox.SelectionLength = 0;
            PlanNameTxtBox.SelectionStart = 0;
            PlanNameTxtBox.ShortcutsEnabled = true;
            PlanNameTxtBox.Size = new Size(406, 48);
            PlanNameTxtBox.SkipLiterals = true;
            PlanNameTxtBox.TabIndex = 7;
            PlanNameTxtBox.TabStop = false;
            PlanNameTxtBox.TextAlign = HorizontalAlignment.Left;
            PlanNameTxtBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            PlanNameTxtBox.TrailingIcon = null;
            PlanNameTxtBox.UseSystemPasswordChar = false;
            PlanNameTxtBox.ValidatingType = null;
            PlanNameTxtBox.TextChanged += PlanNameTxtBox_TextChange;
            // 
            // PriceTxtBox
            // 
            PriceTxtBox.AllowPromptAsInput = true;
            PriceTxtBox.AnimateReadOnly = false;
            PriceTxtBox.AsciiOnly = false;
            PriceTxtBox.BackgroundImageLayout = ImageLayout.None;
            PriceTxtBox.BeepOnError = false;
            PriceTxtBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            PriceTxtBox.Depth = 0;
            PriceTxtBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PriceTxtBox.HidePromptOnLeave = false;
            PriceTxtBox.HideSelection = true;
            PriceTxtBox.Hint = "Price";
            PriceTxtBox.InsertKeyMode = InsertKeyMode.Default;
            PriceTxtBox.LeadingIcon = null;
            PriceTxtBox.Location = new Point(83, 154);
            PriceTxtBox.Mask = "";
            PriceTxtBox.MaxLength = 32767;
            PriceTxtBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            PriceTxtBox.Name = "PriceTxtBox";
            PriceTxtBox.PasswordChar = '\0';
            PriceTxtBox.PrefixSuffix = MaterialSkin2DotNet.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            PriceTxtBox.PrefixSuffixText = "$";
            PriceTxtBox.PromptChar = '_';
            PriceTxtBox.ReadOnly = false;
            PriceTxtBox.RejectInputOnFirstFailure = false;
            PriceTxtBox.ResetOnPrompt = true;
            PriceTxtBox.ResetOnSpace = true;
            PriceTxtBox.RightToLeft = RightToLeft.No;
            PriceTxtBox.SelectedText = "";
            PriceTxtBox.SelectionLength = 0;
            PriceTxtBox.SelectionStart = 0;
            PriceTxtBox.ShortcutsEnabled = true;
            PriceTxtBox.Size = new Size(153, 48);
            PriceTxtBox.SkipLiterals = true;
            PriceTxtBox.TabIndex = 8;
            PriceTxtBox.TabStop = false;
            PriceTxtBox.TextAlign = HorizontalAlignment.Left;
            PriceTxtBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            PriceTxtBox.TrailingIcon = null;
            PriceTxtBox.UseSystemPasswordChar = false;
            PriceTxtBox.ValidatingType = null;
            PriceTxtBox.Click += PriceTxtBox_Click;
            PriceTxtBox.TextChanged += PriceTxtBox_TextChange;
            // 
            // SignUPFeeTxtBox
            // 
            SignUPFeeTxtBox.AllowPromptAsInput = true;
            SignUPFeeTxtBox.AnimateReadOnly = false;
            SignUPFeeTxtBox.AsciiOnly = false;
            SignUPFeeTxtBox.BackgroundImageLayout = ImageLayout.None;
            SignUPFeeTxtBox.BeepOnError = false;
            SignUPFeeTxtBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            SignUPFeeTxtBox.Depth = 0;
            SignUPFeeTxtBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SignUPFeeTxtBox.HidePromptOnLeave = false;
            SignUPFeeTxtBox.HideSelection = true;
            SignUPFeeTxtBox.Hint = "Sign Up Fee";
            SignUPFeeTxtBox.InsertKeyMode = InsertKeyMode.Default;
            SignUPFeeTxtBox.LeadingIcon = null;
            SignUPFeeTxtBox.Location = new Point(336, 154);
            SignUPFeeTxtBox.Mask = "";
            SignUPFeeTxtBox.MaxLength = 32767;
            SignUPFeeTxtBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            SignUPFeeTxtBox.Name = "SignUPFeeTxtBox";
            SignUPFeeTxtBox.PasswordChar = '\0';
            SignUPFeeTxtBox.PrefixSuffix = MaterialSkin2DotNet.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            SignUPFeeTxtBox.PrefixSuffixText = "$";
            SignUPFeeTxtBox.PromptChar = '_';
            SignUPFeeTxtBox.ReadOnly = false;
            SignUPFeeTxtBox.RejectInputOnFirstFailure = false;
            SignUPFeeTxtBox.ResetOnPrompt = true;
            SignUPFeeTxtBox.ResetOnSpace = true;
            SignUPFeeTxtBox.RightToLeft = RightToLeft.No;
            SignUPFeeTxtBox.SelectedText = "";
            SignUPFeeTxtBox.SelectionLength = 0;
            SignUPFeeTxtBox.SelectionStart = 0;
            SignUPFeeTxtBox.ShortcutsEnabled = true;
            SignUPFeeTxtBox.Size = new Size(153, 48);
            SignUPFeeTxtBox.SkipLiterals = true;
            SignUPFeeTxtBox.TabIndex = 9;
            SignUPFeeTxtBox.TabStop = false;
            SignUPFeeTxtBox.TextAlign = HorizontalAlignment.Left;
            SignUPFeeTxtBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            SignUPFeeTxtBox.TrailingIcon = null;
            SignUPFeeTxtBox.UseSystemPasswordChar = false;
            SignUPFeeTxtBox.ValidatingType = null;
            SignUPFeeTxtBox.TextChanged += SignUPFeeTxtBox_TextChange;
            // 
            // panel1
            // 
            panel1.Controls.Add(AddNewPlan);
            panel1.Controls.Add(PlanTypeList);
            panel1.Controls.Add(TrainerList);
            panel1.Controls.Add(TimeOut);
            panel1.Controls.Add(TimeIn);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(SignUPFeeTxtBox);
            panel1.Controls.Add(PlanNameTxtBox);
            panel1.Controls.Add(PriceTxtBox);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 507);
            panel1.TabIndex = 10;
            // 
            // AddNewPlan
            // 
            AddNewPlan.Dock = DockStyle.Bottom;
            AddNewPlan.Font = new Font("Open Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            AddNewPlan.IconChar = FontAwesome.Sharp.IconChar.None;
            AddNewPlan.IconColor = Color.Black;
            AddNewPlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddNewPlan.Location = new Point(0, 447);
            AddNewPlan.Name = "AddNewPlan";
            AddNewPlan.Size = new Size(562, 60);
            AddNewPlan.TabIndex = 13;
            AddNewPlan.Text = "Add";
            AddNewPlan.UseVisualStyleBackColor = true;
            AddNewPlan.Click += AddNewPlan_Click;
            // 
            // PlanTypeList
            // 
            PlanTypeList.AutoResize = false;
            PlanTypeList.BackColor = Color.FromArgb(255, 255, 255);
            PlanTypeList.Depth = 0;
            PlanTypeList.DrawMode = DrawMode.OwnerDrawVariable;
            PlanTypeList.DropDownHeight = 174;
            PlanTypeList.DropDownStyle = ComboBoxStyle.DropDownList;
            PlanTypeList.DropDownWidth = 121;
            PlanTypeList.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            PlanTypeList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            PlanTypeList.FormattingEnabled = true;
            PlanTypeList.Hint = "Plan-Type";
            PlanTypeList.IntegralHeight = false;
            PlanTypeList.ItemHeight = 43;
            PlanTypeList.Items.AddRange(new object[] { "Day", "Evening", "Night" });
            PlanTypeList.Location = new Point(336, 235);
            PlanTypeList.MaxDropDownItems = 4;
            PlanTypeList.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            PlanTypeList.Name = "PlanTypeList";
            PlanTypeList.Size = new Size(153, 49);
            PlanTypeList.StartIndex = 0;
            PlanTypeList.TabIndex = 12;
            PlanTypeList.SelectedIndexChanged += PlanTypeList_SelectedIndexChanged;
            // 
            // TrainerList
            // 
            TrainerList.AutoResize = false;
            TrainerList.BackColor = Color.FromArgb(255, 255, 255);
            TrainerList.Depth = 0;
            TrainerList.DrawMode = DrawMode.OwnerDrawVariable;
            TrainerList.DropDownHeight = 174;
            TrainerList.DropDownStyle = ComboBoxStyle.DropDownList;
            TrainerList.DropDownWidth = 121;
            TrainerList.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            TrainerList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            TrainerList.FormattingEnabled = true;
            TrainerList.Hint = "Trainer";
            TrainerList.IntegralHeight = false;
            TrainerList.ItemHeight = 43;
            TrainerList.Location = new Point(83, 236);
            TrainerList.MaxDropDownItems = 4;
            TrainerList.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TrainerList.Name = "TrainerList";
            TrainerList.Size = new Size(153, 49);
            TrainerList.StartIndex = 0;
            TrainerList.TabIndex = 11;
            TrainerList.SelectedIndexChanged += TrainerList_SelectedIndexChanged;
            // 
            // TimeOut
            // 
            TimeOut.CustomFormat = "HH:mm";
            TimeOut.Format = DateTimePickerFormat.Time;
            TimeOut.Location = new Point(336, 354);
            TimeOut.Name = "TimeOut";
            TimeOut.Size = new Size(132, 31);
            TimeOut.TabIndex = 11;
            TimeOut.ValueChanged += TimeOut_ValueChanged;
            // 
            // TimeIn
            // 
            TimeIn.CustomFormat = "HH:mm";
            TimeIn.Format = DateTimePickerFormat.Time;
            TimeIn.Location = new Point(83, 354);
            TimeIn.Name = "TimeIn";
            TimeIn.Size = new Size(132, 31);
            TimeIn.TabIndex = 10;
            TimeIn.ValueChanged += TimeIn_ValueChanged;
            // 
            // AddPlanForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 507);
            Controls.Add(panel1);
            Name = "AddPlanForm";
            Text = "AddPlanForm";
            Load += AddPlanForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label7;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox PlanNameTxtBox;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox PriceTxtBox;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox SignUPFeeTxtBox;
        private Panel panel1;
        private DateTimePicker TimeIn;
        private DateTimePicker TimeOut;
        private MaterialSkin2DotNet.Controls.MaterialComboBox PlanTypeList;
        private MaterialSkin2DotNet.Controls.MaterialComboBox TrainerList;
        private FontAwesome.Sharp.IconButton AddNewPlan;
    }
}