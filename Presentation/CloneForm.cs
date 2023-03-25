using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyBase.Domain;

namespace CopyBase
{
    public partial class CloneForm : Form
    {
        public CloneForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void clonedDbDir_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void CloneForm_Load(object sender, EventArgs e)
        {
            //Set user variables
            fullNameLabel.Text = User.FullName;
            emailLabel.Text = User.Email;

            //Set default db variables
            clonedDbDirTextBox.Text = $"C:\\Users\\{User.Username}\\AppData\\Local\\CopyBase";
        }
        
        private void cloneButton_Click(object sender, EventArgs e)
        {
            if (CloneManager.UserHasPermission(DbToCloneMenu.Text, User.Email))
            {
                //Check if all fields have text

                CloneManager.CloneDatabase(DbToCloneMenu.Text,clonedDbNameTextBox.Text,clonedDbDirTextBox.Text);

                //Switch to RunningCloneForm
                RunningCloneForm rcf = new RunningCloneForm();
                rcf.StartPosition = FormStartPosition.Manual;
                rcf.Location = this.Location;
                rcf.Show();
                this.Hide();
            }
        }

        private void CloneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void fullNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void profilePicture_Click(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloneForm_Load_1(object sender, EventArgs e)
        {

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

        private void clonedDbDirTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dbToCloneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DbToCloneMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            clonedDbNameTextBox.Text = DbToCloneMenu.Text + "Clone";
        }

        private void environmentTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
