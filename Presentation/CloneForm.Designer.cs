namespace CopyBase
{
    partial class CloneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloneForm));
            this.panel = new System.Windows.Forms.Panel();
            this.cloneButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.DbToCloneMenu = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.clonedDbNameTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.folderIconPanel = new System.Windows.Forms.Panel();
            this.folderIcon = new System.Windows.Forms.PictureBox();
            this.allFieldsErrorLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.clonedDbNameLabel = new System.Windows.Forms.Label();
            this.clonedDbDirLabel = new System.Windows.Forms.Label();
            this.dbToCloneLabel = new System.Windows.Forms.Label();
            this.clonedDbDirTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            this.folderIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.cloneButton);
            this.panel.Controls.Add(this.DbToCloneMenu);
            this.panel.Controls.Add(this.clonedDbNameTextBox);
            this.panel.Controls.Add(this.logoutIcon);
            this.panel.Controls.Add(this.folderIconPanel);
            this.panel.Controls.Add(this.allFieldsErrorLabel);
            this.panel.Controls.Add(this.emailLabel);
            this.panel.Controls.Add(this.fullNameLabel);
            this.panel.Controls.Add(this.clonedDbNameLabel);
            this.panel.Controls.Add(this.clonedDbDirLabel);
            this.panel.Controls.Add(this.dbToCloneLabel);
            this.panel.Controls.Add(this.clonedDbDirTextBox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(504, 542);
            this.panel.TabIndex = 0;
            // 
            // cloneButton
            // 
            this.cloneButton.BorderRadius = 8;
            this.cloneButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cloneButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cloneButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cloneButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cloneButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cloneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cloneButton.ForeColor = System.Drawing.Color.White;
            this.cloneButton.Location = new System.Drawing.Point(34, 446);
            this.cloneButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(436, 62);
            this.cloneButton.TabIndex = 3;
            this.cloneButton.Text = "Clone";
            this.cloneButton.Click += new System.EventHandler(this.cloneButton_Click);
            // 
            // DbToCloneMenu
            // 
            this.DbToCloneMenu.BackColor = System.Drawing.Color.Transparent;
            this.DbToCloneMenu.BorderColor = System.Drawing.Color.Silver;
            this.DbToCloneMenu.BorderRadius = 8;
            this.DbToCloneMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DbToCloneMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DbToCloneMenu.FocusedColor = System.Drawing.Color.Transparent;
            this.DbToCloneMenu.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.DbToCloneMenu.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DbToCloneMenu.ForeColor = System.Drawing.Color.Gray;
            this.DbToCloneMenu.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.DbToCloneMenu.ItemHeight = 49;
            this.DbToCloneMenu.Items.AddRange(new object[] {
            "EGT.mitDk",
            "TestDb"});
            this.DbToCloneMenu.Location = new System.Drawing.Point(34, 156);
            this.DbToCloneMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DbToCloneMenu.Name = "DbToCloneMenu";
            this.DbToCloneMenu.Size = new System.Drawing.Size(435, 55);
            this.DbToCloneMenu.TabIndex = 0;
            this.DbToCloneMenu.SelectedIndexChanged += new System.EventHandler(this.DbToCloneMenu_SelectedIndexChanged);
            // 
            // clonedDbNameTextBox
            // 
            this.clonedDbNameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.clonedDbNameTextBox.BorderRadius = 8;
            this.clonedDbNameTextBox.DefaultText = "";
            this.clonedDbNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clonedDbNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clonedDbNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clonedDbNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clonedDbNameTextBox.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.clonedDbNameTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clonedDbNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.clonedDbNameTextBox.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.clonedDbNameTextBox.Location = new System.Drawing.Point(34, 258);
            this.clonedDbNameTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.clonedDbNameTextBox.MaxLength = 35;
            this.clonedDbNameTextBox.Name = "clonedDbNameTextBox";
            this.clonedDbNameTextBox.PasswordChar = '\0';
            this.clonedDbNameTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.clonedDbNameTextBox.PlaceholderText = "";
            this.clonedDbNameTextBox.SelectedText = "";
            this.clonedDbNameTextBox.Size = new System.Drawing.Size(436, 55);
            this.clonedDbNameTextBox.TabIndex = 1;
            // 
            // logoutIcon
            // 
            this.logoutIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutIcon.Image = global::CopyBase.Properties.Resources.logout;
            this.logoutIcon.Location = new System.Drawing.Point(34, 26);
            this.logoutIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutIcon.Name = "logoutIcon";
            this.logoutIcon.Size = new System.Drawing.Size(31, 31);
            this.logoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutIcon.TabIndex = 13;
            this.logoutIcon.TabStop = false;
            this.logoutIcon.Click += new System.EventHandler(this.logoutIcon_Click);
            // 
            // folderIconPanel
            // 
            this.folderIconPanel.Controls.Add(this.folderIcon);
            this.folderIconPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderIconPanel.Location = new System.Drawing.Point(422, 365);
            this.folderIconPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.folderIconPanel.Name = "folderIconPanel";
            this.folderIconPanel.Size = new System.Drawing.Size(41, 41);
            this.folderIconPanel.TabIndex = 12;
            this.folderIconPanel.Click += new System.EventHandler(this.folderIcon_Click);
            // 
            // folderIcon
            // 
            this.folderIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderIcon.Image = global::CopyBase.Properties.Resources.folder;
            this.folderIcon.Location = new System.Drawing.Point(8, 9);
            this.folderIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.folderIcon.Name = "folderIcon";
            this.folderIcon.Size = new System.Drawing.Size(25, 25);
            this.folderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.folderIcon.TabIndex = 0;
            this.folderIcon.TabStop = false;
            this.folderIcon.Click += new System.EventHandler(this.folderIcon_Click);
            // 
            // allFieldsErrorLabel
            // 
            this.allFieldsErrorLabel.AutoSize = true;
            this.allFieldsErrorLabel.Location = new System.Drawing.Point(124, 404);
            this.allFieldsErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allFieldsErrorLabel.Name = "allFieldsErrorLabel";
            this.allFieldsErrorLabel.Size = new System.Drawing.Size(0, 30);
            this.allFieldsErrorLabel.TabIndex = 11;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.Gray;
            this.emailLabel.Location = new System.Drawing.Point(75, 56);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(169, 20);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "name.holder@email.com";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullNameLabel.Location = new System.Drawing.Point(68, 16);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(220, 46);
            this.fullNameLabel.TabIndex = 7;
            this.fullNameLabel.Text = "Name Holder";
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clonedDbNameLabel
            // 
            this.clonedDbNameLabel.AutoSize = true;
            this.clonedDbNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.clonedDbNameLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clonedDbNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clonedDbNameLabel.Location = new System.Drawing.Point(28, 222);
            this.clonedDbNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clonedDbNameLabel.Name = "clonedDbNameLabel";
            this.clonedDbNameLabel.Size = new System.Drawing.Size(71, 30);
            this.clonedDbNameLabel.TabIndex = 5;
            this.clonedDbNameLabel.Text = "Name";
            // 
            // clonedDbDirLabel
            // 
            this.clonedDbDirLabel.AutoSize = true;
            this.clonedDbDirLabel.BackColor = System.Drawing.Color.Transparent;
            this.clonedDbDirLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clonedDbDirLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clonedDbDirLabel.Location = new System.Drawing.Point(28, 322);
            this.clonedDbDirLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clonedDbDirLabel.Name = "clonedDbDirLabel";
            this.clonedDbDirLabel.Size = new System.Drawing.Size(102, 30);
            this.clonedDbDirLabel.TabIndex = 4;
            this.clonedDbDirLabel.Text = "Directory";
            // 
            // dbToCloneLabel
            // 
            this.dbToCloneLabel.AutoSize = true;
            this.dbToCloneLabel.BackColor = System.Drawing.Color.Transparent;
            this.dbToCloneLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dbToCloneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dbToCloneLabel.Location = new System.Drawing.Point(28, 121);
            this.dbToCloneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dbToCloneLabel.Name = "dbToCloneLabel";
            this.dbToCloneLabel.Size = new System.Drawing.Size(190, 30);
            this.dbToCloneLabel.TabIndex = 3;
            this.dbToCloneLabel.Text = "Database to Clone";
            // 
            // clonedDbDirTextBox
            // 
            this.clonedDbDirTextBox.BorderColor = System.Drawing.Color.Silver;
            this.clonedDbDirTextBox.BorderRadius = 8;
            this.clonedDbDirTextBox.DefaultText = "";
            this.clonedDbDirTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clonedDbDirTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clonedDbDirTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clonedDbDirTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clonedDbDirTextBox.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.clonedDbDirTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clonedDbDirTextBox.ForeColor = System.Drawing.Color.Gray;
            this.clonedDbDirTextBox.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.clonedDbDirTextBox.Location = new System.Drawing.Point(34, 358);
            this.clonedDbDirTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.clonedDbDirTextBox.MaxLength = 35;
            this.clonedDbDirTextBox.Name = "clonedDbDirTextBox";
            this.clonedDbDirTextBox.PasswordChar = '\0';
            this.clonedDbDirTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.clonedDbDirTextBox.PlaceholderText = "";
            this.clonedDbDirTextBox.ReadOnly = true;
            this.clonedDbDirTextBox.SelectedText = "";
            this.clonedDbDirTextBox.Size = new System.Drawing.Size(436, 55);
            this.clonedDbDirTextBox.TabIndex = 2;
            // 
            // CloneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 542);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(432, 47);
            this.Name = "CloneForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloneForm_FormClosing);
            this.Load += new System.EventHandler(this.CloneForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            this.folderIconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel;
        private Label dbToCloneLabel;
        private Label clonedDbDirLabel;
        private Label fullNameLabel;
        private Label emailLabel;
        private Label clonedDbNameLabel;
        private Label allFieldsErrorLabel;
        private PictureBox folderIcon;
        private Panel folderIconPanel;
        private PictureBox logoutIcon;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox clonedDbNameTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox clonedDbDirTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox DbToCloneMenu;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cloneButton;
    }
}