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
    public partial class AdminTeacherPositionsForm : Form
    {
        public AdminTeacherPositionsForm(Teachers t)
        {
            InitializeComponent();
            CurrentTeacher = t;
            TeacherNameTb.Text += " " + t.Name;
            ReLoad();
        }
        private Teachers CurrentTeacher = new Teachers();
        private List<Positions> CurrentPositions = new List<Positions>();
        private List<FormattedPositions> FP = new List<FormattedPositions>();
        public void ReLoad() {
            using (SQL sql = SQL.MySql())
            {
                CurrentPositions = sql.positions.Where(x => x.TeacherID == CurrentTeacher.Username).OrderBy(x => x.ClassID).ToList();
                DGVLoad(CurrentPositions);
            }
        }
        void DGVLoad(List<Positions> p)
        {
            FP.Clear();
            PositionsDGV.DataSource = null;
            foreach (var item in p)
            {
                FP.Add(new FormattedPositions(item));
            }
            PositionsDGV.DataSource = FP;
            return;
        }


        private void DataGridHeaderChange(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].HeaderText = "Osztály";
                dgv.Columns[1].HeaderText = "Tantárgy";
                //dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            }
        }
        private void PurchasesDGV_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridHeaderChange(PositionsDGV);
        }

        private void ClassesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void NewPositionBtn_Click(object sender, EventArgs e)
        {
            new SelectPositionMessageForm(CurrentTeacher).ShowDialog();
            ReLoad();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (new WarningMessageForm("Biztosan törölni szeretnéd ezt a pozíciót?").ShowDialog() == DialogResult.Yes)
            {
                using (SQL sql = SQL.MySql())
                {
                    string SelectedClassName = PositionsDGV.SelectedRows[0].Cells[1].Value.ToString();
                    string SelectedSubjectName = PositionsDGV.SelectedRows[0].Cells[2].Value.ToString();
                    List<Positions> p = sql.positions.Where(x => x.TeacherID == CurrentTeacher.Username).ToList();
                    List<Positions> p2 = p.Where(x => x.ClassID == sql.classes.Single(x => x.Name == SelectedClassName).ID).ToList();
                    Positions selectedPosition = p2.Single(x => x.SubjectID == sql.subjects.Single(x => x.Name == SelectedSubjectName).ID);
                    sql.positions.Remove(selectedPosition);
                    sql.SaveChanges();
                    new SuccessMessageForm("Sikeresen törölted ezt a pozíciót!").ShowDialog();
                    ReLoad();
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Program.AF.OpenChildForm(new AdminTeacherEditForm(CurrentTeacher));
        }
    }
}
