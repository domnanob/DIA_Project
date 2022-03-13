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
    public partial class TeacherTestWatchingForm : Form
    {
        public TeacherTestWatchingForm(Teacher tea, User u, Test t)
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            CurrentUser = u;
            CurrentTeacher = tea;
            CurrentTest = t;

            DNameL.Text = t.Name;
            UserNameTb.Text = u.Name;

            LoadingDataSources();
            LoadingTasks();
        }
        private Teacher CurrentTeacher = new Teacher();
        private User CurrentUser = new User();
        private Test CurrentTest = new Test();
        private List<Models.Tasks> CurrentTasks = new List<Models.Tasks>();
        private List<Answers> CurrentAns = new List<Answers>();
        private List<Answers> UserAns = new List<Answers>();
        private int ChoiseDb = 0;
        private void LoadingDataSources() {
            using (SQL sql = SQL.MySql())
            {
                CurrentTasks = sql.tasks.Where(x => x.TestID == CurrentTest.ID).ToList();
                foreach (var item in sql.answers)
                {
                    foreach (var item2 in CurrentTasks)
                    {
                        if (item.TaskID == item2.ID && item.Correct==1)
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
            MultipleChoiceCorrectingUC MCTRC = new MultipleChoiceCorrectingUC(t, CurrentAns.Where(x => x.TaskID == t.ID).ToList(), UserAns.Where(y => y.TaskID == t.ID).ToList())
            {
                Dock = DockStyle.Top,
                Name = "MultipleChoise" + ChoiseDb,
                Padding = new Padding(10,0,0,0)
            };
            this.HomePnl.Height += MCTRC.Height;
            this.HomePnl.Controls.Add(MCTRC);
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

        private void VisszaBtn_Click(object sender, EventArgs e)
        {
            Program.TF.OpenChildForm(new TeacherTestsUsersForm(CurrentTeacher, CurrentTest));
        }

        private void MentesBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in HomePnl.Controls.OfType<MultipleChoiceCorrectingUC>().ToList())
            {
                if (!item.isCorrected())
                {
                    new ErrorMessageForm("Nem javítottál ki minden feladatot!").ShowDialog();
                    return;
                }
            }
            using (SQL sql = SQL.MySql())
            {
                UserTest ut = sql.userTests.Single(x => x.TestID == CurrentTest.ID && x.UserID == CurrentUser.Username);
                ut.CorrectState = 1;
                ut.Points = 0;
                foreach (var item in HomePnl.Controls.OfType<MultipleChoiceCorrectingUC>().ToList())
                {
                    ut.Points += double.Parse(item.GetPoints());
                }
                sql.users.Single(x => x.Username == CurrentUser.Username).Money += Convert.ToInt32(ut.Points);
                sql.SaveChanges();
            }
            new SuccessMessageForm("Sikeresen kijavítottad a dolgozatot!").ShowDialog();
            Program.TF.ImitateClick("HomeBtn");
        }
    }
}
