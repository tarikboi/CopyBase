using CopyBase.Domain;
using CopyBase.Domain.Interfaces;

namespace CopyBase
{
    public partial class CloneForm : Form
    {
        private readonly ICloneManager _cloneManager = new CloneManager();

        public CloneForm()
        {
            InitializeComponent();
        }

        private void CloneForm_Load(object sender, EventArgs e)
        {
            //Set user variables
            fullNameLabel.Text = User.FullName;
            emailLabel.Text = User.Email;

            //Set default db variables
            clonedDbDirTextBox.Text = $"C:\\Users\\{User.Username}\\AppData\\Local\\CopyBase";

            //Other variables
            allFieldsErrorLabel.Text = "";
        }
        
        private void cloneButton_Click(object sender, EventArgs e)
        {
            if (_cloneManager.UserHasPermission(DbToCloneMenu.Text, User.Email))
            {
                //Check if all fields have text
                if (DbToCloneMenu.Text.Equals("") || clonedDbNameTextBox.Text.Equals("") || clonedDbDirTextBox.Text.Equals(""))
                {
                    allFieldsErrorLabel.Text = @"All fields must have a value!";
                }
                else
                {
                    _cloneManager.CloneDatabase(DbToCloneMenu.Text, clonedDbNameTextBox.Text, clonedDbDirTextBox.Text);

                    //Switch to RunningCloneForm
                    RunningCloneForm rcf = new RunningCloneForm();
                    rcf.StartPosition = FormStartPosition.Manual;
                    rcf.Location = this.Location;
                    rcf.Show();
                    this.Hide();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var browser = new FolderBrowserDialog())
            {
                browser.RootFolder = Environment.SpecialFolder.Desktop;
                browser.ShowNewFolderButton = true;

                if (browser.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = browser.SelectedPath;
                    clonedDbDirTextBox.Text =  folderPath;
                }
            }
        }

        private void DbToCloneMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            clonedDbNameTextBox.Text = DbToCloneMenu.Text + "Clone";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Switch to CloneForm
            LoginForm lf = new LoginForm();
            lf.StartPosition = FormStartPosition.Manual;
            lf.Location = this.Location;
            lf.Show();
            this.Hide();
        }
    }
}
