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
    public partial class ClassNameMessageForm : Form
    {
        public ClassNameMessageForm(Classes OldClass = null, bool Editmode = false)
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            editMode = Editmode;
            oldClass = OldClass;
            ClassNameTb.Text = (editMode)? OldClass.Name : string.Empty;
            LoadingDataSources();

        }
        bool editMode = false;
        Classes oldClass = null;
        List<string> ClassNames = new List<string>();
        private void LoadingDataSources() {
            using (SQL sql = SQL.MySql())
            {
                ClassNames = sql.classes.Select(x => x.Name).ToList();
            }
        }
        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ClassNameTb.Text))
            {
                if (!ClassNames.Contains(ClassNameTb.Text))
                {
                    using (SQL sql = SQL.MySql())
                    {
                        if (editMode)
                        {
                            Classes c = sql.classes.Single(x => x.ID == oldClass.ID);
                            c.Name = ClassNameTb.Text;
                            sql.SaveChanges();
                            this.Close();
                        }
                        else
                        {
                            Classes c = new Classes()
                            {
                                Name = ClassNameTb.Text,
                            };
                            sql.classes.Add(c);
                            sql.SaveChanges();
                            this.Close();
                        }
                    }
                }
                else
                {
                    new ErrorMessageForm("Ilyen osztály már létezik!").ShowDialog();
                }
            }
            else 
            {
                new ErrorMessageForm("A mező kitöltése kötelező!").Show();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
