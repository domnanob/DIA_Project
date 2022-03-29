using DIA_Project.Lib;
using DIA_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DIA_Project.Forms.AdminForms
{
    public partial class AdminNewUserCodesForm : Form
    {
        public AdminNewUserCodesForm()
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            ReLoad();
            ClassesCB.SelectedItem = "Osztályok";
            this.ClassesCB.SelectedValueChanged += new System.EventHandler(this.ClassesCB_SelectedValueChanged);
        }
        private List<Classes> classes = new List<Classes>();
        private List<RegistrationToken> tokens = new List<RegistrationToken>();
        private List<RegistrationToken> FilteredTokens = new List<RegistrationToken>();
        private List<FormattedToken> FT = new List<FormattedToken>();
        public void ReLoad()
        {
            classes.Clear();
            tokens.Clear();
            using (SQL sql = SQL.MySql())
            {
                classes = sql.classes.ToList();
                foreach (var item in classes)
                {
                    ClassesCB.Items.Add(item.Name);
                }
                tokens = sql.registrationTokens.ToList();
                DGVLoad(tokens);
            }
        }
        void DGVLoad(List<RegistrationToken> t)
        {
            FT.Clear();
            TokensDGV.DataSource = null;
            foreach (var item in t)
            {
                FT.Add(new FormattedToken(item));
            }
            TokensDGV.DataSource = FT;
            return;
        }
        private void ClassesCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ClassesCB.Items[ClassesCB.SelectedIndex] == ClassesCB.Items[0])
            {
                DGVLoad(tokens);
                return;
            }
            using (SQL sql = SQL.MySql())
            {
                Classes c = sql.classes.Single(a => a.Name == ClassesCB.Items[ClassesCB.SelectedIndex].ToString());
                FilteredTokens = sql.registrationTokens.Where(x => x.ClassID == c.ID).ToList();
                DGVLoad(FilteredTokens);
            }
        }


        private void DataGridHeaderChange(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].HeaderText = "Regisztrációs kód";
                dgv.Columns[1].HeaderText = "osztály";
                //dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            }
        }

        private void ClassesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void TokensDGV_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridHeaderChange(TokensDGV);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Program.AF.OpenChildForm(new AdminNewUserForm());
        }

        private void NewTokenBtn_Click(object sender, EventArgs e)
        {
            new TokenGeneratorMessageForm().ShowDialog();
            ReLoad();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string SelectedToken = TokensDGV.SelectedRows[0].Cells[0].Value.ToString();
            using (SQL sql = SQL.MySql())
            {
                RegistrationToken r = sql.registrationTokens.Single(x => x.Token == SelectedToken);
                sql.registrationTokens.Remove(r);
                sql.SaveChanges();
                ReLoad();
            }

        }
    }
}
