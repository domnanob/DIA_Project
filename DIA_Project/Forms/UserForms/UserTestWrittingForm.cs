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

namespace DIA_Project.Forms.UserForms
{
    public partial class UserTestWrittingForm : Form
    {
        public UserTestWrittingForm(Users u, Tests t)
        {
            InitializeComponent();
            CurrentUser = u;
            CurrentTest = t;
            DNameL.Text = t.Name;
            LoadingDataSources();
            LoadingTasks();
        }
        private Users CurrentUser = new Users();
        private Tests CurrentTest = new Tests();
        private List<Tasks> CurrentTasks = new List<Tasks>();
        private List<Answers> CurrentAnswers = new List<Answers>();
        private int ChoiseDb = 0;
        private void LoadingDataSources() {
            using (SQL sql = SQL.MySql())
            {
                CurrentTasks = sql.tasks.Where(x => x.TestID == CurrentTest.ID).ToList();
                foreach (var item in sql.answers)
                {
                    foreach (var item2 in CurrentTasks)
                    {
                        if (item.TaskID == item2.ID)
                        {
                            CurrentAnswers.Add(item);
                            break;
                        }
                    }
                }
            }
        }
        private void NewMultipleChoiseTask(Tasks t) 
        {
            MultipleChoiseTaskUC MCTUC = new MultipleChoiseTaskUC(t, CurrentAnswers.Where(x => x.TaskID == t.ID).ToList())
            {
                Height = 115,
                Dock = DockStyle.Top,
                Name = "MultipleChoise" + ChoiseDb,
                Padding = new Padding(10,0,0,0)
            };
            this.HomePnl.Height += 115;
            this.HomePnl.Controls.Add(MCTUC);
            ChoiseDb++;
        }
        private void LoadingTasks() {
            foreach (var item in CurrentTasks)
            {
                if (item.TypeID == 1)
                {
                    NewMultipleChoiseTask(item);
                }
            }
        }

        private void TeacherTestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void LeadasBtn_Click(object sender, EventArgs e)
        {
            using (SQL sql = SQL.MySql())
            {
                UserTests UT = sql.userTests.Single(x => x.TestID == CurrentTest.ID && x.UserID == CurrentUser.Username);
                UT.Completed = 1;
                UT.FinishDate = DateTime.Now;
                sql.SaveChanges();
                foreach (var item in HomePnl.Controls.OfType<MultipleChoiseTaskUC>().ToList())
                {
                    foreach (var ans in item.GetAnswers())
                    {
                        UserAnswers UA = new UserAnswers()
                        {
                            UserTestID = UT.ID,
                            TaskID = item.CurrentTask.ID,
                            AnswerID = ans.ID,
                        };
                        sql.userAnswers.Add(UA);
                    }
                }
                sql.SaveChanges();
                new SuccessMessageForm("Sikeresen leadtad a dolgozatot!").ShowDialog();
                Program.HF.ImitateClick("HomeBtn");
            }
        }
    }
}
