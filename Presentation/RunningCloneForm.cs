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
using CopyBase.Presentation;

namespace CopyBase
{
    public partial class RunningCloneForm : Form
    {
        public RunningCloneForm()
        {
            InitializeComponent();
        }

        private void ClonedDbPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void RunningCloneForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteCloneButton_Click(object sender, EventArgs e)
        {
            //Confirmation
            ConfirmationDeleteForm cdf = new ConfirmationDeleteForm();
            DialogResult result = cdf.ShowDialog();

            if (result == DialogResult.OK)
            {
                CloneManager.DeleteClonedDatabase();

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
            Application.Exit();
            ////Confirmation
            //ConfirmationDeleteForm cdf = new ConfirmationDeleteForm();
            //DialogResult result = cdf.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    Application.Exit();
            //}
            //else
            //{
            //    e.Cancel = true; // cancel the form closing
            //}
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            CloneManager.OpenClonedDatabase();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            CloneManager.ResetClonedDatabase();
        }
    }
}
