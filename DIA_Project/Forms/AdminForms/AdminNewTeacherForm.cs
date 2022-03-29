using DIA_Project.Lib;
using DIA_Project.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DIA_Project.Forms.AdminForms
{
    public partial class AdminNewTeacherForm : Form
    {
        public AdminNewTeacherForm()
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            ReLoad();
        }
        private List<string> TeacherUsernames = new List<string>();
        private void ReLoad()
        {
            MentesBtn.Enabled = false;
            foreach (var item in SQL.MySql().teachers)
            {
                TeacherUsernames.Add(item.Name);
            }
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

        private void MentesBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTB.Text) || string.IsNullOrEmpty(UserTB.Text) || string.IsNullOrEmpty(NameTb.Text) || string.IsNullOrEmpty(EmailTB.Text))
            {
                new ErrorMessageForm("Tölts mi minden mezőt!").ShowDialog();
                return;
            }
            else
            {
                if (PasswordTB.Text.Equals(Password2TB.Text))
                {
                    if (JelszoEllenoriz(PasswordTB))
                    {
                        if (!TeacherUsernames.Contains(UserTB.Text))
                        {
                            using (SQL sql = SQL.MySql())
                            {
                                Teacher t = new Teacher()
                                {
                                    Username = UserTB.Text,
                                    Name = NameTb.Text,
                                    Email = EmailTB.Text,
                                    Enable = 1,
                                    Password = SecurePasswordHasher.Hash(PasswordTB.Text),
                                };
                                sql.teachers.Add(t);
                                sql.SaveChanges();
                                new SuccessMessageForm("Sikeres mentés! Válasz neki munkakört!").ShowDialog();
                                Program.AF.OpenChildForm(new AdminTeachersForm());
                            }
                        }
                        else
                        {
                            new ErrorMessageForm("Ez a felhasználónév már foglalt!").ShowDialog();
                            return;
                        }
                    }
                    else
                    {
                        new ErrorMessageForm("A jelszónak tartalmaznia kell legalább egy nagybetűt és egy számot!").ShowDialog();
                        return;
                    }
                }
                else
                {
                    new ErrorMessageForm("A két jelszó nem egyezik!").ShowDialog();
                    return;
                }
            }
        }

        private void MegseBtn_Click(object sender, EventArgs e)
        {
            Program.AF.ImitateClick("TeachersBtn");
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

    }
}
