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

namespace DIA_Project.Forms
{
    public partial class ProfileForm : Form
    {
        public ProfileForm(Users u)
        {
            InitializeComponent();
            CurrentUser = u;
            ReLoad();
            
        }
        Users CurrentUser = new Users();
        private void ReLoad() 
        {
            NameTb.Text = CurrentUser.Name;
            UserTB.Text = CurrentUser.Username;
            EmailTB.Text = CurrentUser.Email;
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
        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            MentesBtn.Enabled = true;
        }

        private void MentesBtn_Click(object sender, EventArgs e)
        {
            WarningMessageForm WMF = new WarningMessageForm("Biztosan Menteni akarod az adataid?");
            WMF.ShowDialog();
            if (WMF.DialogResult == DialogResult.Yes)
            {
                using (SQL sql = SQL.MySql())
                {
                    Users u = sql.users.Single(x => x.Username == CurrentUser.Username);
                    u.Name = NameTb.Text;
                    u.Username = UserTB.Text;
                    u.Email = EmailTB.Text;
                    u.ClassID = sql.classes.Single(x => x.Name == ClassCB.Items[ClassCB.SelectedIndex]).ID;
                    CurrentUser = u;
                    sql.SaveChanges();
                    Program.HF.CurrentUser = u;
                }
            }
        }

        private void MegseBtn_Click(object sender, EventArgs e)
        {
            ReLoad();
        }
    }
}
