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
    public partial class AdminUserPurchasesForm : Form
    {
        public AdminUserPurchasesForm(User u)
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            CurrentUser = u;
            LoadingDataSources();
        }
        private User CurrentUser = new User();
        public void LoadingDataSources() {
            using (SQL sql = SQL.MySql())
            {
                Purchase p = sql.purchases.Single(x => x.UserID == CurrentUser.Username);
                JavLCb.SelectedIndex = p.JavL;
                HaziFCb.SelectedIndex = p.HaziF;
                KesesICb.SelectedIndex = p.KesesI;
                JelesECb.SelectedIndex = p.Jeles;
            }
            
        }
        private void TeacherTestsUsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }


        private void VisszaBtn_Click(object sender, EventArgs e)
        {
            Program.AF.OpenChildForm(new AdminUsersForm());
        }

        private void MentesBtn_Click(object sender, EventArgs e)
        {
            using (SQL sql = SQL.MySql())
            {
                Purchase p = sql.purchases.Single(x => x.UserID == CurrentUser.Username);
                p.JavL = JavLCb.SelectedIndex;
                p.HaziF = HaziFCb.SelectedIndex;
                p.KesesI = KesesICb.SelectedIndex;
                p.Jeles = JelesECb.SelectedIndex;

                sql.SaveChanges();
                new SuccessMessageForm("Sikeresen elmentetted az adatokat!").ShowDialog();
                Program.AF.OpenChildForm(new AdminUsersForm());
            }
        }
    }
}
