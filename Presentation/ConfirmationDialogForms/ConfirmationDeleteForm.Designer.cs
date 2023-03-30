namespace CopyBase.Presentation
{
    partial class ConfirmationDeleteForm
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteDescriptionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 316);
            this.panel1.TabIndex = 0;
            // 
            // deleteDescriptionLabel
            // 
            this.deleteDescriptionLabel.AutoSize = true;
            this.deleteDescriptionLabel.Location = new System.Drawing.Point(70, 116);
            this.deleteDescriptionLabel.Name = "deleteDescriptionLabel";
            this.deleteDescriptionLabel.Size = new System.Drawing.Size(269, 40);
            this.deleteDescriptionLabel.TabIndex = 7;
            this.deleteDescriptionLabel.Text = "Are you sure you want to proceed? This\r\naction will delete all data.";
            this.deleteDescriptionLabel.Click += new System.EventHandler(this.deleteDescriptionLabel_Click);
            // 
            // deleteDatabaseLabel
            // 
            this.deleteDatabaseLabel.AutoSize = true;
            this.deleteDatabaseLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteDatabaseLabel.Location = new System.Drawing.Point(109, 40);
            this.deleteDatabaseLabel.Name = "deleteDatabaseLabel";
            this.deleteDatabaseLabel.Size = new System.Drawing.Size(207, 32);
            this.deleteDatabaseLabel.TabIndex = 6;
            this.deleteDatabaseLabel.Text = "DELETE DATABASE";
            this.deleteDatabaseLabel.Click += new System.EventHandler(this.deleteDatabaseLabel_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(221, 229);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(146, 47);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(32, 229);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(146, 47);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ConfirmationDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 316);
            this.Controls.Add(this.deleteDatabaseLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConfirmationDeleteForm";
            this.Text = "ConfirmationExitForm";
            this.Load += new System.EventHandler(this.ConfirmationDeleteForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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