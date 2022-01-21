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
            CurrentUser = u;
        }
        Users CurrentUser = new Users();
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

        private void Panels_MouseClick(object sender, MouseEventArgs e)
        {
            var Pnl = sender as Panel;
            int price = 0;
            string item = string.Empty;
            switch (Pnl.Name)
            {
                case "Panel1":
                    price = int.Parse(Panel1PriceL.Text);
                    item = Panel1Text.Text + "-et";
                    break;
                case "Panel2":
                    price = int.Parse(Panel2PriceL.Text);
                    item = Panel2Text.Text + "-t";
                    break;
                case "Panel3":
                    price = int.Parse(Panel3PriceL.Text);
                    item = Panel3Text.Text + "-t";
                    break;
                case "Panel4":
                    price = int.Parse(Panel4PriceL.Text);
                    item = Panel4Text.Text + "-et";
                    break;
                default:
                    break;
            }
            WarningMessageForm WMF = new WarningMessageForm("Biztosan meg szeretnéd vásárolni a(z) " + item + " " + price + " áron?");
            WMF.ShowDialog();
            if (WMF.DialogResult == DialogResult.Yes)
            {
                using (SQL sql = SQL.MySql())
                {
                    Users u = sql.users.Single(a => a.Username == CurrentUser.Username);
                    if (u.Money - price >= 0)
                    {
                        u.Money = u.Money - price;
                        PontL.Text = u.Money + string.Empty;
                        sql.SaveChanges();
                    }
                    else
                    {
                        ErrorMessageForm EMF = new ErrorMessageForm("Sajnos nincs elég pénzed!");
                        EMF.ShowDialog();
                    }
                }
            }
        }
    }
}
