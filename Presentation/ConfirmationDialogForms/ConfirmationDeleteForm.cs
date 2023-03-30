using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyBase.Presentation
{
    public partial class ConfirmationDeleteForm : Form
    {
        public ConfirmationDeleteForm()
        {
            InitializeComponent();
        }

        private void deleteDatabaseLabel_Click(object sender, EventArgs e)
        {

        }

        private void deleteDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ConfirmationExitForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmationDeleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
