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
            this.panel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.allFieldsErrorLabel = new System.Windows.Forms.Label();
            this.DbToCloneMenu = new System.Windows.Forms.ComboBox();
            this.findDirectoryButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.clonedDbNameTextBox = new System.Windows.Forms.TextBox();
            this.clonedDbNameLabel = new System.Windows.Forms.Label();
            this.clonedDbDirLabel = new System.Windows.Forms.Label();
            this.dbToCloneLabel = new System.Windows.Forms.Label();
            this.clonedDbDirTextBox = new System.Windows.Forms.TextBox();
            this.cloneButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.logoutButton);
            this.panel.Controls.Add(this.allFieldsErrorLabel);
            this.panel.Controls.Add(this.DbToCloneMenu);
            this.panel.Controls.Add(this.findDirectoryButton);
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
            this.panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(461, 579);
            this.panel.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(357, 24);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(76, 36);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // allFieldsErrorLabel
            // 
            this.allFieldsErrorLabel.AutoSize = true;
            this.allFieldsErrorLabel.Location = new System.Drawing.Point(113, 431);
            this.allFieldsErrorLabel.Name = "allFieldsErrorLabel";
            this.allFieldsErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.allFieldsErrorLabel.TabIndex = 11;
            // 
            // DbToCloneMenu
            // 
            this.DbToCloneMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DbToCloneMenu.FormattingEnabled = true;
            this.DbToCloneMenu.Items.AddRange(new object[] {
            "EGT.mitDk",
            "Salary"});
            this.DbToCloneMenu.Location = new System.Drawing.Point(61, 205);
            this.DbToCloneMenu.Name = "DbToCloneMenu";
            this.DbToCloneMenu.Size = new System.Drawing.Size(333, 28);
            this.DbToCloneMenu.TabIndex = 1;
            this.DbToCloneMenu.SelectedIndexChanged += new System.EventHandler(this.DbToCloneMenu_SelectedIndexChanged);
            // 
            // findDirectoryButton
            // 
            this.findDirectoryButton.Location = new System.Drawing.Point(357, 353);
            this.findDirectoryButton.Name = "findDirectoryButton";
            this.findDirectoryButton.Size = new System.Drawing.Size(48, 36);
            this.findDirectoryButton.TabIndex = 9;
            this.findDirectoryButton.Text = "dir";
            this.findDirectoryButton.UseVisualStyleBackColor = true;
            this.findDirectoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(83, 70);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(175, 20);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "name.holder@email.com";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullNameLabel.Location = new System.Drawing.Point(73, 24);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(220, 46);
            this.fullNameLabel.TabIndex = 7;
            this.fullNameLabel.Text = "Name Holder";
            // 
            // clonedDbNameTextBox
            // 
            this.clonedDbNameTextBox.AccessibleName = "";
            this.clonedDbNameTextBox.Location = new System.Drawing.Point(60, 281);
            this.clonedDbNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clonedDbNameTextBox.Name = "clonedDbNameTextBox";
            this.clonedDbNameTextBox.Size = new System.Drawing.Size(332, 27);
            this.clonedDbNameTextBox.TabIndex = 2;
            // 
            // clonedDbNameLabel
            // 
            this.clonedDbNameLabel.AutoSize = true;
            this.clonedDbNameLabel.Location = new System.Drawing.Point(60, 257);
            this.clonedDbNameLabel.Name = "clonedDbNameLabel";
            this.clonedDbNameLabel.Size = new System.Drawing.Size(167, 20);
            this.clonedDbNameLabel.TabIndex = 5;
            this.clonedDbNameLabel.Text = "Cloned Database Name";
            // 
            // clonedDbDirLabel
            // 
            this.clonedDbDirLabel.AutoSize = true;
            this.clonedDbDirLabel.Location = new System.Drawing.Point(60, 338);
            this.clonedDbDirLabel.Name = "clonedDbDirLabel";
            this.clonedDbDirLabel.Size = new System.Drawing.Size(188, 20);
            this.clonedDbDirLabel.TabIndex = 4;
            this.clonedDbDirLabel.Text = "Cloned Database Directory";
            // 
            // dbToCloneLabel
            // 
            this.dbToCloneLabel.AutoSize = true;
            this.dbToCloneLabel.Location = new System.Drawing.Point(62, 182);
            this.dbToCloneLabel.Name = "dbToCloneLabel";
            this.dbToCloneLabel.Size = new System.Drawing.Size(132, 20);
            this.dbToCloneLabel.TabIndex = 3;
            this.dbToCloneLabel.Text = "Database to Clone";
            // 
            // clonedDbDirTextBox
            // 
            this.clonedDbDirTextBox.Location = new System.Drawing.Point(60, 362);
            this.clonedDbDirTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clonedDbDirTextBox.Name = "clonedDbDirTextBox";
            this.clonedDbDirTextBox.ReadOnly = true;
            this.clonedDbDirTextBox.Size = new System.Drawing.Size(291, 27);
            this.clonedDbDirTextBox.TabIndex = 3;
            // 
            // cloneButton
            // 
            this.cloneButton.Location = new System.Drawing.Point(61, 491);
            this.cloneButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(333, 52);
            this.cloneButton.TabIndex = 4;
            this.cloneButton.Text = "Clone";
            this.cloneButton.UseVisualStyleBackColor = true;
            this.cloneButton.Click += new System.EventHandler(this.cloneButton_Click);
            // 
            // CloneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 579);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CloneForm";
            this.Text = "CloneForm";
            this.Load += new System.EventHandler(this.CloneForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
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
        private Button findDirectoryButton;
        private ComboBox DbToCloneMenu;
        private TextBox clonedDbNameTextBox;
        private Label clonedDbNameLabel;
        private Label allFieldsErrorLabel;
        private Button logoutButton;
    }
}