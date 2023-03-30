namespace CopyBase.Presentation.ConfirmationDialogForms
{
    public partial class ConfirmationResetForm : Form
    {
        public ConfirmationResetForm()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
