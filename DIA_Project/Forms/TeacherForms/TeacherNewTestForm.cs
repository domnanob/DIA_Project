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
        public TeacherNewTestForm(Teacher t, List<Position> p)
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            CurrentTeacher = t;
            CurrentPositions = p;
            LoadingDataSources();
        }
        private int ChoiseDB = 0;
        private int CurrentTestID = 0;
        private int CurrentTaskID = 0;
        private Teacher CurrentTeacher = new Teacher();
        private List<Position> CurrentPositions = new List<Position>();
        private List<UserTest> UT = new List<UserTest>();
        private List<Tuple<string,int>> MCUL = new List<Tuple<string,int>>();
        void LoadingDataSources() {
            TaskTypesCB.Items.Clear();
            using (SQL sql = SQL.MySql())
            {
                try
                {
                    CurrentTestID = sql.tests.Max(x => x.ID) + 1;
                    CurrentTaskID = sql.tasks.Max(y => y.ID) + 1;
                }
                catch (Exception)
                {
                    CurrentTestID = 1;
                    CurrentTaskID = 1;
                }
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
                MultipleChoiceUC MCUC = new MultipleChoiceUC()
                {
                    Dock = DockStyle.Top,
                    Name = "MultipleChoise"+ChoiseDB,
                };
                MCUL.Add(Tuple.Create(MCUC.Name,MCUC.Height));
                MCUC.SizeChanged += new System.EventHandler(this.multipleChoiseuc_SizeChanged);
                MCUC.BackColorChanged += new System.EventHandler(this.multipleChoiseuc_BackColorChanged);
                this.HomePnl.Height += MCUC.Height;
                this.HomePnl.Controls.Add(MCUC);
                ChoiseDB++;
            }
        }
        private void multipleChoiseuc_SizeChanged(object sender, EventArgs e)
        {
            MultipleChoiceUC Current = sender as MultipleChoiceUC;
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
            MultipleChoiceUC Current = sender as MultipleChoiceUC;
            this.HomePnl.Controls.Remove(Current);
            this.HomePnl.Height -= MCUL.Single(x => x.Item1 == Current.Name).Item2;
            MCUL.Remove(MCUL.Single(x => x.Item1 == Current.Name));
        }
        private void MentesBtn_Click(object sender, EventArgs e)
        {
            if (SubjectsCB.SelectedIndex == 0 || ClassesCB.SelectedIndex == 0 || StartDTP.Value >= FinishDTP.Value || string.IsNullOrEmpty(TestNameTb.Text))
            {
                new ErrorMessageForm("Minden mező kitöltése kötelező!").ShowDialog();
                return;
            }
            if (this.HomePnl.Controls.OfType<MultipleChoiceUC>().ToList().Count == 0)
            {
                new ErrorMessageForm("Nincs feladat hozzáadva!").ShowDialog();
                return;
            }
            foreach (var item in this.HomePnl.Controls.OfType<MultipleChoiceUC>())
            {
                string EM;
                if (!item.IsAllFieldFilled(out EM))
                {
                    new ErrorMessageForm(EM).ShowDialog();
                    return;
                }
            }
            using (SQL sql = SQL.MySql())
            {
                Test tst = new Test()
                {
                    ID = CurrentTestID,
                    ClassID = sql.classes.Single(x => x.Name == ClassesCB.Items[ClassesCB.SelectedIndex].ToString()).ID,
                    Name = TestNameTb.Text,
                    SubjectID = sql.subjects.Single(x => x.Name == SubjectsCB.Items[SubjectsCB.SelectedIndex].ToString()).ID,
                    MaxPoints = 0,
                    Locked = 0,
                    TeacherID = CurrentTeacher.Username,
                    StartDate = StartDTP.Value,
                    FinishDate = FinishDTP.Value,
                    InternetAllowed = (IsInternetAllowedCb.Checked) ? 1 : 0
                };
                sql.tests.Add(tst);
                sql.SaveChanges();
                int CurrentMaxPoint = 0;
                foreach (var item in this.HomePnl.Controls.OfType<MultipleChoiceUC>()) //Végigmegy az összes Feladaton
                {
                    Models.Tasks tsk = new Models.Tasks() {
                        ID = CurrentTaskID,
                        TestID = CurrentTestID,
                        Task = item.GetTaskName(),
                        Points = item.GetPoints(),
                        TypeID = 1,
                    };
                    sql.tasks.Add(tsk);
                    sql.SaveChanges();
                    CurrentMaxPoint += tsk.Points;
                    List<RadioButtonsUC> ItemData = item.GetRBUC();
                    foreach (var RB in ItemData) //Feladatokon bellüli válaszok
                    {
                        Tuple<string,bool> RBData = RB.GetAnswer();
                        Answers ans = new Answers()
                        {
                            TaskID = CurrentTaskID,
                            Answer = RBData.Item1,
                            Correct = (RBData.Item2) ? 1 : 0,
                        };
                        sql.answers.Add(ans);
                    }
                    sql.SaveChanges();
                    CurrentTaskID++;
                }
                int cID = sql.classes.Single(x => x.Name == ClassesCB.Items[ClassesCB.SelectedIndex].ToString()).ID;
                foreach (var item in sql.users)
                {
                    if (item.ClassID == cID)
                    {
                        UserTest UT = new UserTest() {
                            UserID = item.Username,
                            TestID = CurrentTestID,
                            Completed = 0,                            
                        };
                        sql.userTests.Add(UT);
                    }
                }
                sql.tests.Single(x => x.ID == CurrentTestID).MaxPoints = CurrentMaxPoint;
                sql.SaveChanges();
            }
            new SuccessMessageForm("Sikeresen létrehoztad a dolgozatot!").ShowDialog();
            Program.TF.ImitateClick("DolgozatokBtn");
        }

        private void MegseBtn_Click(object sender, EventArgs e)
        {
            Program.TF.ImitateClick("DolgozatokBtn");
        }
    }
}
