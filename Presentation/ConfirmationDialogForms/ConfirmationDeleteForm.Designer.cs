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
            this.panel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.exitLabel = new System.Windows.Forms.Label();
            this.exitDescriptionLabel = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.exitDescriptionLabel);
            this.panel.Controls.Add(this.exitLabel);
            this.panel.Controls.Add(this.exitButton);
            this.panel.Controls.Add(this.cancelButton);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(349, 237);
            this.panel.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(24, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(128, 35);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(189, 180);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 35);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitLabel.Location = new System.Drawing.Point(147, 35);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(48, 25);
            this.exitLabel.TabIndex = 2;
            this.exitLabel.Text = "EXIT";
            this.exitLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // exitDescriptionLabel
            // 
            this.exitDescriptionLabel.AutoSize = true;
            this.exitDescriptionLabel.Location = new System.Drawing.Point(58, 91);
            this.exitDescriptionLabel.Name = "exitDescriptionLabel";
            this.exitDescriptionLabel.Size = new System.Drawing.Size(243, 30);
            this.exitDescriptionLabel.TabIndex = 3;
            this.exitDescriptionLabel.Text = "Exiting Copybase will delete the cloned\r\ndatabase. Are you sure you want to proce" +
    "ed?\r\n";
            this.exitDescriptionLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ConfirmationDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 237);
            this.Controls.Add(this.panel);
            this.Name = "ConfirmationDeleteForm";
            this.Text = "ConfirmationDeleteForm";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel;
        private Label exitLabel;
        private Button exitButton;
        private Button cancelButton;
        private Label exitDescriptionLabel;
    }
}