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

namespace DIA_Project.Forms.AdminForms
{
    public partial class AdminNewUserForm : Form
    {
        public AdminNewUserForm()
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            LoadingDataSources();
            ClassCB.SelectedIndex = 0;
        }
        private List<string> Usernames = new List<string>();
        private void LoadingDataSources()
        {
            using (SQL sql = SQL.MySql())
            {
                foreach (Classes c in sql.classes)
                {
                    ClassCB.Items.Add(c.Name);
                }
                foreach (var item in sql.users)
                {
                    Usernames.Add(item.Username);
                }
            }
            MentesBtn.Enabled = false;
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
        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            MentesBtn.Enabled = true;
            if ((sender as TextBox).Name == "PasswordTB")
            {
                Password2TB.Enabled = true;
            }
            if (string.IsNullOrEmpty(PasswordTB.Text))
            {
                Password2TB.Text = string.Empty;
                Password2TB.Enabled = false;
            }
        }
        private void ClassCB_TextChanged(object sender, EventArgs e)
        {
            MentesBtn.Enabled = true;
        }

        private void MentesBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTB.Text.Equals(Password2TB.Text))
            {
                if (JelszoEllenoriz(PasswordTB))
                {
                    if (ClassCB.SelectedIndex != 0)
                    {
                        if (!(UserTB.Text == "" || NameTb.Text == "" || EmailTB.Text == ""))
                        {
                            if (!Usernames.Contains(UserTB.Text))
                            {
                                using (SQL sql = SQL.MySql())
                                {
                                    User u = new User()
                                    {
                                        Name = NameTb.Text,
                                        Username = UserTB.Text,
                                        Email = EmailTB.Text,
                                        ClassID = sql.classes.Single(x => x.Name == ClassCB.Items[ClassCB.SelectedIndex].ToString()).ID,
                                        Password = SecurePasswordHasher.Hash(PasswordTB.Text),
                                        RoleID = 3
                                    };
                                    sql.users.Add(u);
                                    sql.SaveChanges();

                                    Purchase p = new Purchase()
                                    {
                                        UserID = UserTB.Text,
                                    };
                                    sql.purchases.Add(p);
                                    sql.SaveChanges();
                                    new SuccessMessageForm("Sikeres mentés!").ShowDialog();
                                    Program.AF.OpenChildForm(new AdminUsersForm());
                                }
                            }
                            else {
                                new ErrorMessageForm("Ez a felhasználónév már foglalt!").ShowDialog();
                            }
                        }
                        else {
                            new ErrorMessageForm("Kérlek tölts ki minden mezőt!").ShowDialog();
                        }
                    }
                    else {
                        new ErrorMessageForm("Válassz osztályt!").ShowDialog();
                    }
                }
                else {
                    new ErrorMessageForm("A jelszónak tartalmaznia kell legalább 1 nagybetűt és egy számot!").ShowDialog();
                }
            }
            else {
                new ErrorMessageForm("A két jelszó nem egyezik!").ShowDialog();
            }
            
        }

        private void MegseBtn_Click(object sender, EventArgs e)
        {
            Program.AF.OpenChildForm(new AdminUsersForm());
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void NewUserCodeBtn_Click(object sender, EventArgs e)
        {
            Program.AF.OpenChildForm(new AdminNewUserCodesForm());
        }
    }
}
