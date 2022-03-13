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


namespace DIA_Project.Forms.CommonForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            _Load().GetAwaiter();
        }
        private List<string> Ulist = new List<string>();
        private List<string> Tlist = new List<string>();
        public User CurrentUser = new User();
        public Teacher CurrentTeacher = new Teacher();
        public RegistrationToken CurrentToken = new RegistrationToken();
        public bool IsServerRunning = false;
        public bool IsLoggedIn = false;
        private async Task _Load()
        {
            await Task.Run(() =>
            {
                try
                {
                    using (SQL sql = SQL.MySql())
                    {
                        Ulist = sql.users.Select(x => x.Username).ToList();
                        Tlist = sql.teachers.Select(x => x.Username).ToList();
                    }
                    IsServerRunning = true;
                }
                catch (Exception)
                {
                    new ErrorMessageForm("Valami hiba történt!").ShowDialog();
                }
            });
        }
        private void Bejelentkezes() {
            if (Ulist.Contains(FelhTB.Text))
            {
                using (SQL sql = SQL.MySql())
                {
                    User u = sql.users.Single(a => a.Username == FelhTB.Text);
                    bool result = SecurePasswordHasher.Verify(JelszoTB.Text, u.Password);
                    if (result && u.Enable == 1)
                    {
                        u.LastLogon = DateTime.Now;
                        sql.SaveChanges();
                        IsLoggedIn = true;
                        CurrentUser = u;
                        this.Close();
                    }
                    else
                    {
                        new ErrorMessageForm("Hibás felhasználónév vagy jelszó!").ShowDialog();
                        JelszoTB.Text = string.Empty;
                    }                    
                }
            }
            else if (Tlist.Contains(FelhTB.Text))
            {
                using (SQL sql = SQL.MySql())
                {
                    Teacher t = sql.teachers.Single(a => a.Username == FelhTB.Text);
                    bool result = SecurePasswordHasher.Verify(JelszoTB.Text, t.Password);
                    if (result && t.Enable == 1)
                    {
                        t.LastLogon = DateTime.Now;
                        sql.SaveChanges();
                        IsLoggedIn = true;
                        CurrentTeacher = t;
                        this.Close();
                    }
                    else
                    {
                        new ErrorMessageForm("Hibás felhasználónév vagy jelszó!").ShowDialog();
                        JelszoTB.Text = string.Empty;
                    }
                }
            }
            else
            {
                new ErrorMessageForm("Hibás felhasználónév vagy jelszó!").ShowDialog();
                JelszoTB.Text = string.Empty;
            }
        }
        private void BejelentkezesBtn_Click(object sender, EventArgs e)
        {
            if (IsServerRunning)
            {
                Bejelentkezes();
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            FrameMover.ReleaseCapture();
            FrameMover.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BejelentkezesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void Enter_Press(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (IsServerRunning)
                {
                    Bejelentkezes();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (JelszoTB.PasswordChar == '●')
            {
                pictureBox4.Image = Properties.Resources.visible;
                JelszoTB.PasswordChar = '\0';
            }
            else {
                pictureBox4.Image = Properties.Resources.visibility;
                JelszoTB.PasswordChar = '●';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationTokenMessageForm RTF = new RegistrationTokenMessageForm();
            RTF.ShowDialog();
            if (RTF.DialogResult == DialogResult.Yes)
            {
                this.Hide();
                new RegistrationForm(CurrentToken).ShowDialog();
                this.Show();
                _Load().GetAwaiter();
            }
        }
    }
}
