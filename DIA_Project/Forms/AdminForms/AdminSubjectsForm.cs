using DIA_Project.Lib;
using DIA_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DIA_Project.Forms.AdminForms
{
    public partial class AdminSubjectsForm : Form
    {
        public AdminSubjectsForm()
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            ReLoad();
        }
        private List<Subject> subjects = new List<Subject>();

        public void ReLoad()
        {
            subjects.Clear();
            using (SQL sql = SQL.MySql())
            {
                subjects = sql.subjects.ToList();
            }
            DGVLoad(subjects);
        }
        void DGVLoad(List<Subject> s)
        {
            SubjectsDGV.DataSource = null;
            SubjectsDGV.DataSource = s;
            return;
        }

        private void DataGridHeaderChange(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "Tantárgynév";
            }
        }
        private void PurchasesDGV_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridHeaderChange(SubjectsDGV);
        }

        private void ClassesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SubjectsDGV.SelectedRows.Count > 0)
            {
                string SelectedSubjectID = SubjectsDGV.SelectedRows[0].Cells[0].Value.ToString();
                Subject s = SQL.MySql().subjects.Single(x => x.ID == int.Parse(SelectedSubjectID));
                new SubjectNameMessageForm(s, true).ShowDialog();
                ReLoad();
            }
            else
            {
                new ErrorMessageForm("Nincs kiválasztott elem!").Show();
            }
        }

        private void NewTestBtn_Click(object sender, EventArgs e)
        {
            new SubjectNameMessageForm().ShowDialog();
            ReLoad();
        }

        private void PurchasesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBtn_Click(sender, e);
        }

    }
}
