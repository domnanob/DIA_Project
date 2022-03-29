using DIA_Project.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DIA_Project.Forms.User_Controlls
{
    public partial class MultipleChoiceResultUC : UserControl
    {
        public MultipleChoiceResultUC(Models.Tasks t, List<Answers> ca, List<Answers> ua)
        {
            InitializeComponent();
            CurrentTask = t;
            CorrectAns = ca;
            UserAns = ua;
            TaskNameL.Text = t.Task;
            this.SuspendLayout();
            LoadAnswers();
            this.ResumeLayout(false);
        }
        private int ansDb = 0;
        private int panelDb = 0;
        public Models.Tasks CurrentTask = new Models.Tasks();
        private List<Answers> CorrectAns = new List<Answers>();
        private List<Answers> UserAns = new List<Answers>();
        private void LoadAnswers()
        {
            foreach (var item in CorrectAns)
            {
                this.Height += 30;
                CorrectAnsPnl.Height += 30;
                CheckBox CorrectAnswerCB = new CheckBox()
                {
                    Name = "ans" + ansDb,
                    Dock = DockStyle.Top,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point),
                    Text = item.Answer,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Enabled = false,
                    Checked = true,
                    Height = 30,
                };
                CorrectAnsPnl.Controls.Add(CorrectAnswerCB);
            }
            for (int i = 0; i < CorrectAns.Count - UserAns.Count; i++)
            {
                this.Height += 30;
                ChoosenAnsPnl.Height += 30;
                Panel MissingAnsP = new Panel()
                {
                    Name = "panel",
                    Dock = DockStyle.Top,
                    Height = 30,
                };
                panelDb++;
                ChoosenAnsPnl.Controls.Add(MissingAnsP);
                CheckBox MissingAns = new CheckBox()
                {
                    Name = "ans" + ansDb,
                    Dock = DockStyle.Fill,
                    ForeColor = Color.White,
                    Text = "-",
                    TextAlign = ContentAlignment.MiddleLeft,
                    Enabled = false,
                };
                MissingAnsP.BackColor = Color.FromArgb(148, 33, 55);
                MissingAnsP.Controls.Add(MissingAns);
            }
            foreach (var item in UserAns)
            {
                this.Height += 30;
                ChoosenAnsPnl.Height += 30;
                Panel UserAnswerP = new Panel()
                {
                    Name = "panel" + panelDb,
                    Dock = DockStyle.Top,
                    Height = 30,
                };
                panelDb++;
                ChoosenAnsPnl.Controls.Add(UserAnswerP);
                CheckBox UserAnswerCB = new CheckBox()
                {
                    Name = "ans" + ansDb,
                    Dock = DockStyle.Fill,
                    ForeColor = Color.White,
                    Text = item.Answer,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Enabled = false,
                };
                foreach (var ans in CorrectAns)
                {
                    if (ans.Answer == item.Answer)
                    {
                        UserAnswerP.BackColor = Color.FromArgb(28, 150, 56);
                        UserAnswerCB.Checked = true;
                        break;
                    }
                    else
                    {
                        UserAnswerP.BackColor = Color.FromArgb(148, 33, 55);
                    }
                }
                UserAnswerP.Controls.Add(UserAnswerCB);
            }
        }
        public List<Answers> GetAnswers()
        {
            List<CheckBox> Cbs = CorrectTitlePnl.Controls.OfType<CheckBox>().ToList();
            List<Answers> ChoosenAns = new List<Answers>();
            foreach (var item in Cbs)
            {
                if (item.Checked)
                {
                    ChoosenAns.Add(SQL.MySql().answers.Single(x => x.Answer == item.Text));
                }
            }
            return ChoosenAns;
        }
    }
}
