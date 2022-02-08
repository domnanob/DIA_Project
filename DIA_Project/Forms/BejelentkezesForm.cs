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


namespace DIA_Project.Forms
{
    public partial class BejelentkezesForm : Form
    {
        public BejelentkezesForm()
        {
            InitializeComponent();
            _Load().GetAwaiter();
        }
        private List<string> Ulist = new List<string>();
        private List<string> Tlist = new List<string>();
        public Boolean IsLoggedIn = false;
        public Users CurrentUser = new Users();
        public Teachers CurrentTeacher = new Teachers();
        private async Task _Load()
        {
            await Task.Run(() =>
            {
                using (SQL sql = SQL.MySql())
                {
                    foreach (Users u in sql.users)
                    {
                        Ulist.Add(u.Username);
                    }
                    foreach (Teachers t in sql.teachers)
                    {
                        Tlist.Add(t.Username);
                    }
                }
            });
        }
        private void Bejelentkezes() {
            if (Ulist.Contains(FelhTB.Text))
            {
                using (SQL sql = SQL.MySql())
                {
                    Users u = sql.users.Single(a => a.Username == FelhTB.Text);
                    bool result = SecurePasswordHasher.Verify(JelszoTB.Text, u.Password);
                    if (result)
                    {
                        u.LastLogon = DateTime.Now;
                        sql.SaveChanges();
                        IsLoggedIn = true;
                        CurrentUser = u;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        JelszoTB.Text = string.Empty;
                    }                    
                }
            }
            else if (Tlist.Contains(FelhTB.Text))
            {
                using (SQL sql = SQL.MySql())
                {
                    Teachers t = sql.teachers.Single(a => a.Username == FelhTB.Text);
                    bool result = SecurePasswordHasher.Verify(JelszoTB.Text, t.Password);
                    if (result)
                    {
                        t.LastLogon = DateTime.Now;
                        sql.SaveChanges();
                        IsLoggedIn = true;
                        CurrentTeacher = t;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        JelszoTB.Text = string.Empty;
                    }
                }

            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                JelszoTB.Text = string.Empty;
            }
        }
        private void BejelentkezesBtn_Click(object sender, EventArgs e)
        {
            Bejelentkezes();
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
                Bejelentkezes();
            }
        }
    }
}
