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
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.folderIconPanel = new System.Windows.Forms.Panel();
            this.folderIcon = new System.Windows.Forms.PictureBox();
            this.allFieldsErrorLabel = new System.Windows.Forms.Label();
            this.DbToCloneMenu = new System.Windows.Forms.ComboBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.clonedDbNameTextBox = new System.Windows.Forms.TextBox();
            this.clonedDbNameLabel = new System.Windows.Forms.Label();
            this.clonedDbDirLabel = new System.Windows.Forms.Label();
            this.dbToCloneLabel = new System.Windows.Forms.Label();
            this.clonedDbDirTextBox = new System.Windows.Forms.TextBox();
            this.cloneButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            this.folderIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.logoutIcon);
            this.panel.Controls.Add(this.folderIconPanel);
            this.panel.Controls.Add(this.allFieldsErrorLabel);
            this.panel.Controls.Add(this.DbToCloneMenu);
            this.panel.Controls.Add(this.emailLabel);
            this.panel.Controls.Add(this.fullNameLabel);
            this.panel.Controls.Add(this.clonedDbNameTextBox);
            this.panel.Controls.Add(this.clonedDbNameLabel);
            this.panel.Controls.Add(this.clonedDbDirLabel);
            this.panel.Controls.Add(this.dbToCloneLabel);
            this.panel.Controls.Add(this.clonedDbDirTextBox);
            this.panel.Controls.Add(this.cloneButton);
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
            this.logoutIcon.Location = new System.Drawing.Point(31, 25);
            this.logoutIcon.Name = "logoutIcon";
            this.logoutIcon.Size = new System.Drawing.Size(24, 24);
            this.logoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutIcon.TabIndex = 13;
            this.logoutIcon.TabStop = false;
            this.logoutIcon.Click += new System.EventHandler(this.logoutIcon_Click);
            // 
            // folderIconPanel
            // 
            this.folderIconPanel.Controls.Add(this.folderIcon);
            this.folderIconPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderIconPanel.Location = new System.Drawing.Point(344, 286);
            this.folderIconPanel.Name = "folderIconPanel";
            this.folderIconPanel.Size = new System.Drawing.Size(30, 30);
            this.folderIconPanel.TabIndex = 12;
            this.folderIconPanel.Click += new System.EventHandler(this.folderIcon_Click);
            // 
            // folderIcon
            // 
            this.folderIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderIcon.Image = global::CopyBase.Properties.Resources.folder;
            this.folderIcon.Location = new System.Drawing.Point(7, 8);
            this.folderIcon.Name = "folderIcon";
            this.folderIcon.Size = new System.Drawing.Size(15, 15);
            this.folderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.folderIcon.TabIndex = 0;
            this.folderIcon.TabStop = false;
            this.folderIcon.Click += new System.EventHandler(this.folderIcon_Click);
            // 
            // allFieldsErrorLabel
            // 
            this.allFieldsErrorLabel.AutoSize = true;
            this.allFieldsErrorLabel.Location = new System.Drawing.Point(99, 323);
            this.allFieldsErrorLabel.Name = "allFieldsErrorLabel";
            this.allFieldsErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.allFieldsErrorLabel.TabIndex = 11;
            // 
            // DbToCloneMenu
            // 
            this.DbToCloneMenu.BackColor = System.Drawing.Color.White;
            this.DbToCloneMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DbToCloneMenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DbToCloneMenu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DbToCloneMenu.ForeColor = System.Drawing.Color.Gray;
            this.DbToCloneMenu.FormattingEnabled = true;
            this.DbToCloneMenu.Items.AddRange(new object[] {
            "EGT.mitDk",
            "Salary"});
            this.DbToCloneMenu.Location = new System.Drawing.Point(27, 121);
            this.DbToCloneMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DbToCloneMenu.Name = "DbToCloneMenu";
            this.DbToCloneMenu.Size = new System.Drawing.Size(349, 36);
            this.DbToCloneMenu.TabIndex = 0;
            this.DbToCloneMenu.SelectedIndexChanged += new System.EventHandler(this.DbToCloneMenu_SelectedIndexChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.Gray;
            this.emailLabel.Location = new System.Drawing.Point(27, 55);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(138, 15);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "name.holder@email.com";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullNameLabel.Location = new System.Drawing.Point(57, 15);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(176, 37);
            this.fullNameLabel.TabIndex = 7;
            this.fullNameLabel.Text = "Name Holder";
            // 
            // clonedDbNameTextBox
            // 
            this.clonedDbNameTextBox.AccessibleName = "";
            this.clonedDbNameTextBox.BackColor = System.Drawing.Color.White;
            this.clonedDbNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clonedDbNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clonedDbNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.clonedDbNameTextBox.Location = new System.Drawing.Point(27, 203);
            this.clonedDbNameTextBox.MaxLength = 30;
            this.clonedDbNameTextBox.Name = "clonedDbNameTextBox";
            this.clonedDbNameTextBox.Size = new System.Drawing.Size(349, 34);
            this.clonedDbNameTextBox.TabIndex = 1;
            // 
            // clonedDbNameLabel
            // 
            this.clonedDbNameLabel.AutoSize = true;
            this.clonedDbNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.clonedDbNameLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clonedDbNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clonedDbNameLabel.Location = new System.Drawing.Point(22, 178);
            this.clonedDbNameLabel.Name = "clonedDbNameLabel";
            this.clonedDbNameLabel.Size = new System.Drawing.Size(199, 25);
            this.clonedDbNameLabel.TabIndex = 5;
            this.clonedDbNameLabel.Text = "Cloned Database Name";
            // 
            // clonedDbDirLabel
            // 
            this.clonedDbDirLabel.AutoSize = true;
            this.clonedDbDirLabel.BackColor = System.Drawing.Color.Transparent;
            this.clonedDbDirLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clonedDbDirLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clonedDbDirLabel.Location = new System.Drawing.Point(22, 260);
            this.clonedDbDirLabel.Name = "clonedDbDirLabel";
            this.clonedDbDirLabel.Size = new System.Drawing.Size(224, 25);
            this.clonedDbDirLabel.TabIndex = 4;
            this.clonedDbDirLabel.Text = "Cloned Database Directory";
            // 
            // dbToCloneLabel
            // 
            this.dbToCloneLabel.AutoSize = true;
            this.dbToCloneLabel.BackColor = System.Drawing.Color.Transparent;
            this.dbToCloneLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dbToCloneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dbToCloneLabel.Location = new System.Drawing.Point(22, 97);
            this.dbToCloneLabel.Name = "dbToCloneLabel";
            this.dbToCloneLabel.Size = new System.Drawing.Size(158, 25);
            this.dbToCloneLabel.TabIndex = 3;
            this.dbToCloneLabel.Text = "Database to Clone";
            // 
            // clonedDbDirTextBox
            // 
            this.clonedDbDirTextBox.BackColor = System.Drawing.Color.White;
            this.clonedDbDirTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clonedDbDirTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clonedDbDirTextBox.ForeColor = System.Drawing.Color.Gray;
            this.clonedDbDirTextBox.Location = new System.Drawing.Point(27, 285);
            this.clonedDbDirTextBox.Name = "clonedDbDirTextBox";
            this.clonedDbDirTextBox.ReadOnly = true;
            this.clonedDbDirTextBox.Size = new System.Drawing.Size(349, 34);
            this.clonedDbDirTextBox.TabIndex = 3;
            // 
            // cloneButton
            // 
            this.cloneButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cloneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cloneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cloneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cloneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cloneButton.ForeColor = System.Drawing.Color.White;
            this.cloneButton.Location = new System.Drawing.Point(27, 357);
            this.cloneButton.Margin = new System.Windows.Forms.Padding(27, 0, 27, 27);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(349, 50);
            this.cloneButton.TabIndex = 4;
            this.cloneButton.Text = "Clone";
            this.cloneButton.UseVisualStyleBackColor = false;
            this.cloneButton.Click += new System.EventHandler(this.cloneButton_Click);
            // 
            // CloneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 434);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private Button cloneButton;
        private TextBox clonedDbDirTextBox;
        private Label dbToCloneLabel;
        private Label clonedDbDirLabel;
        private Label fullNameLabel;
        private Label emailLabel;
        private ComboBox DbToCloneMenu;
        private TextBox clonedDbNameTextBox;
        private Label clonedDbNameLabel;
        private Label allFieldsErrorLabel;
        private PictureBox folderIcon;
        private Panel folderIconPanel;
        private PictureBox logoutIcon;
    }
}