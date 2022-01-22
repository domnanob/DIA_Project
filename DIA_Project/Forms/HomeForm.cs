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
using DIA_Project.Models;

namespace DIA_Project.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm(Users CU)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            NavArrowP.Height = HomeBtn.Height;
            NavArrowP.Top = HomeBtn.Top;
            NavArrowP.Left = HomeBtn.Left;
            HomeBtn.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new DashBoardForm());
            CurrentUser = CU;
        }
        public Users CurrentUser = new Users();
        private Form currentChildForm;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != childForm)
            {
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                DesktopP.Controls.Add(childForm);
                DesktopP.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            WarningMessageForm WMF = new WarningMessageForm("Biztosan ki szeretnél lépni?");
            WMF.ShowDialog();
            if (WMF.DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else {
                WindowState = FormWindowState.Normal;
            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            FrameMover.ReleaseCapture();
            FrameMover.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LogoutBtn.BackColor = Color.FromArgb(46, 51, 73);
            WarningMessageForm WMF = new WarningMessageForm("Biztosan ki szeretnél jelentkezni?");
            WMF.ShowDialog();
            if (WMF.DialogResult == DialogResult.Yes)
            {
                this.Hide();
                BejelentkezesForm BF = new BejelentkezesForm();
                BF.ShowDialog();
                HomeForm HF = new HomeForm(BF.CurrentUser);
                HF.ShowDialog();
                this.Close();
            }
            LogoutBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            NavArrowP.Height = HomeBtn.Height;
            NavArrowP.Top = HomeBtn.Top;
            NavArrowP.Left = HomeBtn.Left;
            HomeBtn.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new DashBoardForm());
        }

        private void DolgozatokBtn_Click(object sender, EventArgs e)
        {
            NavArrowP.Height = DolgozatokBtn.Height;
            NavArrowP.Top = DolgozatokBtn.Top;
            NavArrowP.Left = DolgozatokBtn.Left;
            DolgozatokBtn.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new DolgozatokForm());
        }

        private void ProfilBtn_Click(object sender, EventArgs e)
        {
            NavArrowP.Height = ProfilBtn.Height;
            NavArrowP.Top = ProfilBtn.Top;
            NavArrowP.Left = ProfilBtn.Left;
            ProfilBtn.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new ProfileForm(CurrentUser));
        }

        private void BoltBtn_Click(object sender, EventArgs e)
        {
            NavArrowP.Height = BoltBtn.Height;
            NavArrowP.Top = BoltBtn.Top;
            NavArrowP.Left = BoltBtn.Left;
            BoltBtn.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new BoltForm(CurrentUser));
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            NavArrowP.Height = InfoBtn.Height;
            NavArrowP.Top = InfoBtn.Top;
            NavArrowP.Left = InfoBtn.Left;
            InfoBtn.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new InfoForm());
        }

        private void HomeBtn_Leave(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void DolgozatokBtn_Leave(object sender, EventArgs e)
        {
            DolgozatokBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void ProfilBtn_Leave(object sender, EventArgs e)
        {
            ProfilBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BoltBtn_Leave(object sender, EventArgs e)
        {
            BoltBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void InfoBtn_Leave(object sender, EventArgs e)
        {
            InfoBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashBoardForm());
        }
    }
}
