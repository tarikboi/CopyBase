﻿namespace CopyBase.Presentation
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
            this.panel = new System.Windows.Forms.Panel();
            this.exitDescriptionLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
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
            this.panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(399, 316);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // exitDescriptionLabel
            // 
            this.exitDescriptionLabel.AutoSize = true;
            this.exitDescriptionLabel.Location = new System.Drawing.Point(66, 121);
            this.exitDescriptionLabel.Name = "exitDescriptionLabel";
            this.exitDescriptionLabel.Size = new System.Drawing.Size(269, 40);
            this.exitDescriptionLabel.TabIndex = 3;
            this.exitDescriptionLabel.Text = "Are you sure you want to proceed? This\r\naction will delete all data.";
            this.exitDescriptionLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitLabel.Location = new System.Drawing.Point(168, 47);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(59, 32);
            this.exitLabel.TabIndex = 2;
            this.exitLabel.Text = "EXIT";
            this.exitLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(216, 240);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(146, 47);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ConfirmationExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 316);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConfirmationExitForm";
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