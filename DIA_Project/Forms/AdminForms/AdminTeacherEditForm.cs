using DIA_Project.Lib;
using DIA_Project.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DIA_Project.Forms.AdminForms
{
    public partial class AdminTeacherEditForm : Form
    {
        public AdminTeacherEditForm(Teacher t)
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            CurrentTeacher = t;
            ReLoad();
        }
        Teacher CurrentTeacher = new Teacher();
        private void ReLoad() //async
        {
            NameTb.Text = CurrentTeacher.Name;
            UserTB.Text = CurrentTeacher.Username;
            EmailTB.Text = CurrentTeacher.Email;
            PasswordTB.Text = string.Empty;
            Password2TB.Text = string.Empty;
            EnabledCb.Checked = (CurrentTeacher.Enable == 1)? true : false;
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

        private void MentesBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTB.Text))
            {
                using (SQL sql = SQL.MySql())
                {
                    Teacher t = sql.teachers.Single(x => x.Username == CurrentTeacher.Username);
                    t.Name = NameTb.Text;
                    t.Username = UserTB.Text;
                    t.Email = EmailTB.Text;
                    t.Enable = (EnabledCb.Checked)? 1 : 0;
                    CurrentTeacher = t;
                    sql.SaveChanges();
                }
                new SuccessMessageForm("Sikeres mentés!").ShowDialog();
                Program.AF.ImitateClick("TeachersBtn");
            }
            else {
                if (PasswordTB.Text.Equals(Password2TB.Text))
                {
                    if (JelszoEllenoriz(PasswordTB))
                    {
                        using (SQL sql = SQL.MySql())
                        {
                            Teacher t = sql.teachers.Single(x => x.Username == CurrentTeacher.Username);
                            t.Name = NameTb.Text;
                            t.Username = UserTB.Text;
                            t.Email = EmailTB.Text;
                            t.Password = SecurePasswordHasher.Hash(PasswordTB.Text);
                            t.Enable = (EnabledCb.Checked) ? 1 : 0;
                            CurrentTeacher = t;
                            sql.SaveChanges();
                        }
                        new SuccessMessageForm("Sikeres mentés!").ShowDialog();
                        Program.AF.ImitateClick("TeachersBtn");
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
            Program.AF.ImitateClick("TeachersBtn");
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }


        private void PositionBtn_Click(object sender, EventArgs e)
        {
            Program.AF.OpenChildForm(new AdminTeacherPositionsForm(CurrentTeacher));
        }

        private void EnabledCb_CheckedChanged(object sender, EventArgs e)
        {
            MentesBtn.Enabled = true;
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
