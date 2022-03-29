using System;
using System.Drawing;
using System.Windows.Forms;

namespace DIA_Project.Forms.User_Controlls
{
    public partial class RadioButtonsUC : UserControl
    {
        public RadioButtonsUC()
        {
            InitializeComponent();
        }
        public Tuple<string, bool> GetAnswer()
        {
            return Tuple.Create(AnswerTB.Text, CorrectCb.Checked);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
