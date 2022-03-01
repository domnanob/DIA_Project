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

namespace DIA_Project.Forms.TeacherForms
{
    public partial class TeacherProfileForm : Form
    {
        public TeacherProfileForm(Teachers t)
        {
            InitializeComponent();
            CurrentTeacher = t;
            ReLoad();
            
        }
        Teachers CurrentTeacher = new Teachers();
        private void ReLoad() 
        {
            NameTb.Text = CurrentTeacher.Name;
            UserTB.Text = CurrentTeacher.Username;
            EmailTB.Text = CurrentTeacher.Email;
            PasswordTB.Text = string.Empty;
            Password2TB.Text = string.Empty;
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
                    Teachers t = sql.teachers.Single(x => x.Username == CurrentTeacher.Username);
                    t.Name = NameTb.Text;
                    t.Username = UserTB.Text;
                    t.Email = EmailTB.Text;
                    CurrentTeacher = t;
                    sql.SaveChanges();
                    Program.TF.CurrentTeacher = t;
                    new SuccessMessageForm("Sikeres mentés!").ShowDialog();
                    this.ReLoad();
                }
            }
            else {
                if (PasswordTB.Text.Equals(Password2TB.Text))
                {
                    if (JelszoEllenoriz(PasswordTB))
                    {
                        using (SQL sql = SQL.MySql())
                        {
                            Teachers t = sql.teachers.Single(x => x.Username == CurrentTeacher.Username);
                            t.Name = NameTb.Text;
                            t.Username = UserTB.Text;
                            t.Email = EmailTB.Text;
                            t.Password = SecurePasswordHasher.Hash(PasswordTB.Text);
                            sql.SaveChanges();
                            CurrentTeacher = t;
                            Program.TF.CurrentTeacher = t;
                            new SuccessMessageForm("Sikeres mentés!").ShowDialog();
                            this.ReLoad();
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
        }

        private void MegseBtn_Click(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void TeacherProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PasswordTB.PasswordChar == '●')
            {
                pictureBox1.Image = Properties.Resources.visible;
                PasswordTB.PasswordChar = '\0';
            }
            else
            {
                pictureBox1.Image = Properties.Resources.visibility;
                PasswordTB.PasswordChar = '●';
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Password2TB.PasswordChar == '●')
            {
                pictureBox6.Image = Properties.Resources.visible;
                Password2TB.PasswordChar = '\0';
            }
            else
            {
                pictureBox6.Image = Properties.Resources.visibility;
                Password2TB.PasswordChar = '●';
            }
        }
    }
}
