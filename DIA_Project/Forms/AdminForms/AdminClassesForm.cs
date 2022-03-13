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
    public partial class AdminClassesForm : Form
    {
        public AdminClassesForm()
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
        private List<Classes> classes = new List<Classes>();
        private List<FormattedClasses> FC = new List<FormattedClasses>();

        public void ReLoad() {
            classes.Clear();
            using (SQL sql = SQL.MySql())
            {
                classes = sql.classes.ToList();
            }
            DGVLoad(classes);
        }
        void DGVLoad(List<Classes> u)
        {
            FC.Clear();
            ClassesDGV.DataSource = null;
            foreach (var item in u)
            {
                if (item.Name != null)
                {
                    FC.Add(new FormattedClasses(item));
                }
            }
            ClassesDGV.DataSource = FC;
            return;
        }

        private void DataGridHeaderChange(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "Osztálynév";
                dgv.Columns[2].HeaderText = "Diákok száma";
            }
        }
        private void PurchasesDGV_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridHeaderChange(ClassesDGV);
        }

        private void ClassesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ClassesDGV.SelectedRows.Count > 0)
            {
                string SelectedClassID = ClassesDGV.SelectedRows[0].Cells[0].Value.ToString();
                Classes c = SQL.MySql().classes.Single(x => x.ID == int.Parse(SelectedClassID));
                new ClassNameMessageForm(c, true).ShowDialog();
                ReLoad();
            }
            else
            {
                new ErrorMessageForm("Nem választottál osztályt!").Show();
            }

        }

        private void NewTestBtn_Click(object sender, EventArgs e)
        {
            new ClassNameMessageForm().ShowDialog();
            ReLoad();
        }

        private void PurchasesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBtn_Click(sender, e);
        }
    }
}
