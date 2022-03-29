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

namespace DIA_Project.Forms.User_Controlls
{
    public partial class MultipleChoiceCorrectingUC : UserControl
    {
        public MultipleChoiceCorrectingUC(Models.Tasks t, List<Answers> ca,List<Answers> ua)
        {
            InitializeComponent();
            this.SuspendLayout();
            CurrentTask = t;
            CorrectAns = ca;
            oneAnswerPoint = t.Points / CorrectAns.Count;
            UserAns = ua;
            TaskNameL.Text = t.Task;
            PontTb.Text = t.Points+"/";
            LoadAnswers();
            this.ResumeLayout(false);
        }
        private int ansDb = 0;
        private int panelDb = 0;
        private double oneAnswerPoint = 0;
        private double points = 0;
        private bool Locked = false;
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
                //PontTb.Text = PontTb.Text.Split("/")[0].ToString() + "/" + (double.Parse(PontTb.Text.Split("/")[1]) - oneAnswerPoint).ToString();
                MissingAnsP.Controls.Add(MissingAns);
            }
            foreach (var item in UserAns)
            {
                this.Height += 30;
                ChoosenAnsPnl.Height += 30;
                Panel UserAnswerP = new Panel() {
                    Name = "panel"+panelDb,
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
                        points += oneAnswerPoint;
                        //PontTb.Text = PontTb.Text.Split("/")[0].ToString() + "/" + (double.Parse(PontTb.Text.Split("/")[1]) + oneAnswerPoint).ToString();
                        break;
                    }
                    else
                    { 
                        UserAnswerP.BackColor = Color.FromArgb(148, 33, 55);
                        //PontTb.Text = PontTb.Text.Split("/")[0].ToString() + "/" + (double.Parse(PontTb.Text.Split("/")[1]) - oneAnswerPoint).ToString();
                    }
                }
                UserAnswerP.Controls.Add(UserAnswerCB);
            }
            PontTb.Text = PontTb.Text + points.ToString();
        }
        public string GetPoints() {
            try
            {
                return PontTb.Text.Split('/')[1];
            }
            catch {
                return "Hibás Pontozás!";
            }
        }
        public bool isCorrected() {
            if (PontTb.Enabled)
            {
                return false;
            }
            return true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double.Parse(PontTb.Text.Split('/')[1]);
                if (string.IsNullOrEmpty(PontTb.Text.Split('/')[1]))
                {
                    PontTb.Text += "0";
                }
                if (Locked)
                {
                    pictureBox1.Image = Properties.Resources.check_lists;
                    PontTb.Enabled = true;
                    Locked = false;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.cancel;
                    PontTb.Enabled = false;
                    Locked = true;
                }
            }
            catch
            {
                new ErrorMessageForm("Hibás pontozás!").Show();
            }
        }

        private void PontTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(PontTb.Text.Split('/')[1]) < 0)
                {
                    string s = PontTb.Text.Split('/')[0];
                    PontTb.Text = s + "/" + "0";
                }
            } catch { }
        }
    }
}
