namespace Gym_Management_system
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            butto = new Button();
            button1 = new Button();
            label1 = new Label();
            textBoxUserName = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            textBoxPassword = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            UsernameErrorCheck = new Label();
            PasswordErrorCheck = new Label();
            SuspendLayout();
            // 
            // butto
            // 
            butto.BackColor = Color.FromArgb(192, 0, 0);
            butto.FlatAppearance.BorderSize = 0;
            butto.FlatStyle = FlatStyle.Flat;
            butto.Font = new Font("LEMON MILK Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            butto.ForeColor = Color.White;
            butto.Location = new Point(174, 628);
            butto.Margin = new Padding(4);
            butto.Name = "butto";
            butto.Size = new Size(465, 60);
            butto.TabIndex = 2;
            butto.Text = "Login";
            butto.UseVisualStyleBackColor = false;
            butto.Click += butto_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(584, 527);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(44, 38);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Open Sans Extrabold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(174, 310);
            label1.Name = "label1";
            label1.Size = new Size(164, 65);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // textBoxUserName
            // 
            textBoxUserName.AnimateReadOnly = false;
            textBoxUserName.AutoCompleteMode = AutoCompleteMode.None;
            textBoxUserName.AutoCompleteSource = AutoCompleteSource.None;
            textBoxUserName.BackgroundImageLayout = ImageLayout.None;
            textBoxUserName.CharacterCasing = CharacterCasing.Normal;
            textBoxUserName.Depth = 0;
            textBoxUserName.ErrorMessage = "Username is required\"";
            textBoxUserName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxUserName.HelperText = "Your Username";
            textBoxUserName.HideSelection = true;
            textBoxUserName.Hint = "Username";
            textBoxUserName.LeadingIcon = null;
            textBoxUserName.Location = new Point(174, 416);
            textBoxUserName.MaxLength = 32767;
            textBoxUserName.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PasswordChar = '\0';
            textBoxUserName.PrefixSuffixText = null;
            textBoxUserName.ReadOnly = false;
            textBoxUserName.RightToLeft = RightToLeft.No;
            textBoxUserName.SelectedText = "";
            textBoxUserName.SelectionLength = 0;
            textBoxUserName.SelectionStart = 0;
            textBoxUserName.ShortcutsEnabled = true;
            textBoxUserName.Size = new Size(465, 48);
            textBoxUserName.TabIndex = 5;
            textBoxUserName.TabStop = false;
            textBoxUserName.TextAlign = HorizontalAlignment.Left;
            textBoxUserName.TrailingIcon = null;
            textBoxUserName.UseSystemPasswordChar = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.AnimateReadOnly = false;
            textBoxPassword.AutoCompleteMode = AutoCompleteMode.None;
            textBoxPassword.AutoCompleteSource = AutoCompleteSource.None;
            textBoxPassword.BackgroundImageLayout = ImageLayout.None;
            textBoxPassword.CharacterCasing = CharacterCasing.Normal;
            textBoxPassword.Depth = 0;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxPassword.HideSelection = true;
            textBoxPassword.Hint = "Password";
            textBoxPassword.LeadingIcon = null;
            textBoxPassword.Location = new Point(174, 522);
            textBoxPassword.MaxLength = 32767;
            textBoxPassword.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.PrefixSuffixText = null;
            textBoxPassword.ReadOnly = false;
            textBoxPassword.RightToLeft = RightToLeft.No;
            textBoxPassword.SelectedText = "";
            textBoxPassword.SelectionLength = 0;
            textBoxPassword.SelectionStart = 0;
            textBoxPassword.ShortcutsEnabled = true;
            textBoxPassword.Size = new Size(465, 48);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.TabStop = false;
            textBoxPassword.TextAlign = HorizontalAlignment.Left;
            textBoxPassword.TrailingIcon = null;
            textBoxPassword.UseAccent = false;
            textBoxPassword.UseSystemPasswordChar = false;
            // 
            // UsernameErrorCheck
            // 
            UsernameErrorCheck.AutoSize = true;
            UsernameErrorCheck.Location = new Point(174, 467);
            UsernameErrorCheck.Name = "UsernameErrorCheck";
            UsernameErrorCheck.Size = new Size(0, 25);
            UsernameErrorCheck.TabIndex = 7;
            // 
            // PasswordErrorCheck
            // 
            PasswordErrorCheck.AutoSize = true;
            PasswordErrorCheck.Location = new Point(174, 573);
            PasswordErrorCheck.Name = "PasswordErrorCheck";
            PasswordErrorCheck.Size = new Size(0, 25);
            PasswordErrorCheck.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1599, 1001);
            Controls.Add(PasswordErrorCheck);
            Controls.Add(UsernameErrorCheck);
            Controls.Add(textBoxUserName);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(butto);
            Controls.Add(textBoxPassword);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button butto;
        private Button button1;
        private Label label1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 textBoxUserName;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 textBoxPassword;
        private Label UsernameErrorCheck;
        private Label PasswordErrorCheck;
    }
}