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
        private List<Users> list = new List<Users>();
        public Boolean IsLoggedIn = false;
        public Users CurrentUser = new Users();
        private async Task _Load()
        {
            await Task.Run(() =>
            {
                using (SQL sql = SQL.MySql())
                {
                    foreach (Users u in sql.users)
                    {
                        list.Add(u);
                    }
                }
            });
        }
        private void Bejelentkezes() {
            List<string> Usersnames = new List<string>();
            foreach (Users u in list)
            {
                Usersnames.Add(u.Username);
            }
            if (Usersnames.Contains(FelhTB.Text))
            {
                using (SQL sql = SQL.MySql())
                {
                    Users u = sql.users.Single(a => a.Username == FelhTB.Text);
                    foreach (Users item in list)
                    {
                        bool result = SecurePasswordHasher.Verify(JelszoTB.Text, item.Password);
                        if (result)
                        {
                            u.LastLogon = DateTime.Now;
                            sql.SaveChanges();
                            if (u.RoleID == 1)
                            {
                                IsLoggedIn = true;
                                CurrentUser = u;
                                this.Close();
                                //MessageBox.Show("Sikeres bejelentkezés", "Login success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                /*
                                UserForm UF = new UserForm(u);
                                this.Hide();
                                UF.ShowDialog();
                                if (UF.DialogResult == DialogResult.OK)
                                {
                                    this.Show();
                                    FelhTB.Text = "";
                                    JelszoTB.Text = "";
                                    return;
                                }
                                this.Close();*/
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void JelszoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                Bejelentkezes();
            }
        }
    }
}
