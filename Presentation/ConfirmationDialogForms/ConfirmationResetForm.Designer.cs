namespace CopyBase.Presentation.ConfirmationDialogForms
{
    partial class ConfirmationResetForm
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
            this.resetButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.exitDescriptionLabel = new System.Windows.Forms.Label();
            this.resetLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(216, 240);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(146, 47);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.exitDescriptionLabel);
            this.panel.Controls.Add(this.resetLabel);
            this.panel.Controls.Add(this.resetButton);
            this.panel.Controls.Add(this.cancelButton);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(399, 316);
            this.panel.TabIndex = 1;
            // 
            // exitDescriptionLabel
            // 
            this.exitDescriptionLabel.AutoSize = true;
            this.exitDescriptionLabel.Location = new System.Drawing.Point(66, 121);
            this.exitDescriptionLabel.Name = "exitDescriptionLabel";
            this.exitDescriptionLabel.Size = new System.Drawing.Size(269, 40);
            this.exitDescriptionLabel.TabIndex = 3;
            this.exitDescriptionLabel.Text = "Are you sure you want to proceed? This\r\naction will delete all data.\r\n";
            // 
            // resetLabel
            // 
            this.resetLabel.AutoSize = true;
            this.resetLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetLabel.Location = new System.Drawing.Point(168, 47);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(78, 32);
            this.resetLabel.TabIndex = 2;
            this.resetLabel.Text = "RESET";
            this.resetLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(27, 240);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(146, 47);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmationResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 316);
            this.Controls.Add(this.panel);
            this.Name = "ConfirmationResetForm";
            this.Text = "ConfirmationResetForm";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button resetButton;
        private Panel panel;
        private Label exitDescriptionLabel;
        private Label resetLabel;
        private Button cancelButton;
    }
}