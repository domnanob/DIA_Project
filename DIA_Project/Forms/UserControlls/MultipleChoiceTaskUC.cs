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
    public partial class MultipleChoiceTaskUC : UserControl
    {
        public MultipleChoiceTaskUC(Models.Tasks t, List<Answers> a)
        {
            InitializeComponent();
            CurrentTask = t;
            CurrentAnswers = a;
            TaskNameL.Text = t.Task;
            this.SuspendLayout();
            LoadAnswers();
            this.ResumeLayout(false);
        }
        private int ansDb = 0;
        public Models.Tasks CurrentTask = new Models.Tasks();
        private List<Answers> CurrentAnswers = new List<Answers>();
        private void LoadAnswers() 
        {
            //Válaszok összekeverése
            Random rng = new Random();
            var RandomizedAnswers = CurrentAnswers.OrderBy(a => rng.Next()).ToList();

            //Válaszok betöltése
            foreach (var item in RandomizedAnswers)
            {
                CheckBox CB = new CheckBox()
                {
                    Name = "ans" + ansDb,
                    Dock = DockStyle.Top,
                    ForeColor = Color.White,
                    Text = item.Answer,
                    TextAlign = ContentAlignment.MiddleLeft,
                };
                this.Height += 23;
                panel2.Height += 23;
                panel2.Controls.Add(CB);
            }
        }
        public List<Answers> GetAnswers() { 
            List<CheckBox> Cbs = panel2.Controls.OfType<CheckBox>().ToList();
            List<Answers> ChoosenAns = new List<Answers>();
            foreach (var item in Cbs)
            {
                if (item.Checked)
                {
                    ChoosenAns.Add(SQL.MySql().answers.Single(x => x.Answer == item.Text && x.TaskID == CurrentTask.ID));
                }
            }
            return ChoosenAns;
        }
    }
}
