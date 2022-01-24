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
    public partial class ClassesForm : Form
    {
        public ClassesForm(Teachers t)
        {
            InitializeComponent();
            CurrentTeacher = t;
            ReLoad();
            ClassesCB.SelectedItem = "None";
            this.ClassesCB.SelectedValueChanged += new System.EventHandler(this.ClassesCB_SelectedValueChanged);
        }
        private Teachers CurrentTeacher = new Teachers();
        private List<Classes> classes = new List<Classes>();
        private List<Positions> positions = new List<Positions>();
        private List<Purchases> purchases = new List<Purchases>();
        private List<Purchases> FilteredP = new List<Purchases>();
        private List<FormattedPurchases> FPL = new List<FormattedPurchases>();
        public void ReLoad() {
            classes.Clear();
            positions.Clear();
            using (SQL sql = SQL.MySql())
            {
                foreach (var item in sql.positions)
                {
                    positions.Add(item);
                }
                foreach (var item in sql.purchases)
                {
                    purchases.Add(item);
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
                                classes.Add(item);
                            }
                        }
                    }
                }
                DGVLoad(purchases);
            }
        }
        void DGVLoad(List<Purchases> l)
        {
            FPL.Clear();
            PurchasesDGV.DataSource = null;
            foreach (var item in l)
            {
                FPL.Add(new FormattedPurchases(item));
            }
            PurchasesDGV.DataSource = FPL;
            return;
        }
        private void ClassesCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ClassesCB.Items[ClassesCB.SelectedIndex] == "None")
            {
                DGVLoad(purchases);
                return;
            }
            using (SQL sql = SQL.MySql())
            {
                Classes c = sql.classes.Single(a => a.Name == ClassesCB.Items[ClassesCB.SelectedIndex]);
                List<Users> SelectedUsers = sql.users.Where(x => x.ClassID == c.ID).ToList();
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
            List<Purchases> lp = new List<Purchases>();
            if (ClassesCB.Items[ClassesCB.SelectedIndex] == "None")
            {
                foreach (var item in purchases)
                {
                    if (item.UserID.Contains(NameTb.Text))
                    {
                        lp.Add(item);
                    }
                }
            }
            else 
            {
                foreach (var item in FilteredP)
                {
                    if (SQL.MySql().users.Single(x => x.Username == item.UserID).Name.Contains(NameTb.Text))
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
                dgv.Columns[0].HeaderText = "Diák";
                dgv.Columns[1].HeaderText = "Javítási lehetőség";
                dgv.Columns[2].HeaderText = "Házifeladat Felmentés";
                dgv.Columns[3].HeaderText = "Késés Igazolás";
                dgv.Columns[4].HeaderText = "Jeles érdemjegy";
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
    }
}
