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
        private void Panels_Paint(object sender, PaintEventArgs e)
        {
            var Pnl = sender as Panel;
            Pnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Pnl.Width,
            Pnl.Height, 30, 30));
        }

        private void InfoPb_Enter(object sender, EventArgs e)
        {
            var Pb = sender as PictureBox;
            switch (Pb.Name)
            {
                case "Info1Pb":
                    InfoL.Text = "Info: Lehetőséget biztosít a javításra választott formában! Lehet az felelet, írásbeli vagy beadandó is.";
                    break;
                case "Info2Pb":
                    InfoL.Text = "Info: Egyszeri felmentést biztosít egy elmaradott házifeladat alól! Használni lehet jövőbeli elmaradásra vagy múltbélire is.";
                    break;
                case "Info3Pb":
                    InfoL.Text = "Info: Egyszeri igazolást biztosít egy késés alól! A késett idő nem haladhatja meg a 10 percet!";
                    break;
                case "Info4Pb":
                    InfoL.Text = "Info: Egy 5-ös, 100%-os érdemjegy kerül a naplóba órai munka néven!";
                    break;
                default:
                    return;
            }
        }
    }
}
