namespace CopyBase.Presentation
{
    partial class ConfirmationExitForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.deleteDescriptionLabel = new System.Windows.Forms.Label();
            this.deleteDatabaseLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 237);
            this.panel1.TabIndex = 0;
            // 
            // deleteDescriptionLabel
            // 
            this.deleteDescriptionLabel.AutoSize = true;
            this.deleteDescriptionLabel.Location = new System.Drawing.Point(59, 87);
            this.deleteDescriptionLabel.Name = "deleteDescriptionLabel";
            this.deleteDescriptionLabel.Size = new System.Drawing.Size(236, 30);
            this.deleteDescriptionLabel.TabIndex = 7;
            this.deleteDescriptionLabel.Text = "Are you sure you want to delete the cloned \r\ndatabase? All data will be permanent" +
    "ly lost.";
            this.deleteDescriptionLabel.Click += new System.EventHandler(this.deleteDescriptionLabel_Click);
            // 
            // deleteDatabaseLabel
            // 
            this.deleteDatabaseLabel.AutoSize = true;
            this.deleteDatabaseLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteDatabaseLabel.Location = new System.Drawing.Point(95, 30);
            this.deleteDatabaseLabel.Name = "deleteDatabaseLabel";
            this.deleteDatabaseLabel.Size = new System.Drawing.Size(167, 25);
            this.deleteDatabaseLabel.TabIndex = 6;
            this.deleteDatabaseLabel.Text = "DELETE DATABASE";
            this.deleteDatabaseLabel.Click += new System.EventHandler(this.deleteDatabaseLabel_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(193, 172);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(128, 35);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(28, 172);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(128, 35);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ConfirmationExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 237);
            this.Controls.Add(this.deleteDescriptionLabel);
            this.Controls.Add(this.deleteDatabaseLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel1);
            this.Name = "ConfirmationExitForm";
            this.Text = "ConfirmationExitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label deleteDescriptionLabel;
        private Label deleteDatabaseLabel;
        private Button deleteButton;
        private Button cancelButton;
    }
}