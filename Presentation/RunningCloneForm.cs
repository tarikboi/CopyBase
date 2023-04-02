using CopyBase.Domain;
using CopyBase.Domain.Interfaces;
using CopyBase.Presentation;
using CopyBase.Presentation.ConfirmationDialogForms;

namespace CopyBase
{
    public partial class RunningCloneForm : Form
    {
        private readonly ICloneManager _cloneManager = new CloneManager();

        public RunningCloneForm()
        {
            InitializeComponent();
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
                _cloneManager.DeleteClonedDatabase();

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
                    _cloneManager.DeleteClonedDatabase();
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
            _cloneManager.OpenClonedDatabase();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Confirmation
            ConfirmationResetForm crf = new ConfirmationResetForm();
            DialogResult result = crf.ShowDialog();

            if (result == DialogResult.OK)
            {
                _cloneManager.ResetClonedDatabase();
                label.Text = @"Cloned database has been successfully reset";
            }
        }
    }
}
