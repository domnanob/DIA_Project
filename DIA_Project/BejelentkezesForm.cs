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

namespace DIA_Project
{
    public partial class BejelentkezesForm : Form
    {
        public BejelentkezesForm()
        {
            InitializeComponent();
            _Load().GetAwaiter();
        }
        private List<Users> list = new List<Users>();
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

        private void BejelentkezesBtn_Click(object sender, EventArgs e)
        {
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
                                MessageBox.Show("Sikeres bejelentkezés", "Login success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
