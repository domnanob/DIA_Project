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
        }
        private Teachers CurrentTeacher = new Teachers();
        private List<Classes> classes = new List<Classes>();
        private List<Subjects> subjects = new List<Subjects>();
        private List<Positions> positions = new List<Positions>();
        public void ReLoad() {
            classes.Clear();
            subjects.Clear();
            positions.Clear();
            using (SQL sql = SQL.MySql())
            {
                foreach (var item in sql.positions)
                {
                    positions.Add(item);
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
                foreach (var item in sql.subjects.OrderBy(x => x.Name))
                {
                    foreach (var p in positions)
                    {
                        if (p.TeacherID == CurrentTeacher.Username && p.SubjectID == item.ID)
                        {
                            if (!SubjectCB.Items.Contains(item.Name))
                            {
                                SubjectCB.Items.Add(item.Name);
                                subjects.Add(item);
                            }
                        }
                    }
                }
                dataGridView1.DataSource = classes;
            }
        }

        private void ClassesCB_SelectedValueChanged(object sender, EventArgs e)
        {
            SubjectCB.Items.Clear();
            Classes c = classes.Single(x => x.Name == ClassesCB.Items[ClassesCB.SelectedIndex]);
            foreach (var item in positions)
            {
                if (item.TeacherID == CurrentTeacher.Username && item.ClassID == c.ID)
                {
                    Subjects s = subjects.Single(x => x.ID == item.SubjectID);
                    SubjectCB.Items.Add(s.Name);
                }
            }
        }

        private void SubjectCB_SelectedValueChanged(object sender, EventArgs e)
        {
            /*
            ClassesCB.Items.Clear();
            Subjects s = subjects.Single(x => x.Name == SubjectCB.Items[SubjectCB.SelectedIndex]);
            foreach (var item in positions)
            {
                if (item.TeacherID == CurrentTeacher.Username && item.SubjectID == s.ID)
                {
                    Classes c = classes.Single(x => x.ID == item.ClassID);
                    ClassesCB.Items.Add(c.Name);
                }
            }*/
        }
    }
}
