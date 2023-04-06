namespace CopyBase
{
    partial class RunningCloneForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunningCloneForm));
            this.panel = new System.Windows.Forms.Panel();
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.runningTimeLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.copyIconPanel = new System.Windows.Forms.Panel();
            this.copyIcon = new System.Windows.Forms.PictureBox();
            this.clonedDbConnectionStringTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.logsButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.resetButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.openButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.deleteCloneButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            this.copyIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.logoutIcon);
            this.panel.Controls.Add(this.runningTimeLabel);
            this.panel.Controls.Add(this.timerLabel);
            this.panel.Controls.Add(this.label);
            this.panel.Controls.Add(this.copyIconPanel);
            this.panel.Controls.Add(this.clonedDbConnectionStringTextBox);
            this.panel.Controls.Add(this.logsButton);
            this.panel.Controls.Add(this.resetButton);
            this.panel.Controls.Add(this.openButton);
            this.panel.Controls.Add(this.deleteCloneButton);
            this.panel.Controls.Add(this.emailLabel);
            this.panel.Controls.Add(this.fullNameLabel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(403, 434);
            this.panel.TabIndex = 0;
            // 
            // logoutIcon
            // 
            this.logoutIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutIcon.Image = global::CopyBase.Properties.Resources.logout;
            this.logoutIcon.Location = new System.Drawing.Point(27, 24);
            this.logoutIcon.Name = "logoutIcon";
            this.logoutIcon.Size = new System.Drawing.Size(25, 25);
            this.logoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutIcon.TabIndex = 24;
            this.logoutIcon.TabStop = false;
            this.logoutIcon.Click += new System.EventHandler(this.logoutIcon_Click);
            // 
            // runningTimeLabel
            // 
            this.runningTimeLabel.AutoSize = true;
            this.runningTimeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.runningTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.runningTimeLabel.Location = new System.Drawing.Point(27, 177);
            this.runningTimeLabel.Name = "runningTimeLabel";
            this.runningTimeLabel.Size = new System.Drawing.Size(103, 20);
            this.runningTimeLabel.TabIndex = 23;
            this.runningTimeLabel.Text = "Running Time:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timerLabel.Location = new System.Drawing.Point(129, 177);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(65, 20);
            this.timerLabel.TabIndex = 22;
            this.timerLabel.Text = "00:00:00";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(292, 177);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 20);
            this.label.TabIndex = 21;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copyIconPanel
            // 
            this.copyIconPanel.Controls.Add(this.copyIcon);
            this.copyIconPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyIconPanel.Location = new System.Drawing.Point(335, 215);
            this.copyIconPanel.Name = "copyIconPanel";
            this.copyIconPanel.Size = new System.Drawing.Size(33, 33);
            this.copyIconPanel.TabIndex = 19;
            // 
            // copyIcon
            // 
            this.copyIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyIcon.Image = global::CopyBase.Properties.Resources.copy;
            this.copyIcon.Location = new System.Drawing.Point(6, 7);
            this.copyIcon.Name = "copyIcon";
            this.copyIcon.Size = new System.Drawing.Size(20, 20);
            this.copyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.copyIcon.TabIndex = 0;
            this.copyIcon.TabStop = false;
            this.copyIcon.Click += new System.EventHandler(this.copyIcon_Click);
            // 
            // clonedDbConnectionStringTextBox
            // 
            this.clonedDbConnectionStringTextBox.BorderColor = System.Drawing.Color.Silver;
            this.clonedDbConnectionStringTextBox.BorderRadius = 8;
            this.clonedDbConnectionStringTextBox.DefaultText = "";
            this.clonedDbConnectionStringTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clonedDbConnectionStringTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clonedDbConnectionStringTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clonedDbConnectionStringTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clonedDbConnectionStringTextBox.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.clonedDbConnectionStringTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clonedDbConnectionStringTextBox.ForeColor = System.Drawing.Color.Gray;
            this.clonedDbConnectionStringTextBox.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.clonedDbConnectionStringTextBox.Location = new System.Drawing.Point(27, 206);
            this.clonedDbConnectionStringTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clonedDbConnectionStringTextBox.MaxLength = 35;
            this.clonedDbConnectionStringTextBox.Name = "clonedDbConnectionStringTextBox";
            this.clonedDbConnectionStringTextBox.PasswordChar = '\0';
            this.clonedDbConnectionStringTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.clonedDbConnectionStringTextBox.PlaceholderText = "";
            this.clonedDbConnectionStringTextBox.ReadOnly = true;
            this.clonedDbConnectionStringTextBox.SelectedText = "";
            this.clonedDbConnectionStringTextBox.Size = new System.Drawing.Size(349, 50);
            this.clonedDbConnectionStringTextBox.TabIndex = 20;
            // 
            // logsButton
            // 
            this.logsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logsButton.BorderRadius = 8;
            this.logsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logsButton.ForeColor = System.Drawing.Color.White;
            this.logsButton.Location = new System.Drawing.Point(268, 268);
            this.logsButton.Name = "logsButton";
            this.logsButton.Size = new System.Drawing.Size(108, 37);
            this.logsButton.TabIndex = 17;
            this.logsButton.Text = "Logs";
            // 
            // resetButton
            // 
            this.resetButton.BorderRadius = 8;
            this.resetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(147, 268);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(108, 37);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // openButton
            // 
            this.openButton.BorderRadius = 8;
            this.openButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.openButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.openButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.openButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.openButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openButton.ForeColor = System.Drawing.Color.White;
            this.openButton.Location = new System.Drawing.Point(27, 268);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(108, 37);
            this.openButton.TabIndex = 15;
            this.openButton.Text = "Open";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // deleteCloneButton
            // 
            this.deleteCloneButton.BorderRadius = 8;
            this.deleteCloneButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteCloneButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteCloneButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteCloneButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteCloneButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteCloneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteCloneButton.ForeColor = System.Drawing.Color.White;
            this.deleteCloneButton.Location = new System.Drawing.Point(27, 357);
            this.deleteCloneButton.Name = "deleteCloneButton";
            this.deleteCloneButton.Size = new System.Drawing.Size(349, 50);
            this.deleteCloneButton.TabIndex = 14;
            this.deleteCloneButton.Text = "Delete Clone";
            this.deleteCloneButton.Click += new System.EventHandler(this.deleteCloneButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailLabel.Location = new System.Drawing.Point(60, 45);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(141, 15);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "name.holder@email.com";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullNameLabel.Location = new System.Drawing.Point(53, 11);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(176, 37);
            this.fullNameLabel.TabIndex = 9;
            this.fullNameLabel.Text = "Name Holder";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RunningCloneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(403, 434);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RunningCloneForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RunningCloneForm_FormClosing);
            this.Load += new System.EventHandler(this.RunningCloneForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            this.copyIconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.copyIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel;
        private Label emailLabel;
        private Label fullNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton deleteCloneButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton logsButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton resetButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton openButton;
        private Panel copyIconPanel;
        private PictureBox copyIcon;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox clonedDbConnectionStringTextBox;
        private System.Windows.Forms.Timer timer;
        private Label label;
        private Label timerLabel;
        private Label runningTimeLabel;
        private PictureBox logoutIcon;
    }
}