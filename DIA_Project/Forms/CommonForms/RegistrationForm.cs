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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm(RegistrationTokens r)
        {
            InitializeComponent();
            _Load().GetAwaiter();
            CurrentToken = r;
        }
        private RegistrationTokens CurrentToken = new RegistrationTokens();
        private List<string> Ulist = new List<string>();
        private List<string> Tlist = new List<string>();
        private async Task _Load()
        {
            await Task.Run(() =>
            {
                try
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
                }
                catch (Exception)
                {
                    new ErrorMessageForm("Valami hiba történt!").ShowDialog();
                }
            });
        }
        private bool JelszoEllenoriz(TextBox t1)
        {
            foreach (char c in t1.Text)
            {
                if (char.IsUpper(c))
                {
                    foreach (char c2 in t1.Text)
                    {
                        if (char.IsDigit(c2))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private void Regisztracio() {
            if (!(Ulist.Contains(FelhTB.Text) || Tlist.Contains(FelhTB.Text)))
            {
                if (JelszoTB.Text.Equals(JelszoIsmTb.Text))
                {
                    if (JelszoEllenoriz(JelszoTB))
                    {
                        using (SQL sql = SQL.MySql())
                        {
                            Users u = new Users() {
                                Username = FelhTB.Text,
                                Password = SecurePasswordHasher.Hash(JelszoTB.Text),
                                Email = EmailTb.Text,
                                Name = NevTb.Text,
                                ClassID = CurrentToken.ClassID
                            };
                            sql.users.Add(u);
                            sql.SaveChanges();

                            Purchases p = new Purchases()
                            {
                                UserID = FelhTB.Text,
                            };
                            sql.purchases.Add(p);
                            sql.SaveChanges();
                            new SuccessMessageForm("Sikeres regisztráció!").ShowDialog();
                            this.Close();
                        }
                    }
                    else {
                        new ErrorMessageForm("A jelszónak tartalmaznia kell legalább egy nagybetűt és egy számot!").ShowDialog();
                    }
                }
                else {
                    new ErrorMessageForm("A két jelszó nem egyezik!").ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Ez a felhasználónév már foglalt!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                JelszoTB.Text = string.Empty;
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

        private void RegisztracioBtn_Click(object sender, EventArgs e)
        {
            if (FelhTB.Text != string.Empty && JelszoTB.Text != string.Empty && JelszoIsmTb.Text != string.Empty && NevTb.Text != string.Empty && EmailTb.Text != string.Empty)
            {
                Regisztracio();
            }
            else {
                new ErrorMessageForm("Nem töltöttél ki minden mezőt!").ShowDialog();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (JelszoTB.PasswordChar == '●')
            {
                pictureBox7.Image = Properties.Resources.visible;
                JelszoIsmTb.PasswordChar = '\0';
            }
            else
            {
                pictureBox7.Image = Properties.Resources.visibility;
                JelszoIsmTb.PasswordChar = '●';
            }
        }

        private void VisszaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
