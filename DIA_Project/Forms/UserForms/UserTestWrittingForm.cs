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
using System.Threading;

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
            if (t.InternetAllowed == 0)
            {
                idozito.Tick += Idozito_Tick;
                idozito.Interval = 1000;
                idozito.Start();
                _Anticheat();
            }
        }

        private void Idozito_Tick(object sender, EventArgs e)
        {
            if (isCheating)
            {
                LeadasBtn_Click(this.LeadasBtn, EventArgs.Empty);
                idozito.Stop();
            }
        }

        private Users CurrentUser = new Users();
        private Tests CurrentTest = new Tests();
        private List<Tasks> CurrentTasks = new List<Tasks>();
        private List<Answers> CurrentAnswers = new List<Answers>();
        private int ChoiseDb = 0;
        private bool isCheating = false;
        private bool done = false;
        private System.Windows.Forms.Timer idozito = new System.Windows.Forms.Timer();

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
        private void _Anticheat()
        {
            Task.Run(async() =>
            {
                while (!done)
                {
                    if (CheatDetector.DetectBrowser())
                    {
                        new ErrorMessageForm("Böngésző használata nem engedélyezett dolgozatírás közben! \n" +
                            "A dolgozat a jelenlegi állapotában leadásra került!").ShowDialog();
                        isCheating = true;
                        done = true;
                        break;
                    }
                    if (!done)
                    {
                        await Task.Delay(5000);
                    }
                }
            });
        }
        private void NewMultipleChoiseTask(Tasks t) 
        {
            MultipleChoiceTaskUC MCTUC = new MultipleChoiceTaskUC(t, CurrentAnswers.Where(x => x.TaskID == t.ID).ToList())
            {
                Dock = DockStyle.Top,
                Name = "MultipleChoise" + ChoiseDb,
                Padding = new Padding(10,0,0,0)
            };
            this.HomePnl.Height += MCTUC.Height;
            this.HomePnl.Controls.Add(MCTUC);
            ChoiseDb++;
        }
        private void LoadingTasks() {
            //Kérdések összekeverése
            Random rng = new Random();
            var RandomizedTasks = CurrentTasks.OrderBy(a => rng.Next()).ToList();

            foreach (var item in RandomizedTasks)
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
                foreach (var item in HomePnl.Controls.OfType<MultipleChoiceTaskUC>().ToList())
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
