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
using DIA_Project.Forms.User_Controlls;

namespace DIA_Project.Forms.TeacherForms
{
    public partial class TeacherNewTestForm : Form
    {
        public TeacherNewTestForm(Teachers t, List<Positions> p)
        {
            InitializeComponent();
            CurrentTeacher = t;
            CurrentPositions = p;
            LoadResources();
        }
        private int ChoiseDB = 0;
        private Teachers CurrentTeacher = new Teachers();
        private List<Positions> CurrentPositions = new List<Positions>();
        private List<UserTests> UT = new List<UserTests>();
        private List<Tuple<string,int>> MCUL = new List<Tuple<string,int>>();
        void LoadResources() {
            TaskTypesCB.Items.Clear();
            using (SQL sql = SQL.MySql())
            {
                foreach (var item in sql.taskTypes)
                {
                    TaskTypesCB.Items.Add(item.Name);
                }
                TaskTypesCB.SelectedIndex = 0;
                foreach (var item in sql.classes.OrderBy(x => x.Name))
                {
                    foreach (var p in CurrentPositions)
                    {
                        if (p.TeacherID == CurrentTeacher.Username && p.ClassID == item.ID)
                        {
                            if (!ClassesCB.Items.Contains(item.Name))
                            {
                                ClassesCB.Items.Add(item.Name);
                            }
                        }
                    }
                }
                ClassesCB.SelectedIndex = 0;
                foreach (var item in sql.subjects) 
                {
                    foreach (var p in CurrentPositions)
                    {
                        if (p.TeacherID == CurrentTeacher.Username && item.ID == p.SubjectID)
                        {
                            if (!SubjectsCB.Items.Contains(item.Name))
                            {
                                SubjectsCB.Items.Add(item.Name);
                            }
                        }
                    }
                }
                SubjectsCB.SelectedIndex = 0;
            }
        }
        private void TeacherTestsUsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void HozzaadasBtn_Click(object sender, EventArgs e)
        {
            if (TaskTypesCB.SelectedIndex == 0)
            {
                MultipleChoiseUC MCUC = new MultipleChoiseUC()
                {
                    Height = 115,
                    Dock = DockStyle.Top,
                    Name = "MultipleChoise"+ChoiseDB,
                };
                MCUL.Add(Tuple.Create(MCUC.Name,MCUC.Height));
                MCUC.SizeChanged += new System.EventHandler(this.multipleChoiseuc_SizeChanged);
                MCUC.BackColorChanged += new System.EventHandler(this.multipleChoiseuc_BackColorChanged);
                this.HomePnl.Height += 115;
                this.HomePnl.Controls.Add(MCUC);
                ChoiseDB++;
            }
        }
        private void multipleChoiseuc_SizeChanged(object sender, EventArgs e)
        {
            MultipleChoiseUC Current = sender as MultipleChoiseUC;
            if (Current.Height > MCUL.Single(x => x.Item1 == Current.Name).Item2)
            {
                this.HomePnl.Height += 55;
                MCUL.Remove(MCUL.Single(x => x.Item1 == Current.Name));
                MCUL.Add(Tuple.Create(Current.Name, Current.Height));
            }
            else if (Current.Height < MCUL.Single(x => x.Item1 == Current.Name).Item2) 
            {
                this.HomePnl.Height -= 55;
                MCUL.Remove(MCUL.Single(x => x.Item1 == Current.Name));
                MCUL.Add(Tuple.Create(Current.Name, Current.Height));
            }
        }

        private void multipleChoiseuc_BackColorChanged(object sender, EventArgs e)
        {
            MultipleChoiseUC Current = sender as MultipleChoiseUC;
            this.HomePnl.Controls.Remove(Current);
            this.HomePnl.Height -= MCUL.Single(x => x.Item1 == Current.Name).Item2;
            MCUL.Remove(MCUL.Single(x => x.Item1 == Current.Name));
        }
    }
}
