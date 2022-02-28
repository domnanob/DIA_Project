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
    public partial class SelectClassMessageForm : Form
    {
        public SelectClassMessageForm()
        {
            InitializeComponent();
            ClassesCB.SelectedItem = "Osztályok";
            ReLoad();
        }
        private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private List<Classes> classes = new List<Classes>();
        public void ReLoad()
        {
            classes.Clear();
            using (SQL sql = SQL.MySql())
            {
                classes = sql.classes.ToList();
                foreach (var item in classes)
                {
                    ClassesCB.Items.Add(item.Name);
                }
            }
        }
        private string RandomDigits()
        {
            alphabet = alphabet.ToUpper();
            Random r = new Random();
            string token = "";
            for (int i = 0; i < 3; i++)
            {
                if (r.Next(2) == 1)
                {
                    token += alphabet[r.Next(alphabet.Length)];
                }
                else
                {
                    token += r.Next(10);
                }
            }
            return token;
        }
        private void GenerateBtn_Click(object sender, EventArgs e)
        { 
                TokenL.Text = RandomDigits()+"-"+RandomDigits();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ClassesCB.SelectedIndex != 0)
            {
                using (SQL sql = SQL.MySql())
                {
                    RegistrationTokens r = new RegistrationTokens() {
                        Token = TokenL.Text,
                        ClassID = sql.classes.Single(x => x.Name == ClassesCB.Items[ClassesCB.SelectedIndex].ToString()).ID
                    };
                    sql.registrationTokens.Add(r);
                    sql.SaveChanges();
                    this.Close();
                }
            }
            else {
                new ErrorMessageForm("Válassz osztályt!");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
