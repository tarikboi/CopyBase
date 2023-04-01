using CopyBase.Domain;
using System.DirectoryServices.AccountManagement;
using CopyBase.Data_Layer;
using CopyBase.Data_Layer.Interfaces;
using CopyBase.Domain.Interfaces;

namespace CopyBase
{
    public partial class LoginForm : Form
    {
        private readonly ILoginManager _loginManager = new LoginManager();

        public LoginForm(ILoginManager loginManager)
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            incorrectLoginText.Text = "";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (_loginManager.VerifyCredentials(emailTextBox.Text, passwordTextBox.Text))
            {
                _loginManager.CreateUser(emailTextBox.Text);

                if (rememberMeCheckBox.Checked)
                {
                    _loginManager.SetRememberMe(emailTextBox.Text);
                }

                //Create instance of ICloneManager
                //Switch to CloneForm
                CloneForm cf = new CloneForm();
                cf.StartPosition = FormStartPosition.Manual;
                cf.Location = this.Location;
                cf.Show();
                this.Hide();
            }
            else
            {
                incorrectLoginText.ForeColor = Color.Red;
                incorrectLoginText.Text = @"The email or password is incorrect!";
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}