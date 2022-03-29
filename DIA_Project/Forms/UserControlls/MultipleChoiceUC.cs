using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DIA_Project.Forms.User_Controlls
{
    public partial class MultipleChoiceUC : UserControl
    {
        public MultipleChoiceUC()
        {
            InitializeComponent();
        }
        public string GetTaskName()
        {
            return TaskNameTb.Text;
        }
        public int GetPoints()
        {
            return int.Parse(PointsTb.Text);
        }
        public bool IsAllFieldFilled(out string ErrorMessage)
        {
            bool IsCorrectExists = false;
            List<string> Answers = new List<string>();
            foreach (var item in GetRBUC())
            {
                if (Answers.Contains(item.GetAnswer().Item1))
                {
                    ErrorMessage = "Nem lehet két azonos válasz ugyanarra a kérdésre!";
                    return false;
                }
                else
                {
                    Answers.Add(item.GetAnswer().Item1);
                }
                if (string.IsNullOrEmpty(item.GetAnswer().Item1))
                {
                    ErrorMessage = "Nincs kitöltve minden válasz!";
                    return false;
                }
                if (item.GetAnswer().Item2)
                {
                    IsCorrectExists = true;
                }
            }
            if (IsCorrectExists == false)
            {
                ErrorMessage = "Egy kérdésnél legalább egy helyes választ is meg kell jelölni!";
                return false;
            }
            if (string.IsNullOrEmpty(TaskNameTb.Text))
            {
                ErrorMessage = "Nincs kitöltve minden kérdés!";
                return false;
            }
            if (string.IsNullOrEmpty(PointsTb.Text))
            {
                ErrorMessage = "Nincs pontszám megadva egy kérdésre!";
                return false;
            }
            ErrorMessage = string.Empty;
            return true;
        }
        public List<RadioButtonsUC> GetRBUC()
        {
            return this.panel2.Controls.OfType<RadioButtonsUC>().ToList();
        }
        RadioButtonsUC RBUC = new RadioButtonsUC()
        {
            Height = 55,
            Dock = DockStyle.Top
        };
        private void HozzaadasBtn_Click(object sender, EventArgs e)
        {
            RBUC = new RadioButtonsUC()
            {
                Height = 55,
                Dock = DockStyle.Top
            };
            RBUC.BackColorChanged += new System.EventHandler(this.radioButtonsuc_BackColorChanged);
            this.Height += 55;
            this.panel2.Height += 55;
            this.panel2.Controls.Add(RBUC);
        }

        private void radioButtonsuc_BackColorChanged(object sender, EventArgs e)
        {
            RadioButtonsUC Current = sender as RadioButtonsUC;
            this.panel2.Controls.Remove(Current);
            this.Height -= 55;
            this.panel2.Height -= 55;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void PointsTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
