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
        public TeacherTestsUsersForm(Teachers t, Tests e)
        {
            InitializeComponent();
            CurrentTeacher = t;
            CurrentTest = e;
            LoadingDataSources();
        }
        private Teachers CurrentTeacher = new Teachers();
        private Tests CurrentTest = new Tests();
        private List<UserTests> UT = new List<UserTests>();
        private List<FormattedUserTests> FUT = new List<FormattedUserTests>();
        public void LoadingDataSources() {
            using (SQL sql = SQL.MySql())
            {
                UT = sql.userTests.Where(x => x.TestID == CurrentTest.ID).ToList();
            }
            DGVLoad(UT);
        }
        void DGVLoad(List<UserTests> ut)
        {
            foreach (var item in ut)
            {
                FUT.Add(new FormattedUserTests(item));
            }
            UsersTestsDGV.DataSource = FUT;
            return;
        }

        private void DataGridHeaderChange(DataGridView dgv)
        {
            
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].HeaderText = "Diák";
                dgv.Columns[1].HeaderText = "Leadási idő";
                dgv.Columns[2].HeaderText = "Állapot";
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
            if (new string[] { "Javításra vár!", "Kijavítva!" }.Contains(UsersTestsDGV.SelectedRows[0].Cells[2].Value.ToString()))
            {
                string SelectedUserName = UsersTestsDGV.SelectedRows[0].Cells[0].Value.ToString();
                List<Users> alluser = new List<Users>();
                foreach (var item in UT)
                {
                    alluser.Add(SQL.MySql().users.Single(x => x.Username == item.UserID));
                }
                Program.TF.OpenChildForm(new TeacherTestWatchingForm(CurrentTeacher, alluser.Single(x => x.Name == SelectedUserName), CurrentTest));
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
