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
    public partial class AdminUsersForm : Form
    {
        public AdminUsersForm()
        {
            InitializeComponent();
            ReLoad();
            ClassesCB.SelectedItem = "Osztályok";
            this.ClassesCB.SelectedValueChanged += new System.EventHandler(this.ClassesCB_SelectedValueChanged);
        }
        private List<Classes> classes = new List<Classes>();
        private List<Users> users = new List<Users>();
        private List<Users> FilteredUsers = new List<Users>();
        private List<FormattedUsers> FU = new List<FormattedUsers>();
        public void ReLoad() {
            classes.Clear();
            users.Clear();
            using (SQL sql = SQL.MySql())
            {
                classes = sql.classes.ToList();
                foreach (var item in classes)
                {
                    ClassesCB.Items.Add(item.Name);
                }
                users = sql.users.ToList();
                DGVLoad(users);
            }
        }
        void DGVLoad(List<Users> u)
        {
            FU.Clear();
            PurchasesDGV.DataSource = null;
            foreach (var item in u)
            {
                if (item.RoleID != 1)
                {
                    FU.Add(new FormattedUsers(item));
                }
            }
            PurchasesDGV.DataSource = FU;
            return;
        }
        private void ClassesCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ClassesCB.Items[ClassesCB.SelectedIndex] == ClassesCB.Items[0])
            {
                DGVLoad(users);
                return;
            }
            using (SQL sql = SQL.MySql())
            {
                Classes c = sql.classes.Single(a => a.Name == ClassesCB.Items[ClassesCB.SelectedIndex].ToString());
                FilteredUsers = sql.users.Where(x => x.ClassID == c.ID).ToList();
                DGVLoad(FilteredUsers);
            }
        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {
            List<Users> u = new List<Users>();
            if (ClassesCB.Items[ClassesCB.SelectedIndex] == ClassesCB.Items[0])
            {
                foreach (var item in users)
                {
                    if (item.Name.ToLower().Contains(NameTb.Text.ToLower()))
                    {
                        u.Add(item);
                    }
                }
            }
            else 
            {
                foreach (var item in FilteredUsers)
                {
                    if (item.Name.ToLower().Contains(NameTb.Text.ToLower()))
                    {
                        u.Add(item);
                    }
                }
            }
            DGVLoad(u);
        }

        private void DataGridHeaderChange(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].HeaderText = "Felhasználónév";
                dgv.Columns[1].HeaderText = "Teljes név";
                dgv.Columns[2].HeaderText = "Státusz";
                dgv.Columns[3].HeaderText = "Utolsó belépés";
                dgv.Columns[4].HeaderText = "Pont";
                dgv.Columns[5].HeaderText = "Osztály";
                dgv.Columns[6].HeaderText = "Email";
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
            string SelectedUsername = PurchasesDGV.SelectedRows[0].Cells[0].Value.ToString();
            Users u = SQL.MySql().users.Single(x => x.Username == SelectedUsername);
            Program.AF.OpenChildForm(new AdminUserEditForm(u));
        }

        private void NewTestBtn_Click(object sender, EventArgs e)
        {
            Program.AF.OpenChildForm(new AdminNewUserForm());
        }
    }
}
