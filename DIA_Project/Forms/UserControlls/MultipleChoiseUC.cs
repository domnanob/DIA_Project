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
    public partial class MultipleChoiseUC : UserControl
    {
        public MultipleChoiseUC()
        {
            InitializeComponent();
        }
        RadioButtonsUC RBUC = new RadioButtonsUC()
        {
            Height = 55,
            Dock = DockStyle.Top
        };
        private void HozzaadasBtn_Click(object sender, EventArgs e)
        {
            RBUC = new RadioButtonsUC() {
                Height = 55,
                Dock = DockStyle.Top
            };
            RBUC.BackColorChanged += new System.EventHandler(this.radioButtonsuc_BackColorChanged);
            this.Height += 55;
            this.panel2.Height += 55;
            this.panel2.Controls.Add(RBUC);
        }

        private void radioButtonsuc_BackColorChanged(object sender, EventArgs e)
        {
            RadioButtonsUC Current = sender as RadioButtonsUC;
            this.panel2.Controls.Remove(Current);
            this.Height -= 55;
            this.panel2.Height -= 55;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
