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
        public TeacherTestsForm(Teachers t)
        {
            InitializeComponent();
            CurrentTeacher = t;
            LoadingDataSources();
            ClassesCB.SelectedItem = "None";
            this.ClassesCB.SelectedValueChanged += new System.EventHandler(this.ClassesCB_SelectedValueChanged);
        }
        private Teachers CurrentTeacher = new Teachers();
        private List<Tests> tests = new List<Tests>();
        private List<Tests> SelectedTests = new List<Tests>();
        private List<Positions> positions = new List<Positions>();
        private List<FormattedTests> FTL = new List<FormattedTests>();
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
        void DGVLoad(List<Tests> t)
        {
            FTL.Clear();
            TestsDGV.DataSource = null;
            foreach (var item in t)
            {
                FTL.Add(new FormattedTests(item));
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
                dgv.Columns[0].HeaderText = "Dolgozat";
                dgv.Columns[1].HeaderText = "Tantárgy";
                dgv.Columns[2].HeaderText = "Osztály";
                dgv.Columns[3].HeaderText = "Határidő";
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
            Program.TF.OpenChildForm(new TeacherTestsUsersForm(CurrentTeacher, t));
        }

        private void NewTestBtn_Click(object sender, EventArgs e)
        {
            Program.TF.OpenChildForm(new TeacherNewTestForm(CurrentTeacher, positions));
            this.Close();
        }
    }
}
