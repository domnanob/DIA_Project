using DIA_Project.Lib;
using DIA_Project.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DIA_Project.Forms.UserForms
{
    public partial class UserPurchasesForm : Form
    {
        public UserPurchasesForm(User u)
        {
            InitializeComponent();
            CurrentUser = u;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            LoadingDataSources();
        }
        private User CurrentUser = new User();
        public void LoadingDataSources()
        {
            using (SQL sql = SQL.MySql())
            {
                Purchase p = sql.purchases.Single(x => x.UserID == CurrentUser.Username);
                JavlTb.Text = IsPurchased(p.JavL);
                HaziFTb.Text = IsPurchased(p.HaziF);
                KesesITb.Text = IsPurchased(p.KesesI);
                JelesTb.Text = IsPurchased(p.Jeles);
            }

        }
        private string IsPurchased(int i)
        {
            if (i == 1)
            {
                return "Van!";
            }
            return "Nincs!";
        }
        private void TeacherTestsUsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }


        private void VisszaBtn_Click(object sender, EventArgs e)
        {
            Program.HF.OpenChildForm(new UserProfileForm(CurrentUser));
        }
    }
}
