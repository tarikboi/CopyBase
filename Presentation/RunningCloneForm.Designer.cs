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
            this.panel = new System.Windows.Forms.Panel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.deleteCloneButton = new System.Windows.Forms.Button();
            this.logsButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.ClonedDbPath = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.emailLabel);
            this.panel.Controls.Add(this.fullNameLabel);
            this.panel.Controls.Add(this.deleteCloneButton);
            this.panel.Controls.Add(this.logsButton);
            this.panel.Controls.Add(this.resetButton);
            this.panel.Controls.Add(this.openButton);
            this.panel.Controls.Add(this.label);
            this.panel.Controls.Add(this.ClonedDbPath);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(403, 434);
            this.panel.TabIndex = 0;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailLabel.Location = new System.Drawing.Point(85, 61);
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
            this.fullNameLabel.Location = new System.Drawing.Point(76, 24);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(176, 37);
            this.fullNameLabel.TabIndex = 9;
            this.fullNameLabel.Text = "Name Holder";
            // 
            // deleteCloneButton
            // 
            this.deleteCloneButton.Location = new System.Drawing.Point(33, 364);
            this.deleteCloneButton.Name = "deleteCloneButton";
            this.deleteCloneButton.Size = new System.Drawing.Size(340, 33);
            this.deleteCloneButton.TabIndex = 5;
            this.deleteCloneButton.Text = "Delete Clone";
            this.deleteCloneButton.UseVisualStyleBackColor = true;
            this.deleteCloneButton.Click += new System.EventHandler(this.deleteCloneButton_Click);
            // 
            // logsButton
            // 
            this.logsButton.Location = new System.Drawing.Point(276, 282);
            this.logsButton.Name = "logsButton";
            this.logsButton.Size = new System.Drawing.Size(97, 33);
            this.logsButton.TabIndex = 4;
            this.logsButton.Text = "Logs";
            this.logsButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(155, 282);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(97, 33);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(33, 282);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(97, 33);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(85, 152);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(225, 19);
            this.label.TabIndex = 1;
            this.label.Text = "Database successfully cloned locally";
            // 
            // ClonedDbPath
            // 
            this.ClonedDbPath.Location = new System.Drawing.Point(33, 239);
            this.ClonedDbPath.Name = "ClonedDbPath";
            this.ClonedDbPath.ReadOnly = true;
            this.ClonedDbPath.Size = new System.Drawing.Size(340, 23);
            this.ClonedDbPath.TabIndex = 10;
            // 
            // RunningCloneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 434);
            this.Controls.Add(this.panel);
            this.Name = "RunningCloneForm";
            this.Text = "RunningCloneForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RunningCloneForm_FormClosing);
            this.Load += new System.EventHandler(this.RunningCloneForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel;
        private TextBox ClonedDbPath;
        private Button openButton;
        private Label label;
        private Button logsButton;
        private Button resetButton;
        private Button deleteCloneButton;
        private Label emailLabel;
        private Label fullNameLabel;
    }
}