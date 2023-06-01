using CopyBase.Data_Layer;
using CopyBase.Domain;
using CopyBase.Domain.Interfaces;
using CopyBase.Presentation;
using CopyBase.Presentation.ConfirmationDialogForms;
using Timer = System.Windows.Forms.Timer;

namespace CopyBase
{
    public partial class RunningCloneForm : Form
    {
        private readonly ICloneManager _cloneManager = new CloneManager();
        
        private TimeSpan elapsedTime;

        public RunningCloneForm()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
        }

        private void RunningCloneForm_Load(object sender, EventArgs e)
        {
            //Set user variables
            fullNameLabel.Text = User.FullName;
            emailLabel.Text = User.Email;
            clonedDbConnectionStringTextBox.Text = ClonedDatabase.ConnectionString;

            //Timer
            elapsedTime = TimeSpan.Zero;
            timerLabel.Text = "00:00:00";
            timer.Start();

            //Hide status label after 5 seconds
            var timer2 = new Timer();
            timer2.Interval = 5000;
            timer2.Tick += (s, args) =>
            {
                label.Visible = false;
                timer2.Stop();
            };
            timer2.Start();
        }

        private void deleteCloneButton_Click(object sender, EventArgs e)
        {
            //Show confirmation box in the center
            ConfirmationDeleteForm cdf = new ConfirmationDeleteForm();
            cdf.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = cdf.ShowDialog(this);

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
                cef.StartPosition = FormStartPosition.CenterParent;
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

        private async void openButton_Click(object sender, EventArgs e)
        {
            label.Text = "Opening...";
            label.Visible = true;

            await Task.Delay(5000);

            _cloneManager.OpenClonedDatabase();

            label.Text = "Opened✔";
            label.Visible = true;

            // Hide the "Reset done!" label after 5 seconds
            var timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += (s, args) =>
            {
                label.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }

        private async void resetButton_Click(object sender, EventArgs e)
        {
            // Confirmation
            ConfirmationResetForm crf = new ConfirmationResetForm();
            crf.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = crf.ShowDialog();

            if (result == DialogResult.OK)
            {
                label.Text = "Resetting...";

                label.Visible = true;

                //Wait for 1 second to give the user a chance to read the "Resetting..." label
                await Task.Delay(1000);

                _cloneManager.ResetClonedDatabase();

                label.Text = "Reset done✔";
                label.Visible = true;

                // Hide the "Reset done!" label after 2 seconds
                var timer = new Timer();
                timer.Interval = 5000;
                timer.Tick += (s, args) =>
                {
                    label.Visible = false;
                    timer.Stop();
                };
                timer.Start();
            }
        }


        private void copyIcon_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(clonedDbConnectionStringTextBox.Text);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
            timerLabel.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void logoutIcon_Click(object sender, EventArgs e)
        {
            //Show confirmation box in the center
            ConfirmationDeleteForm cdf = new ConfirmationDeleteForm();
            cdf.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = cdf.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                _cloneManager.DeleteClonedDatabase();

                //Switch to LoginForm
                LoginForm lf = new LoginForm();
                lf.StartPosition = FormStartPosition.Manual;
                lf.Location = this.Location;
                lf.Show();
                this.Hide();
            }
        }
    }
}
