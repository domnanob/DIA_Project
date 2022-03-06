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
    public partial class TeacherTestsUsersForm : Form
    {
        public TeacherTestsUsersForm(Teacher t, Test e)
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
            CurrentTest = e;
            LoadingDataSources();
        }
        private Teacher CurrentTeacher = new Teacher();
        private Test CurrentTest = new Test();
        private List<UserTest> UT = new List<UserTest>();
        private List<FormattedUserTest> FUT = new List<FormattedUserTest>();
        public void LoadingDataSources() {
            using (SQL sql = SQL.MySql())
            {
                UT = sql.userTests.Where(x => x.TestID == CurrentTest.ID).ToList();
            }
            DGVLoad(UT);
        }
        void DGVLoad(List<UserTest> ut)
        {
            foreach (var item in ut)
            {
                FUT.Add(new FormattedUserTest(item));
            }
            UsersTestsDGV.DataSource = FUT;
            return;
        }

        private void DataGridHeaderChange(DataGridView dgv)
        {
            
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "Diák";
                dgv.Columns[2].HeaderText = "Leadási idő";
                dgv.Columns[3].HeaderText = "Állapot";
            }
        }
        private void PurchasesDGV_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridHeaderChange(UsersTestsDGV);
        }

        private void TeacherTestsUsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MegnyitasBtn_Click(object sender, EventArgs e)
        {
            if (new string[] { "Javításra vár!", "Kijavítva!" }.Contains(UsersTestsDGV.SelectedRows[0].Cells[3].Value.ToString()))
            {
                string SelectedUsername = UsersTestsDGV.SelectedRows[0].Cells[0].Value.ToString();
                List<User> alluser = new List<User>();
                foreach (var item in UT)
                {
                    alluser.Add(SQL.MySql().users.Single(x => x.Username == item.UserID));
                }
                Program.TF.OpenChildForm(new TeacherTestWatchingForm(CurrentTeacher, alluser.Single(x => x.Username == SelectedUsername), CurrentTest));
            }
            else
            {
                new ErrorMessageForm("Ez a dolgozat még nincs leadva!").Show();
            }
        }

        private void VisszaBtn_Click(object sender, EventArgs e)
        {
            Program.TF.ImitateClick("DolgozatokBtn");
        }
    }
}
