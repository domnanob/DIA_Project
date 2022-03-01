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
            SubjectsCB.SelectedItem = "Tantárgy";
            SubjectsCB.SelectedValueChanged += new EventHandler(SubjectsCB_SelectedValueChanged);
        }
        private Users CurrentUser = new Users();
        private List<Tests> tests = new List<Tests>();
        private List<Tests> SelectedTests = new List<Tests>();
        private List<FormattedTestsForUsers> FTL = new List<FormattedTestsForUsers>();
        private List<int> TIDS = new List<int>();
        public void LoadingDataSources() {
            using (SQL sql = SQL.MySql())
            {
                foreach (var item in sql.subjects.OrderBy(x => x.Name))
                {
                    SubjectsCB.Items.Add(item.Name);
                }
                tests.Clear();
                foreach (var item in sql.userTests.Where(x => x.UserID == CurrentUser.Username).ToList())
                {
                    TIDS.Add(item.TestID);
                }
                foreach (var item in sql.tests)
                {
                    if (TIDS.Contains(item.ID))
                    {
                        tests.Add(item);
                        SelectedTests.Add(item);
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
            if (SubjectsCB.Items[SubjectsCB.SelectedIndex] == SubjectsCB.Items[0])
            {
                SelectedTests = SQL.MySql().tests.Where(x => TIDS.Contains(x.ID)).ToList();
                if (ShowCorrectedCb.Checked && ShowInProgressCb.Checked)
                {
                    DGVLoad(SelectedTests);
                    return;
                }
                if (!ShowCorrectedCb.Checked) {
                    ShowCorrectedCb_CheckedChanged(ShowCorrectedCb, EventArgs.Empty);
                }
                if (!ShowInProgressCb.Checked)
                {
                    ShowInProgressCb_CheckedChanged(ShowCorrectedCb, EventArgs.Empty);
                }
            }
            else {
                Subjects s = SQL.MySql().subjects.Single(x => x.Name == SubjectsCB.Items[SubjectsCB.SelectedIndex].ToString());
                SelectedTests = tests.Where(x => x.SubjectID == s.ID).ToList();
                if (ShowCorrectedCb.Checked && ShowInProgressCb.Checked)
                {
                    DGVLoad(SelectedTests);
                    return;
                }
                if (!ShowCorrectedCb.Checked)
                {
                    ShowCorrectedCb_CheckedChanged(ShowCorrectedCb, EventArgs.Empty);
                }
                if (!ShowInProgressCb.Checked)
                {
                    ShowInProgressCb_CheckedChanged(ShowCorrectedCb, EventArgs.Empty);
                }
            }
        }

        private void DataGridHeaderChange(DataGridView dgv)
        {
            
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "Dolgozat";
                dgv.Columns[2].HeaderText = "Tantárgy";
                dgv.Columns[3].HeaderText = "Határidő";
                dgv.Columns[4].HeaderText = "Pont";
                dgv.Columns[5].HeaderText = "Állapot";
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
            string SelectedTestID = TestsDGV.SelectedRows[0].Cells[0].Value.ToString();
            Tests t = SQL.MySql().tests.Single(x => x.ID == int.Parse(SelectedTestID));
            UserTests ut = SQL.MySql().userTests.Single(x => x.TestID == t.ID && x.UserID == CurrentUser.Username);
            if (ut.Completed == 0)
            {
                if (t.StartDate <= DateTime.Now)
                {
                    if (t.InternetAllowed == 0)
                    {
                        WarningMessageForm wmf = new WarningMessageForm("Biztos készen állsz a dolgozatra? \n" +
                        "Bármely csalás a dolgozat azonnali leadását eredményezi!");
                        wmf.ShowDialog();
                        if (wmf.DialogResult == DialogResult.Yes)
                        {
                            if (CheatDetector.DetectBrowser())
                            {
                                new ErrorMessageForm("A dolgozatíráshoz be kell zárnod a böngészőt!").ShowDialog();
                            }
                            else
                            {
                                new SuccessMessageForm("Sok sikert!").Show();
                                Program.HF.OpenChildForm(new UserTestWrittingForm(CurrentUser, t));
                            }
                        }
                    }
                    else {
                        WarningMessageForm wmf = new WarningMessageForm("Biztos készen állsz a dolgozatra?");
                        wmf.ShowDialog();
                        if (wmf.DialogResult == DialogResult.Yes)
                        {
                            new SuccessMessageForm("Sok sikert!").Show();
                            Program.HF.OpenChildForm(new UserTestWrittingForm(CurrentUser, t));
                        }
                    }
                }
                else {
                    new ErrorMessageForm("Ezt a dolgozatot majd ekkor írhatod meg: "+t.StartDate).Show();
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

        private void ShowCorrectedCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCorrectedCb.Checked)
            {
                SubjectsCB_SelectedValueChanged(SubjectsCB, EventArgs.Empty);
            }
            else 
            {
                List<Tests> GarbageItems = new List<Tests>();
                foreach (var item in SelectedTests)
                {
                    UserTests ut = SQL.MySql().userTests.Single(x => x.TestID == item.ID && x.UserID == CurrentUser.Username);
                    if (ut.CorrectState == 1)
                    {
                        GarbageItems.Add(item);
                    }
                }
                foreach (var item in GarbageItems)
                {
                    SelectedTests.Remove(item);
                }
                DGVLoad(SelectedTests);
            }
        }

        private void ShowInProgressCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowInProgressCb.Checked)
            {
                SubjectsCB_SelectedValueChanged(SubjectsCB, EventArgs.Empty);
            }
            else
            {
                List<Tests> GarbageItems = new List<Tests>();
                foreach (var item in SelectedTests)
                {
                    UserTests ut = SQL.MySql().userTests.Single(x => x.TestID == item.ID && x.UserID == CurrentUser.Username);
                    if (ut.CorrectState == 0 && ut.Completed == 1)
                    {
                        GarbageItems.Add(item);
                    }
                }
                foreach (var item in GarbageItems)
                {
                    SelectedTests.Remove(item);
                }
                DGVLoad(SelectedTests);
            }
        }
    }
}
