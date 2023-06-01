namespace CopyBase.Presentation.ConfirmationDialogForms
{
    public partial class ConfirmationResetForm : Form
    {
        public ConfirmationResetForm()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
