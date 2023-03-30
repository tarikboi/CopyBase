using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyBase.Domain;
using CopyBase.Presentation;
using CopyBase.Presentation.ConfirmationDialogForms;

namespace CopyBase
{
    public partial class RunningCloneForm : Form
    {
        public RunningCloneForm()
        {
            InitializeComponent();
        }

        private void ClonedDbPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void RunningCloneForm_Load(object sender, EventArgs e)
        {
            //Set user variables
            fullNameLabel.Text = User.FullName;
            emailLabel.Text = User.Email;
        }

        private void deleteCloneButton_Click(object sender, EventArgs e)
        {
            //Confirmation
            ConfirmationDeleteForm cdf = new ConfirmationDeleteForm();
            DialogResult result = cdf.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                CloneManager.DeleteClonedDatabase();

                //Switch to CloneForm
                CloneForm cf = new CloneForm();
                cf.StartPosition = FormStartPosition.Manual;
                cf.Location = this.Location;
                cf.Show();
                this.Hide();
            }
        }

        private void RunningCloneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If form is not closed by Application.Exit(), it means it was closed directly from this form
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                //Confirmation
                ConfirmationExitForm cef = new ConfirmationExitForm();
                DialogResult result = cef.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CloneManager.DeleteClonedDatabase();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            CloneManager.OpenClonedDatabase();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Confirmation
            ConfirmationResetForm crf = new ConfirmationResetForm();
            DialogResult result = crf.ShowDialog();

            if (result == DialogResult.OK)
            {
                CloneManager.ResetClonedDatabase();
                label.Text = "Cloned databas has been successfully reset";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
