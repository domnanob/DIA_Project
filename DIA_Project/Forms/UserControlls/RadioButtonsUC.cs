using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIA_Project.Forms.User_Controlls
{
    public partial class RadioButtonsUC : UserControl
    {
        public RadioButtonsUC()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
