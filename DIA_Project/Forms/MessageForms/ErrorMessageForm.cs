using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIA_Project.Forms
{
    public partial class ErrorMessageForm : Form
    {
        public ErrorMessageForm(string kerdes)
        {
            InitializeComponent();
            KerdesL.Text = kerdes;
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
