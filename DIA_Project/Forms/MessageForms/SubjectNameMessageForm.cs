using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIA_Project.Lib;
using DIA_Project.Models;

namespace DIA_Project.Forms
{
    public partial class SubjectNameMessageForm : Form
    {
        public SubjectNameMessageForm(Subject OldSubject = null, bool EditMode = false)
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            editMode = EditMode;
            oldSubject = OldSubject;
            SubjectNameTb.Text = (editMode) ? oldSubject.Name : string.Empty;
            LoadingDataSources();

        }
        bool editMode = false;
        Subject oldSubject = null;
        List<string> SubjectNames = new List<string>();
        private void LoadingDataSources() {
            using (SQL sql = SQL.MySql())
            {
                SubjectNames = sql.subjects.Select(x => x.Name).ToList();
            }
        }
        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!SubjectNames.Contains(SubjectNameTb.Text))
            {
                if (!string.IsNullOrEmpty(SubjectNameTb.Text))
                {
                    using (SQL sql = SQL.MySql())
                    {
                        if (editMode)
                        {
                            Subject s = sql.subjects.Single(x => x.ID == oldSubject.ID);
                            s.Name = SubjectNameTb.Text;
                            sql.SaveChanges();
                            this.Close();
                        }
                        else
                        {
                            Subject s = new Subject()
                            {
                                Name = SubjectNameTb.Text,
                            };
                            sql.subjects.Add(s);
                            sql.SaveChanges();
                            this.Close();

                        }
                    }
                }
                else 
                {
                    new ErrorMessageForm("A mező kitöltése kötelező!").Show();
                }
            }
            else
            {
                new ErrorMessageForm("Ilyen tantárgy már létezik!").ShowDialog();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
