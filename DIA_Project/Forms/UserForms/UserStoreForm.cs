using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIA_Project.Models;
using DIA_Project.Lib;

namespace DIA_Project.Forms.UserForms
{
    public partial class UserStoreForm : Form
    {
        public UserStoreForm(User u)
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            PontL.Text = u.Money + "";
            CurrentUser = u;
        }
        User CurrentUser = new User();

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
            Vasarlas(Pnl);
        }

        private void Labels_Click(object sender, EventArgs e)
        {
            var Lb = sender as Label;
            switch (Lb.Name)
            {
                case "Panel1Text":
                    Vasarlas(Panel1);
                    break;
                case "Panel2Text":
                    Vasarlas(Panel2);
                    break;
                case "Panel3Text":
                    Vasarlas(Panel3);
                    break;
                case "Panel4Text":
                    Vasarlas(Panel4);
                    break;
                default:
                    break;
            }
        }
        private void Vasarlas(Panel Pnl)
        {
            int price = 0;
            string item = string.Empty;
            int itemNumber = 0;
            bool IsErrorOccured = false;
            Purchase p = SQL.MySql().purchases.Single(x => x.UserID == CurrentUser.Username);
            switch (Pnl.Name)
            {
                case "Panel1": //JavL
                    price = int.Parse(Panel1PriceL.Text);
                    item = Panel1Text.Text + "-et";
                    itemNumber = 1;
                    if (p.JavL == 1)
                    {
                        IsErrorOccured = true;
                    } 
                    break;
                case "Panel2": //HaziF
                    price = int.Parse(Panel2PriceL.Text);
                    item = Panel2Text.Text + "-t";
                    itemNumber = 2;
                    if (p.HaziF == 1)
                    {
                        IsErrorOccured = true;
                    } 
                    p.HaziF = 1;
                    break;
                case "Panel3": //KesesI
                    price = int.Parse(Panel3PriceL.Text);
                    item = Panel3Text.Text + "-t";
                    itemNumber = 3;
                    if (p.KesesI == 1)
                    {
                        IsErrorOccured = true;
                    } 
                    break;
                case "Panel4": //Jeles
                    price = int.Parse(Panel4PriceL.Text);
                    item = Panel4Text.Text + "-et";
                    itemNumber = 4;
                    if (p.Jeles == 1)
                    {
                        IsErrorOccured = true;
                    } 
                    break;
                default:
                    break;
            }
            if (IsErrorOccured)
            {
                new ErrorMessageForm("Ilyen elemet már vásároltál, előbb használd el!").Show();
                return;
            }
            WarningMessageForm WMF = new WarningMessageForm("Biztosan meg szeretnéd vásárolni a(z) " + item + " " + price + " áron?");
            WMF.ShowDialog();
            if (WMF.DialogResult == DialogResult.Yes)
            {
                Buying(price, itemNumber);
            }
        }
        private void Buying(int price, int item)
        {
            using (SQL sql = SQL.MySql())
            {
                User u = sql.users.Single(a => a.Username == CurrentUser.Username);
                Purchase p = sql.purchases.Single(x => x.UserID == CurrentUser.Username);
                if (u.Money - price >= 0)
                {
                    switch (item)
                    {
                        case 1:
                            p.JavL = 1;
                            break;
                        case 2:
                            p.HaziF = 1;
                            break;
                        case 3:
                            p.KesesI = 1;
                            break;
                        case 4:
                            p.Jeles = 1;
                            break;
                        default:
                            break;
                    }
                    u.Money = u.Money - price;
                    sql.SaveChanges();
                    Program.HF.CurrentUser = u;
                    new SuccessMessageForm("Sikeres vásárlás!").ShowDialog();
                    Program.HF.ImitateClick("BoltBtn");
                }
                else
                {
                    ErrorMessageForm EMF = new ErrorMessageForm("Sajnos nincs elég pénzed!");
                    EMF.ShowDialog();
                }
            }
        }

        private void BoltForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void UserBoltForm_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
