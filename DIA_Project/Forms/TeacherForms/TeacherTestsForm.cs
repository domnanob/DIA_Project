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
    public partial class TeacherTestsForm : Form
    {
        public TeacherTestsForm(Teacher t)
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
            LoadingDataSources();
            ClassesCB.SelectedItem = "None";
            this.ClassesCB.SelectedValueChanged += new System.EventHandler(this.ClassesCB_SelectedValueChanged);
        }
        private Teacher CurrentTeacher = new Teacher();
        private List<Test> tests = new List<Test>();
        private List<Test> SelectedTests = new List<Test>();
        private List<Position> positions = new List<Position>();
        private List<FormattedTest> FTL = new List<FormattedTest>();
        public void LoadingDataSources() {
            positions.Clear();
            using (SQL sql = SQL.MySql())
            {
                foreach (var item in sql.positions)
                {
                    positions.Add(item);
                }
                foreach (var item in sql.classes.OrderBy(x => x.Name))
                {
                    foreach (var p in positions)
                    {
                        if (p.TeacherID == CurrentTeacher.Username && p.ClassID == item.ID)
                        {
                            if (!ClassesCB.Items.Contains(item.Name))
                            {
                                ClassesCB.Items.Add(item.Name);
                            }
                        }
                    }
                }
                tests = sql.tests.Where(x => x.TeacherID == CurrentTeacher.Username).ToList();
                DGVLoad(tests);
            }
        }
        void DGVLoad(List<Test> t)
        {
            FTL.Clear();
            TestsDGV.DataSource = null;
            foreach (var item in t)
            {
                FTL.Add(new FormattedTest(item));
            }
            TestsDGV.DataSource = FTL;
            return;
        }
        private void ClassesCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ClassesCB.Items[ClassesCB.SelectedIndex] == ClassesCB.Items[0])
            {
                DGVLoad(tests);
                return;
            }
            using (SQL sql = SQL.MySql())
            {
                Classes c = sql.classes.Single(x => x.Name == ClassesCB.Items[ClassesCB.SelectedIndex].ToString());
                SelectedTests = tests.Where(x => x.ClassID == c.ID).ToList();
                DGVLoad(SelectedTests);
            }
        }

        private void DataGridHeaderChange(DataGridView dgv)
        {
            
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].Visible = false; 
                dgv.Columns[1].HeaderText = "Dolgozat";
                dgv.Columns[2].HeaderText = "Tantárgy";
                dgv.Columns[3].HeaderText = "Osztály";
                dgv.Columns[4].HeaderText = "Határidő";
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
            Test t = SQL.MySql().tests.Single(x => x.ID == int.Parse(SelectedTestID));
            Program.TF.OpenChildForm(new TeacherTestsUsersForm(CurrentTeacher, t));
        }

        private void NewTestBtn_Click(object sender, EventArgs e)
        {
            Program.TF.OpenChildForm(new TeacherNewTestForm(CurrentTeacher, positions));
            this.Close();
        }
    }
}
