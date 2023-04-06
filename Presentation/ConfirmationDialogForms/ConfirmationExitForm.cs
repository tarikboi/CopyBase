namespace CopyBase.Presentation
{
    public partial class ConfirmationExitForm : Form
    {
        public ConfirmationExitForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
