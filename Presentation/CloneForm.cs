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
        
        private void cloneButton_Click(object sender, EventArgs e) {
            if (_cloneManager.UserHasPermission(DbToCloneMenu.Text, User.Email))
            {
                //Check if all fields have text
                if (DbToCloneMenu.Text.Equals("") || clonedDbNameTextBox.Text.Equals("") || clonedDbDirTextBox.Text.Equals(""))
                {
                    if (DbToCloneMenu.Text.Equals(""))
                    {
                        DbToCloneMenu.BorderColor = Color.Red;
                    }
                    if (clonedDbNameTextBox.Text.Equals(""))
                    {
                        clonedDbNameTextBox.BorderColor = Color.Red;
                    }
                    if (clonedDbDirTextBox.Text.Equals(""))
                    {
                        clonedDbDirTextBox.BorderColor = Color.Red;
                    }

                    //Set up a timer to change the border color back to gray after 1 second
                    var timer = new System.Windows.Forms.Timer();
                    timer.Interval = 2000;
                    timer.Tick += (s, args) =>
                    {
                        DbToCloneMenu.BorderColor = Color.Gray;
                        clonedDbNameTextBox.BorderColor = Color.Gray;
                        clonedDbDirTextBox.BorderColor = Color.Gray;
                        timer.Stop();
                    };
                    timer.Start();
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

        private void DbToCloneMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            clonedDbNameTextBox.Text = DbToCloneMenu.Text + "Clone";
        }

        private void CloneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void folderIcon_Click(object sender, EventArgs e)
        {
            using (var browser = new FolderBrowserDialog())
            {
                browser.RootFolder = Environment.SpecialFolder.Desktop;
                browser.ShowNewFolderButton = true;

                if (browser.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = browser.SelectedPath;
                    clonedDbDirTextBox.Text = folderPath;
                }
            }
        }

        private void logoutIcon_Click(object sender, EventArgs e)
        {
            //Switch to LoginForm
            LoginForm lf = new LoginForm();
            lf.StartPosition = FormStartPosition.Manual;
            lf.Location = this.Location;
            lf.Show();
            this.Hide();
        }
    }
}
