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
using DIA_Project.Models;

namespace DIA_Project.Forms
{
    public partial class BoltForm : Form
    {
        public BoltForm(Users u)
        {
            InitializeComponent();
            PontL.Text = u.Money + "";
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void buttons_Paint(object sender, PaintEventArgs e)
        {
            var btn = sender as Button;
            btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width,
            btn.Height, 30, 30));
        }
    }
}
