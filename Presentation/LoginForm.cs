using CopyBase.Domain;
using CopyBase.Domain.Interfaces;
using System.Drawing.Text;
using System.Drawing;
using System.Runtime.InteropServices;

namespace CopyBase
{
    public partial class LoginForm : Form
    {
        private readonly ILoginManager _loginManager = new LoginManager();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public LoginForm()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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