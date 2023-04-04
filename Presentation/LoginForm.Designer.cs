namespace CopyBase
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.viewPassIcon = new System.Windows.Forms.PictureBox();
            this.loginButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.rememberMeCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.passwordTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.emailTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.incorrectLoginText = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPassIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.viewPassIcon);
            this.mainPanel.Controls.Add(this.loginButton);
            this.mainPanel.Controls.Add(this.rememberMeCheckBox);
            this.mainPanel.Controls.Add(this.passwordTextBox);
            this.mainPanel.Controls.Add(this.emailTextBox);
            this.mainPanel.Controls.Add(this.logoImage);
            this.mainPanel.Controls.Add(this.incorrectLoginText);
            this.mainPanel.Controls.Add(this.passwordLabel);
            this.mainPanel.Controls.Add(this.emailLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(403, 434);
            this.mainPanel.TabIndex = 0;
            // 
            // viewPassIcon
            // 
            this.viewPassIcon.BackColor = System.Drawing.Color.White;
            this.viewPassIcon.Image = global::CopyBase.Properties.Resources.view;
            this.viewPassIcon.Location = new System.Drawing.Point(344, 251);
            this.viewPassIcon.Margin = new System.Windows.Forms.Padding(5);
            this.viewPassIcon.Name = "viewPassIcon";
            this.viewPassIcon.Size = new System.Drawing.Size(20, 20);
            this.viewPassIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewPassIcon.TabIndex = 15;
            this.viewPassIcon.TabStop = false;
            this.viewPassIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewPassIcon_MouseDown);
            this.viewPassIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.viewPassIcon_MouseUp);
            // 
            // loginButton
            // 
            this.loginButton.BorderRadius = 8;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(27, 357);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(349, 50);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.Animated = true;
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.rememberMeCheckBox.CheckedState.BorderRadius = 2;
            this.rememberMeCheckBox.CheckedState.BorderThickness = 1;
            this.rememberMeCheckBox.CheckedState.FillColor = System.Drawing.Color.Red;
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rememberMeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rememberMeCheckBox.Location = new System.Drawing.Point(27, 294);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(147, 29);
            this.rememberMeCheckBox.TabIndex = 12;
            this.rememberMeCheckBox.Text = "Remember me";
            this.rememberMeCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rememberMeCheckBox.UncheckedState.BorderRadius = 2;
            this.rememberMeCheckBox.UncheckedState.BorderThickness = 1;
            this.rememberMeCheckBox.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderColor = System.Drawing.Color.Silver;
            this.passwordTextBox.BorderRadius = 8;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.passwordTextBox.Location = new System.Drawing.Point(27, 238);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.passwordTextBox.MaxLength = 25;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.passwordTextBox.PlaceholderText = "";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(349, 44);
            this.passwordTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderColor = System.Drawing.Color.Silver;
            this.emailTextBox.BorderRadius = 8;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTextBox.ForeColor = System.Drawing.Color.Gray;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.emailTextBox.Location = new System.Drawing.Point(27, 149);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.emailTextBox.MaxLength = 35;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(349, 44);
            this.emailTextBox.TabIndex = 10;
            // 
            // logoImage
            // 
            this.logoImage.Image = global::CopyBase.Properties.Resources.copybase_logo;
            this.logoImage.Location = new System.Drawing.Point(27, 26);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(349, 73);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImage.TabIndex = 9;
            this.logoImage.TabStop = false;
            // 
            // incorrectLoginText
            // 
            this.incorrectLoginText.AutoSize = true;
            this.incorrectLoginText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incorrectLoginText.Location = new System.Drawing.Point(74, 316);
            this.incorrectLoginText.Name = "incorrectLoginText";
            this.incorrectLoginText.Size = new System.Drawing.Size(0, 19);
            this.incorrectLoginText.TabIndex = 8;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordLabel.Location = new System.Drawing.Point(21, 209);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 25);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailLabel.Location = new System.Drawing.Point(22, 120);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 25);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 434);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPassIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel mainPanel;
        private Label emailLabel;
        private Label passwordLabel;
        private Label incorrectLoginText;
        private PictureBox logoImage;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox emailTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox passwordTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox rememberMeCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton loginButton;
        private PictureBox viewPassIcon;
    }
}