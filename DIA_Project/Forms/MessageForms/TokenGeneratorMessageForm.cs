using DIA_Project.Lib;
using DIA_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DIA_Project.Forms
{
    public partial class TokenGeneratorMessageForm : Form
    {
        public TokenGeneratorMessageForm()
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            ReLoad();
        }
        private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private List<string> Tokens = new List<string>();
        public void ReLoad()
        {
            using (SQL sql = SQL.MySql())
            {
                ClassesCB.DataSource = sql.classes.Select(x => x.Name).ToList();
                Tokens = sql.registrationTokens.Select(x => x.Token).ToList();
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
            while (!Tokens.Contains(TokenL.Text))
            {
                TokenL.Text = RandomDigits() + "-" + RandomDigits();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!Tokens.Contains(TokenL.Text))
            {
                using (SQL sql = SQL.MySql())
                {
                    RegistrationToken r = new RegistrationToken()
                    {
                        Token = TokenL.Text,
                        ClassID = sql.classes.Single(x => x.Name == ClassesCB.Items[ClassesCB.SelectedIndex].ToString()).ID
                    };
                    sql.registrationTokens.Add(r);
                    sql.SaveChanges();
                    this.Close();
                }
            }
            else
            {
                new ErrorMessageForm("Hibás kód, generálj újat!").Show();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyPb_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TokenL.Text);
            label1.Visible = true;
        }
    }
}
