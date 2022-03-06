using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIA_Project.Lib;
using DIA_Project.Models;

namespace DIA_Project.Forms
{
    public partial class RegistrationTokenMessageForm : Form
    {
        public RegistrationTokenMessageForm()
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            LoadingDataSources();
        }
        private List<RegistrationToken> registrationTokens = new List<RegistrationToken>();
        private void LoadingDataSources() {
            using (SQL sql = SQL.MySql())
            {
                registrationTokens = sql.registrationTokens.ToList();
            }
        }
        private void OKBtn_Click(object sender, EventArgs e)
        {
            string CurrentToken = TokenTb.Text.Replace("-", "");
            foreach (var item in registrationTokens)
            {

                if (item.Token.Replace("-","") == CurrentToken)
                {
                    Program.BF.CurrentToken = item;
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                    return;
                }
            }
            new ErrorMessageForm("Hibás regisztrációs kód!").ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
