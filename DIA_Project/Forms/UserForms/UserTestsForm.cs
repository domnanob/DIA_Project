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
        public UserTestsForm(User u)
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            CurrentUser = u;
            LoadingDataSources();
            SubjectsCB.SelectedItem = "Tantárgy";
            SubjectsCB.SelectedValueChanged += new EventHandler(SubjectsCB_SelectedValueChanged);
        }
        private User CurrentUser = new User();
        private List<Test> tests = new List<Test>();
        private List<Test> SelectedTests = new List<Test>();
        private List<FormattedTestsForUser> FTL = new List<FormattedTestsForUser>();
        private List<int> TIDS = new List<int>();
        public void LoadingDataSources() {
            using (SQL sql = SQL.MySql())
            {
                foreach (var item in sql.subjects.OrderBy(x => x.Name))
                {
                    SubjectsCB.Items.Add(item.Name);
                }
                tests.Clear();
                TIDS = sql.userTests.Where(x => x.UserID == CurrentUser.Username).Select(x => x.TestID).ToList();
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
        void DGVLoad(List<Test> t)
        {
            FTL.Clear();
            TestsDGV.DataSource = null;
            foreach (var item in t)
            {
                FTL.Add(new FormattedTestsForUser(item,CurrentUser));
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
                Subject s = SQL.MySql().subjects.Single(x => x.Name == SubjectsCB.Items[SubjectsCB.SelectedIndex].ToString());
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
            if (TestsDGV.SelectedRows.Count > 0)
            {
                string SelectedTestID = TestsDGV.SelectedRows[0].Cells[0].Value.ToString();
                Test t = SQL.MySql().tests.Single(x => x.ID == int.Parse(SelectedTestID));
                UserTest ut = SQL.MySql().userTests.Single(x => x.TestID == t.ID && x.UserID == CurrentUser.Username);
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
                        else
                        {
                            WarningMessageForm wmf = new WarningMessageForm("Biztos készen állsz a dolgozatra?");
                            wmf.ShowDialog();
                            if (wmf.DialogResult == DialogResult.Yes)
                            {
                                new SuccessMessageForm("Sok sikert!").Show();
                                Program.HF.OpenChildForm(new UserTestWrittingForm(CurrentUser, t));
                            }
                        }
                    }
                    else
                    {
                        new ErrorMessageForm("Ezt a dolgozatot majd ekkor írhatod meg: " + t.StartDate).Show();
                    }
                }
                else
                {
                    if (ut.CorrectState == 1)
                    {
                        Program.HF.OpenChildForm(new UserTestWatchingForm(CurrentUser, t));
                    }
                    else
                    {
                        new ErrorMessageForm("Ez a dolgozat még javítás alatt van!").Show();
                    }
                }
            }
            else
            {
                new ErrorMessageForm("Nem választottál dolgozatot!").Show();
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
                List<Test> GarbageItems = new List<Test>();
                foreach (var item in SelectedTests)
                {
                    UserTest ut = SQL.MySql().userTests.Single(x => x.TestID == item.ID && x.UserID == CurrentUser.Username);
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
                List<Test> GarbageItems = new List<Test>();
                foreach (var item in SelectedTests)
                {
                    UserTest ut = SQL.MySql().userTests.Single(x => x.TestID == item.ID && x.UserID == CurrentUser.Username);
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

        private void TestsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MegnyitasBtn_Click(sender, e);
        }
    }
}
