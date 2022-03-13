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
using DIA_Project.Forms.CommonForms;

namespace DIA_Project.Forms.TeacherForms
{
    public partial class TeacherHomeForm : Form
    {
        public TeacherHomeForm(Teacher CT)
        {
            InitializeComponent();

            //Teljesítmény javítás
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.CurrentTeacher = CT;

            NavArrowP.Height = HomeBtn.Height;
            NavArrowP.Top = HomeBtn.Top;
            NavArrowP.Left = HomeBtn.Left;

            NavButtons_Click(this.HomeBtn, EventArgs.Empty);
        }
        private Button CurrentNavBtn = new Button();
        public Teacher CurrentTeacher = new Teacher();
        private Form OldChildForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (OldChildForm != childForm)
            {
                if (OldChildForm != null)
                {
                    OldChildForm.Dispose();
                    OldChildForm.Close();
                }

                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.TopLevel = false;
                childForm.Dock = DockStyle.Fill;

                if (childForm.GetType() == new MainForm().GetType())
                {
                    //A főmenünek külön háttérképe van a felső panel miatt
                    DesktopP.BackgroundImage = Properties.Resources.WinFormBg2D;
                }
                else
                {
                    //A főmenüből kilépve megváltoztatja a háttérképet
                    if (OldChildForm.GetType() == new MainForm().GetType())
                    {
                        DesktopP.BackgroundImage = childForm.BackgroundImage;
                    }
                }
                DesktopP.Controls.Add(childForm);
                DesktopP.Tag = childForm;

                childForm.BringToFront();
                childForm.Show();

                OldChildForm = childForm;
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
                Program.FormLoader();
                this.Close();
            }
            LogoutBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ImitateClick("HomeBtn");
        }

        private void NavButtons_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            NavArrowP.Height = btn.Height;
            NavArrowP.Top = btn.Top;
            NavArrowP.Left = btn.Left;
            CurrentNavBtn.BackColor = Color.FromArgb(24, 30, 54);
            btn.BackColor = Color.FromArgb(46, 51, 73);
            CurrentNavBtn = btn;
            switch (btn.Name)
            {
                case "HomeBtn":
                    OpenChildForm(new MainForm());
                    break;
                case "DolgozatokBtn":
                    OpenChildForm(new TeacherTestsForm(CurrentTeacher));
                    break;
                case "ProfilBtn":
                    OpenChildForm(new TeacherProfileForm(CurrentTeacher));
                    break;
                case "ClassesBtn":
                    OpenChildForm(new TeacherClassesForm(CurrentTeacher));
                    break;
                case "InfoBtn":
                    OpenChildForm(new InfoForm());
                    break;
                default:
                    break;
            }
        }
        public void ImitateClick(string ButtonName)
        {
            NavButtons_Click(NavP.Controls.OfType<Button>().ToList().Single(x => x.Name == ButtonName), EventArgs.Empty);
        }

        private void TeacherHomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }
    }
}
