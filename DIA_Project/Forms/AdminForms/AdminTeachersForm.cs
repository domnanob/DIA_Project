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
    public partial class AdminTeachersForm : Form
    {
        public AdminTeachersForm()
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
        private List<Teacher> teachers = new List<Teacher>();
        private List<FormattedTeacher> FT = new List<FormattedTeacher>();
        public void ReLoad() {
            teachers.Clear();
            using (SQL sql = SQL.MySql())
            {
                teachers = sql.teachers.ToList();
                DGVLoad(teachers);
            }
        }
        void DGVLoad(List<Teacher> t)
        {
            FT.Clear();
            TeachersDGV.DataSource = null;
            foreach (var item in t)
            {
                FT.Add(new FormattedTeacher(item));
            }
            TeachersDGV.DataSource = FT;
            return;
        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {
            List<Teacher> u = new List<Teacher>();
            foreach (var item in teachers)
            {
                if (item.Name.ToLower().Contains(NameTb.Text.ToLower()))
                {
                    u.Add(item);
                }
            }
            DGVLoad(u);
        }

        private void DataGridHeaderChange(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].HeaderText = "Felhasználónév";
                dgv.Columns[1].HeaderText = "Teljes Név";
                dgv.Columns[2].HeaderText = "Státusz";
                dgv.Columns[3].HeaderText = "Utolsó belépés";
                dgv.Columns[4].HeaderText = "Email";
                //dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            }
        }
        private void PurchasesDGV_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridHeaderChange(TeachersDGV);
        }

        private void ClassesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TeachersDGV.SelectedRows.Count > 0)
            {
                string SelectedUsername = TeachersDGV.SelectedRows[0].Cells[0].Value.ToString();
                Teacher t = SQL.MySql().teachers.Single(x => x.Username == SelectedUsername);
                Program.AF.OpenChildForm(new AdminTeacherEditForm(t));
            }
            else
            {
                new ErrorMessageForm("Nem választottál tanárt!").Show();
            }
        }

        private void NewTeacherBtn_Click(object sender, EventArgs e)
        {
            Program.AF.OpenChildForm(new AdminNewTeacherForm());
        }

        private void TeachersDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBtn_Click(sender, e);
        }
    }
}
