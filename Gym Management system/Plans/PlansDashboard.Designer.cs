using System.Runtime.CompilerServices;

namespace Gym_Management_system
{
    partial class PlansDashboard
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            S_EtimeResult = new Label();
            TphoneResult = new Label();
            PlanNameResult = new Label();
            TrainerResult = new Label();
            label7 = new Label();
            SignUpFeeResult = new Label();
            label6 = new Label();
            PlanTypeResult = new Label();
            label5 = new Label();
            PriceResult = new Label();
            AddPlan = new FontAwesome.Sharp.IconButton();
            EditPlan = new FontAwesome.Sharp.IconButton();
            DeletePlan = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            PlansComboBox = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            ReportBtn = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 53);
            label1.TabIndex = 0;
            label1.Text = "Plan Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(207, 53);
            label2.TabIndex = 1;
            label2.Text = "Price";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(623, 0);
            label3.Name = "label3";
            label3.Size = new Size(354, 53);
            label3.TabIndex = 2;
            label3.Text = "Plan Type";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(623, 53);
            label4.Name = "label4";
            label4.Size = new Size(354, 53);
            label4.TabIndex = 3;
            label4.Text = "SignUp Fee";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.3570061F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.643F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 337F));
            tableLayoutPanel1.Controls.Add(S_EtimeResult, 1, 2);
            tableLayoutPanel1.Controls.Add(TphoneResult, 1, 3);
            tableLayoutPanel1.Controls.Add(PlanNameResult, 1, 0);
            tableLayoutPanel1.Controls.Add(TrainerResult, 3, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(SignUpFeeResult, 3, 1);
            tableLayoutPanel1.Controls.Add(label6, 2, 2);
            tableLayoutPanel1.Controls.Add(PlanTypeResult, 3, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(PriceResult, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.Size = new Size(1318, 206);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // S_EtimeResult
            // 
            S_EtimeResult.AutoSize = true;
            S_EtimeResult.Dock = DockStyle.Fill;
            S_EtimeResult.Location = new Point(216, 106);
            S_EtimeResult.Name = "S_EtimeResult";
            S_EtimeResult.Size = new Size(401, 47);
            S_EtimeResult.TabIndex = 9;
            S_EtimeResult.Text = "...";
            S_EtimeResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TphoneResult
            // 
            TphoneResult.AutoSize = true;
            TphoneResult.Dock = DockStyle.Fill;
            TphoneResult.Location = new Point(216, 153);
            TphoneResult.Name = "TphoneResult";
            TphoneResult.Size = new Size(401, 53);
            TphoneResult.TabIndex = 13;
            TphoneResult.Text = "...";
            TphoneResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PlanNameResult
            // 
            PlanNameResult.AutoSize = true;
            PlanNameResult.Dock = DockStyle.Fill;
            PlanNameResult.Location = new Point(216, 0);
            PlanNameResult.Name = "PlanNameResult";
            PlanNameResult.Size = new Size(401, 53);
            PlanNameResult.TabIndex = 9;
            PlanNameResult.Text = "...";
            PlanNameResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TrainerResult
            // 
            TrainerResult.AutoSize = true;
            TrainerResult.Dock = DockStyle.Fill;
            TrainerResult.Location = new Point(983, 106);
            TrainerResult.Name = "TrainerResult";
            TrainerResult.Size = new Size(332, 47);
            TrainerResult.TabIndex = 12;
            TrainerResult.Text = "...";
            TrainerResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 153);
            label7.Name = "label7";
            label7.Size = new Size(207, 53);
            label7.TabIndex = 5;
            label7.Text = "Trainer Phone";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SignUpFeeResult
            // 
            SignUpFeeResult.AutoSize = true;
            SignUpFeeResult.Dock = DockStyle.Fill;
            SignUpFeeResult.Location = new Point(983, 53);
            SignUpFeeResult.Name = "SignUpFeeResult";
            SignUpFeeResult.Size = new Size(332, 53);
            SignUpFeeResult.TabIndex = 11;
            SignUpFeeResult.Text = "...";
            SignUpFeeResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(623, 106);
            label6.Name = "label6";
            label6.Size = new Size(354, 47);
            label6.TabIndex = 5;
            label6.Text = "Trainer";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PlanTypeResult
            // 
            PlanTypeResult.AutoSize = true;
            PlanTypeResult.Dock = DockStyle.Fill;
            PlanTypeResult.Location = new Point(983, 0);
            PlanTypeResult.Name = "PlanTypeResult";
            PlanTypeResult.Size = new Size(332, 53);
            PlanTypeResult.TabIndex = 10;
            PlanTypeResult.Text = "...";
            PlanTypeResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 106);
            label5.Name = "label5";
            label5.Size = new Size(207, 47);
            label5.TabIndex = 5;
            label5.Text = "Start-End Time";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PriceResult
            // 
            PriceResult.AutoSize = true;
            PriceResult.Dock = DockStyle.Fill;
            PriceResult.Location = new Point(216, 53);
            PriceResult.Name = "PriceResult";
            PriceResult.Size = new Size(401, 53);
            PriceResult.TabIndex = 9;
            PriceResult.Text = "...";
            PriceResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddPlan
            // 
            AddPlan.AutoSize = true;
            AddPlan.IconChar = FontAwesome.Sharp.IconChar.Add;
            AddPlan.IconColor = Color.Black;
            AddPlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddPlan.IconSize = 35;
            AddPlan.Location = new Point(1099, 229);
            AddPlan.Margin = new Padding(0);
            AddPlan.Name = "AddPlan";
            AddPlan.Padding = new Padding(0, 4, 0, 0);
            AddPlan.Size = new Size(206, 58);
            AddPlan.TabIndex = 5;
            AddPlan.TextAlign = ContentAlignment.BottomCenter;
            AddPlan.UseVisualStyleBackColor = true;
            AddPlan.Click += AddPlan_Click;
            // 
            // EditPlan
            // 
            EditPlan.AutoSize = true;
            EditPlan.IconChar = FontAwesome.Sharp.IconChar.Pen;
            EditPlan.IconColor = Color.Black;
            EditPlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditPlan.IconSize = 35;
            EditPlan.Location = new Point(878, 229);
            EditPlan.Margin = new Padding(0);
            EditPlan.Name = "EditPlan";
            EditPlan.Padding = new Padding(0, 4, 0, 0);
            EditPlan.Size = new Size(206, 58);
            EditPlan.TabIndex = 6;
            EditPlan.TextAlign = ContentAlignment.BottomCenter;
            EditPlan.UseVisualStyleBackColor = true;
            EditPlan.Click += EditPlan_Click;
            // 
            // DeletePlan
            // 
            DeletePlan.AutoSize = true;
            DeletePlan.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            DeletePlan.IconColor = Color.Black;
            DeletePlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeletePlan.IconSize = 35;
            DeletePlan.Location = new Point(655, 229);
            DeletePlan.Margin = new Padding(0);
            DeletePlan.Name = "DeletePlan";
            DeletePlan.Padding = new Padding(0, 4, 0, 0);
            DeletePlan.Size = new Size(206, 58);
            DeletePlan.TabIndex = 7;
            DeletePlan.TextAlign = ContentAlignment.BottomCenter;
            DeletePlan.UseVisualStyleBackColor = true;
            DeletePlan.Click += DeletePlan_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(PlansComboBox);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(DeletePlan);
            panel1.Controls.Add(AddPlan);
            panel1.Controls.Add(EditPlan);
            panel1.Location = new Point(23, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1318, 330);
            panel1.TabIndex = 8;
            // 
            // PlansComboBox
            // 
            PlansComboBox.AutoResize = false;
            PlansComboBox.BackColor = Color.FromArgb(255, 255, 255);
            PlansComboBox.Depth = 0;
            PlansComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            PlansComboBox.DropDownHeight = 174;
            PlansComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PlansComboBox.DropDownWidth = 121;
            PlansComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            PlansComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            PlansComboBox.FormattingEnabled = true;
            PlansComboBox.Hint = "Choose A Plan";
            PlansComboBox.IntegralHeight = false;
            PlansComboBox.ItemHeight = 43;
            PlansComboBox.Location = new Point(12, 238);
            PlansComboBox.MaxDropDownItems = 4;
            PlansComboBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            PlansComboBox.Name = "PlansComboBox";
            PlansComboBox.Size = new Size(242, 49);
            PlansComboBox.StartIndex = 0;
            PlansComboBox.TabIndex = 9;
            PlansComboBox.SelectedIndexChanged += PlansComboBox_SelectedIndexChanged;
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
            ReportBtn.Location = new Point(23, 662);
            ReportBtn.Name = "ReportBtn";
            ReportBtn.Size = new Size(112, 54);
            ReportBtn.TabIndex = 12;
            ReportBtn.Text = "Report";
            ReportBtn.UseVisualStyleBackColor = false;
            ReportBtn.Click += ReportBtn_Click;
            // 
            // PlansDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(245, 243, 244);
            ClientSize = new Size(1382, 728);
            Controls.Add(ReportBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlansDashboard";
            FormClosed += PlansClosedEvent;
            Load += Plans_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label6;
        private Label label7;
        public FontAwesome.Sharp.IconButton AddPlan;
        public FontAwesome.Sharp.IconButton EditPlan;
        public FontAwesome.Sharp.IconButton DeletePlan;
        private Panel panel1;
        public MaterialSkin2DotNet.Controls.MaterialComboBox PlansComboBox;
        public Label PlanNameResult;
        public Label PriceResult;
        public Label PlanTypeResult;
        public Label SignUpFeeResult;
        public Label TrainerResult;
        public Label TphoneResult;
        public Label S_EtimeResult;
        private FontAwesome.Sharp.IconButton ReportBtn;
    }
}
