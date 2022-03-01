using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIA_Project.Lib;

namespace DIA_Project.Forms.CommonForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            button1.Region = Region.FromHrgn(BorderRadius.CreateRoundRectRgn(0, 0, button1.Width,
            button1.Height, 10, 10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.HF != null)
            {
                Program.HF.ImitateClick("InfoBtn");
            }
            else if (Program.AF != null)
            {
                Program.AF.ImitateClick("InfoBtn");
            }
            else if (Program.TF != null)
            {
                Program.TF.ImitateClick("InfoBtn");
            }
        }
    }
}
