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

namespace DIA_Project.Forms.UserForms
{
    public partial class UserTestsForm : Form
    {
        public UserTestsForm(Users u)
        {
            InitializeComponent();
            CurrentUser = u;
            LoadingDataSources();
            SubjectsCB.SelectedItem = "None";
            this.SubjectsCB.SelectedValueChanged += new System.EventHandler(this.SubjectsCB_SelectedValueChanged);
        }
        private Users CurrentUser = new Users();
        private List<Tests> tests = new List<Tests>();
        private List<Tests> SelectedTests = new List<Tests>();
        private List<FormattedTestsForUsers> FTL = new List<FormattedTestsForUsers>();
        public void LoadingDataSources() {
            using (SQL sql = SQL.MySql())
            {
                foreach (var item in sql.subjects.OrderBy(x => x.Name))
                {
                    SubjectsCB.Items.Add(item.Name);
                }
                tests.Clear();
                List<int> TIDS = new List<int>();
                foreach (var item in sql.userTests.Where(x => x.UserID == CurrentUser.Username).ToList())
                {
                    TIDS.Add(item.TestID);
                }
                foreach (var item in sql.tests)
                {
                    if (TIDS.Contains(item.ID))
                    {
                        tests.Add(item);
                    }
                }
                DGVLoad(tests);
            }
        }
        void DGVLoad(List<Tests> t)
        {
            FTL.Clear();
            TestsDGV.DataSource = null;
            foreach (var item in t)
            {
                FTL.Add(new FormattedTestsForUsers(item,CurrentUser));
            }
            TestsDGV.DataSource = FTL;
            return;
        }
        private void SubjectsCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SubjectsCB.Items[SubjectsCB.SelectedIndex] == "None")
            {
                DGVLoad(tests);
            }
            else {
                Subjects s = SQL.MySql().subjects.Single(x => x.Name == SubjectsCB.Items[SubjectsCB.SelectedIndex]);
                SelectedTests = tests.Where(x => x.SubjectID == s.ID).ToList();
                DGVLoad(SelectedTests);
            }
        }

        private void DataGridHeaderChange(DataGridView dgv)
        {
            
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].HeaderText = "Dolgozat";
                dgv.Columns[1].HeaderText = "Tantárgy";
                dgv.Columns[2].HeaderText = "Határidő";
                dgv.Columns[3].HeaderText = "Pont";
                dgv.Columns[4].HeaderText = "Állapot";
            }
        }
        private void PurchasesDGV_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridHeaderChange(TestsDGV);
        }

        private void TeacherTestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void MegnyitasBtn_Click(object sender, EventArgs e)
        {
            string SelectedTestName = TestsDGV.SelectedRows[0].Cells[0].Value.ToString();
            Tests t = SQL.MySql().tests.Single(x => x.Name == SelectedTestName);
            UserTests ut = SQL.MySql().userTests.Single(x => x.TestID == t.ID && x.UserID == CurrentUser.Username);
            if (ut.Completed == 0)
            {
                WarningMessageForm wmf = new WarningMessageForm("Biztos készen állsz a dolgozatra?");
                wmf.ShowDialog();
                if (wmf.DialogResult == DialogResult.Yes)
                {
                    new SuccessMessageForm("Sok sikert!").Show();
                    Program.HF.OpenChildForm(new UserTestWrittingForm(CurrentUser, t));
                }
            }
            else
            {
                if (ut.CorrectState == 1)
                {
                    Program.HF.OpenChildForm(new UserTestWatchingForm(CurrentUser, t));
                }
                else {
                    new ErrorMessageForm("Ez a dolgozat még javítás alatt van!").Show();
                }
            }
        }
    }
}
