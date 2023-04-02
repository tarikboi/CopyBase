using CopyBase.Domain;
using CopyBase.Domain.Interfaces;

namespace CopyBase
{
    public partial class LoginForm : Form
    {
        private readonly ILoginManager _loginManager = new LoginManager();

        public LoginForm()
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

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}