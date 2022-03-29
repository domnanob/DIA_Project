using DIA_Project.Lib;
using DIA_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DIA_Project.Forms.TeacherForms
{
    public partial class TeacherClassesForm : Form
    {
        public TeacherClassesForm(Teacher t)
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
            ReLoad();
            ClassesCB.SelectedItem = "None";
            this.ClassesCB.SelectedValueChanged += new System.EventHandler(this.ClassesCB_SelectedValueChanged);
        }
        private Teacher CurrentTeacher = new Teacher();
        private List<Classes> classes = new List<Classes>();
        private List<Purchase> purchases = new List<Purchase>();
        private List<Purchase> FilteredP = new List<Purchase>();
        private List<FormattedPurchase> FPL = new List<FormattedPurchase>();
        public void ReLoad()
        {
            classes.Clear();
            using (SQL sql = SQL.MySql())
            {
                List<int> currentClassIDs = new List<int>();
                foreach (var item in sql.classes.OrderBy(x => x.Name))
                {
                    foreach (var p in SQL.MySql().positions)
                    {
                        if (p.TeacherID == CurrentTeacher.Username && p.ClassID == item.ID)
                        {
                            if (!ClassesCB.Items.Contains(item.Name))
                            {
                                ClassesCB.Items.Add(item.Name);
                                classes.Add(item);
                                currentClassIDs.Add(item.ID);
                            }
                        }
                    }
                }
                foreach (var item in sql.purchases)
                {
                    if (currentClassIDs.Contains((int)SQL.MySql().users.Single(x => x.Username == item.UserID).ClassID))
                    {
                        purchases.Add(item);
                    }
                }
                DGVLoad(purchases);
            }
        }
        void DGVLoad(List<Purchase> l)
        {
            FPL.Clear();
            PurchasesDGV.DataSource = null;
            foreach (var item in l)
            {
                FPL.Add(new FormattedPurchase(item));
            }
            PurchasesDGV.DataSource = FPL;
            return;
        }
        private void ClassesCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ClassesCB.Items[ClassesCB.SelectedIndex] == ClassesCB.Items[0])
            {
                DGVLoad(purchases);
                return;
            }
            using (SQL sql = SQL.MySql())
            {
                Classes c = sql.classes.Single(a => a.Name == ClassesCB.Items[ClassesCB.SelectedIndex].ToString());
                List<User> SelectedUsers = sql.users.Where(x => x.ClassID == c.ID).ToList();
                FilteredP.Clear();
                foreach (var p in purchases)
                {
                    foreach (var u in SelectedUsers)
                    {
                        if (p.UserID == u.Username)
                        {
                            FilteredP.Add(p);
                        }
                    }
                }
                DGVLoad(FilteredP);
            }
        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {
            List<Purchase> lp = new List<Purchase>();
            if (ClassesCB.Items[ClassesCB.SelectedIndex] == ClassesCB.Items[0])
            {
                foreach (var item in purchases)
                {
                    if (SQL.MySql().users.Single(x => x.Username == item.UserID).Name.ToLower().Contains(NameTb.Text.ToLower()))
                    {
                        lp.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in FilteredP)
                {
                    if (SQL.MySql().users.Single(x => x.Username == item.UserID).Name.ToLower().Contains(NameTb.Text.ToLower()))
                    {
                        lp.Add(item);
                    }
                }
            }
            DGVLoad(lp);

        }

        void DataGridHeaderChange(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "Diák";
                dgv.Columns[2].HeaderText = "Javítási lehetőség";
                dgv.Columns[3].HeaderText = "Házifeladat Felmentés";
                dgv.Columns[4].HeaderText = "Késés Igazolás";
                dgv.Columns[5].HeaderText = "Jeles érdemjegy";
                //dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            }
        }
        private void PurchasesDGV_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridHeaderChange(PurchasesDGV);
        }

        private void ClassesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PurchasesDGV.SelectedRows.Count > 0)
            {
                string SelectedUsername = PurchasesDGV.SelectedRows[0].Cells[0].Value.ToString();
                Program.TF.OpenChildForm(new TeacherUserPurchasesForm(SQL.MySql().users.Single(x => x.Username == SelectedUsername)));
            }
            else
            {
                new ErrorMessageForm("Nem választottál Diákot!").Show();
            }
        }

        private void PurchasesDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBtn_Click(sender, e);
        }
    }
}
