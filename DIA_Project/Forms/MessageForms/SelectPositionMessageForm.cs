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
    public partial class SelectPositionMessageForm : Form
    {
        public SelectPositionMessageForm(Teachers t)
        {
            InitializeComponent();
            LoadingDataSources();
            CurrentTeacher = t;

        }
        private Teachers CurrentTeacher = new Teachers();
        private void LoadingDataSources() {
            using (SQL sql = SQL.MySql())
            {
                foreach (var item in sql.classes.OrderBy(x => x.Name).ToList())
                {
                    ClassesCB.Items.Add(item.Name);
                }
                foreach (var item in sql.subjects.OrderBy(x => x.Name).ToList())
                {
                    SubjectCb.Items.Add(item.Name);
                }
                ClassesCB.SelectedIndex = 0;
                SubjectCb.SelectedIndex = 0;

            }
        }
        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (ClassesCB.SelectedIndex != 0 && SubjectCb.SelectedIndex != 0)
            {
                using (SQL sql = SQL.MySql())
                {
                    int classID = sql.classes.Single(x => x.Name == ClassesCB.Items[ClassesCB.SelectedIndex].ToString()).ID;
                    int subjectID = sql.subjects.Single(x => x.Name == SubjectCb.Items[SubjectCb.SelectedIndex].ToString()).ID;
                    Positions tp = null;
                    try
                    {
                        tp = sql.positions.Single(x => x.TeacherID == CurrentTeacher.Username && x.ClassID == classID && x.SubjectID == subjectID);
                        new ErrorMessageForm("Ilyen pozícióban már dolgozik a tanár!").ShowDialog();
                        return;
                    }
                    catch
                    {
                        Positions p = new Positions()
                        {
                            ClassID = classID,
                            SubjectID = subjectID,
                            TeacherID = CurrentTeacher.Username
                        };
                        sql.positions.Add(p);
                        sql.SaveChanges();
                        new SuccessMessageForm("Sikeresen hozzáadtad a pozíciót!").ShowDialog();
                        this.Close();
                    }
                }
            }
            else {
                new ErrorMessageForm("Minden mezőt ki kell tölteni!").ShowDialog();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
