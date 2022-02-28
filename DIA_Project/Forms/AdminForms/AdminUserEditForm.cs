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
    public partial class AdminUserEditForm : Form
    {
        public AdminUserEditForm(Users u)
        {
            InitializeComponent();
            CurrentUser = u;
            ReLoad();
        }
        Users CurrentUser = new Users();
        private void ReLoad() //async
        {
            NameTb.Text = CurrentUser.Name;
            UserTB.Text = CurrentUser.Username;
            EmailTB.Text = CurrentUser.Email;
            PasswordTB.Text = string.Empty;
            Password2TB.Text = string.Empty;
            EnabledCb.Checked = (CurrentUser.Enable == 1)? true : false;
            MoneyTb.Text = CurrentUser.Money + " Pont";
            ClassCB.Items.Clear();
            using (SQL sql = SQL.MySql())
            {
                foreach (Classes c in sql.classes)
                {
                    ClassCB.Items.Add(c.Name);
                }
                ClassCB.SelectedItem = sql.classes.Single(x => x.ID == CurrentUser.ClassID).Name;
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
            if (string.IsNullOrEmpty(PasswordTB.Text))
            {
                using (SQL sql = SQL.MySql())
                {
                    Users u = sql.users.Single(x => x.Username == CurrentUser.Username);
                    u.Name = NameTb.Text;
                    u.Username = UserTB.Text;
                    u.Email = EmailTB.Text;
                    u.ClassID = sql.classes.Single(x => x.Name == ClassCB.Items[ClassCB.SelectedIndex].ToString()).ID;
                    u.Enable = (EnabledCb.Checked)? 1 : 0;
                    u.Money = int.Parse(MoneyTb.Text.Replace(" Pont", ""));
                    CurrentUser = u;
                    sql.SaveChanges();
                    Program.AF.CurrentUser = u;
                }
                new SuccessMessageForm("Sikeres mentés!").ShowDialog();
                Program.AF.ImitateClick("UsersBtn");
            }
            else {
                if (PasswordTB.Text.Equals(Password2TB.Text))
                {
                    if (JelszoEllenoriz(PasswordTB))
                    {
                        using (SQL sql = SQL.MySql())
                        {
                            Users u = sql.users.Single(x => x.Username == CurrentUser.Username);
                            u.Name = NameTb.Text;
                            u.Username = UserTB.Text;
                            u.Email = EmailTB.Text;
                            u.ClassID = sql.classes.Single(x => x.Name == ClassCB.Items[ClassCB.SelectedIndex].ToString()).ID;
                            u.Password = SecurePasswordHasher.Hash(PasswordTB.Text);
                            u.Enable = (EnabledCb.Checked) ? 1 : 0;
                            u.Money = int.Parse(MoneyTb.Text.Replace(" Pont", ""));
                            CurrentUser = u;
                            sql.SaveChanges();
                            Program.AF.CurrentUser = u;
                        }
                        new SuccessMessageForm("Sikeres mentés!").ShowDialog();
                        Program.AF.ImitateClick("UsersBtn");
                    }
                    else {
                        new ErrorMessageForm("A jelszónak tartalmaznia kell legalább egy nagybetűt és egy számot!").ShowDialog();
                    }
                }
                else {
                    new ErrorMessageForm("A két jelszó nem egyezik!").ShowDialog();
                }
            }
        }

        private void MegseBtn_Click(object sender, EventArgs e)
        {
            Program.AF.ImitateClick("UsersBtn");
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void PurchasesBtn_Click(object sender, EventArgs e)
        {
            Program.AF.OpenChildForm(new AdminUserPurchasesForm(CurrentUser));
        }
    }
}
