using DIA_Project.Forms.User_Controlls;
using DIA_Project.Lib;
using DIA_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DIA_Project.Forms.UserForms
{
    public partial class UserTestWatchingForm : Form
    {
        public UserTestWatchingForm(User u, Test t)
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            CurrentUser = u;
            CurrentTest = t;
            DNameL.Text = t.Name;

            LoadingDataSources();
            LoadingTasks();
        }
        private User CurrentUser = new User();
        private Test CurrentTest = new Test();
        private List<Models.Tasks> CurrentTasks = new List<Models.Tasks>();
        private List<Answers> CurrentAns = new List<Answers>();
        private List<Answers> UserAns = new List<Answers>();
        private int ChoiseDb = 0;
        private void LoadingDataSources()
        {
            using (SQL sql = SQL.MySql())
            {
                CurrentTasks = sql.tasks.Where(x => x.TestID == CurrentTest.ID).ToList();
                foreach (var item in sql.answers)
                {
                    foreach (var item2 in CurrentTasks)
                    {
                        if (item.TaskID == item2.ID && item.Correct == 1)
                        {
                            CurrentAns.Add(item);
                            break;
                        }
                    }
                }
                int userTestID = sql.userTests.Single(x => x.UserID == CurrentUser.Username && x.TestID == CurrentTest.ID).ID;
                foreach (var item in sql.userAnswers.Where(x => x.UserTestID == userTestID))
                {
                    UserAns.Add(SQL.MySql().answers.Single(y => y.ID == item.AnswerID));
                }
            }
        }
        private void NewMultipleChoiseTask(Models.Tasks t)
        {
            MultipleChoiceResultUC MCTRC = new MultipleChoiceResultUC(t, CurrentAns.Where(x => x.TaskID == t.ID).ToList(), UserAns.Where(y => y.TaskID == t.ID).ToList())
            {
                Dock = DockStyle.Top,
                Name = "MultipleChoise" + ChoiseDb,
                Enabled = false,
                Padding = new Padding(10, 0, 0, 0),
            };
            this.HomePnl.Height += MCTRC.Height;
            this.HomePnl.Controls.Add(MCTRC);
            ChoiseDb++;
        }
        private void LoadingTasks()
        {
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

        private void VisszaBtn_Click(object sender, EventArgs e)
        {
            Program.HF.OpenChildForm(new UserTestsForm(CurrentUser));
        }
    }
}
