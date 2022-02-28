
namespace DIA_Project.Forms.TeacherForms
{
    partial class TeacherNewTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClassesCB = new System.Windows.Forms.ComboBox();
            this.SubjectsCB = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TestNameTb = new System.Windows.Forms.TextBox();
            this.HomePnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TaskTypesCB = new System.Windows.Forms.ComboBox();
            this.HozzaadasBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MegseBtn = new System.Windows.Forms.Button();
            this.FinishDTP = new System.Windows.Forms.DateTimePicker();
            this.StartDTP = new System.Windows.Forms.DateTimePicker();
            this.MentesBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IsInternetAllowedCb = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ClassesCB);
            this.panel1.Controls.Add(this.SubjectsCB);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TestNameTb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 61);
            this.panel1.TabIndex = 7;
            // 
            // ClassesCB
            // 
            this.ClassesCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClassesCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassesCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassesCB.ForeColor = System.Drawing.Color.White;
            this.ClassesCB.FormattingEnabled = true;
            this.ClassesCB.Items.AddRange(new object[] {
            "Osztály"});
            this.ClassesCB.Location = new System.Drawing.Point(545, 34);
            this.ClassesCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesCB.Name = "ClassesCB";
            this.ClassesCB.Size = new System.Drawing.Size(83, 23);
            this.ClassesCB.TabIndex = 3;
            // 
            // SubjectsCB
            // 
            this.SubjectsCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SubjectsCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubjectsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectsCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectsCB.ForeColor = System.Drawing.Color.White;
            this.SubjectsCB.FormattingEnabled = true;
            this.SubjectsCB.Items.AddRange(new object[] {
            "Tantárgy"});
            this.SubjectsCB.Location = new System.Drawing.Point(419, 34);
            this.SubjectsCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectsCB.Name = "SubjectsCB";
            this.SubjectsCB.Size = new System.Drawing.Size(121, 23);
            this.SubjectsCB.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(64, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 1);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cím:";
            // 
            // TestNameTb
            // 
            this.TestNameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TestNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TestNameTb.ForeColor = System.Drawing.Color.White;
            this.TestNameTb.Location = new System.Drawing.Point(64, 37);
            this.TestNameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TestNameTb.Name = "TestNameTb";
            this.TestNameTb.PlaceholderText = "A dolgozat címe";
            this.TestNameTb.Size = new System.Drawing.Size(350, 16);
            this.TestNameTb.TabIndex = 1;
            // 
            // HomePnl
            // 
            this.HomePnl.BackColor = System.Drawing.Color.Transparent;
            this.HomePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomePnl.Location = new System.Drawing.Point(0, 61);
            this.HomePnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePnl.Name = "HomePnl";
            this.HomePnl.Size = new System.Drawing.Size(665, 8);
            this.HomePnl.TabIndex = 5;
            this.HomePnl.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.TaskTypesCB);
            this.panel2.Controls.Add(this.HozzaadasBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 35);
            this.panel2.TabIndex = 10;
            // 
            // TaskTypesCB
            // 
            this.TaskTypesCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskTypesCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TaskTypesCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaskTypesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskTypesCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskTypesCB.ForeColor = System.Drawing.Color.White;
            this.TaskTypesCB.FormattingEnabled = true;
            this.TaskTypesCB.Location = new System.Drawing.Point(354, 4);
            this.TaskTypesCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskTypesCB.Name = "TaskTypesCB";
            this.TaskTypesCB.Size = new System.Drawing.Size(187, 23);
            this.TaskTypesCB.TabIndex = 4;
            // 
            // HozzaadasBtn
            // 
            this.HozzaadasBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HozzaadasBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.HozzaadasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HozzaadasBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HozzaadasBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.HozzaadasBtn.Location = new System.Drawing.Point(545, 4);
            this.HozzaadasBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HozzaadasBtn.Name = "HozzaadasBtn";
            this.HozzaadasBtn.Size = new System.Drawing.Size(82, 22);
            this.HozzaadasBtn.TabIndex = 0;
            this.HozzaadasBtn.Text = "Hozzáadás";
            this.HozzaadasBtn.UseVisualStyleBackColor = true;
            this.HozzaadasBtn.Click += new System.EventHandler(this.HozzaadasBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.IsInternetAllowedCb);
            this.panel4.Controls.Add(this.MegseBtn);
            this.panel4.Controls.Add(this.FinishDTP);
            this.panel4.Controls.Add(this.StartDTP);
            this.panel4.Controls.Add(this.MentesBtn);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 403);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(665, 32);
            this.panel4.TabIndex = 11;
            // 
            // MegseBtn
            // 
            this.MegseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MegseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.MegseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MegseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MegseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.MegseBtn.Location = new System.Drawing.Point(509, 4);
            this.MegseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MegseBtn.Name = "MegseBtn";
            this.MegseBtn.Size = new System.Drawing.Size(69, 25);
            this.MegseBtn.TabIndex = 8;
            this.MegseBtn.Text = "Mégse";
            this.MegseBtn.UseVisualStyleBackColor = true;
            this.MegseBtn.Click += new System.EventHandler(this.MegseBtn_Click);
            // 
            // FinishDTP
            // 
            this.FinishDTP.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.FinishDTP.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.FinishDTP.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.FinishDTP.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.FinishDTP.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.FinishDTP.Checked = false;
            this.FinishDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FinishDTP.Location = new System.Drawing.Point(218, 4);
            this.FinishDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FinishDTP.Name = "FinishDTP";
            this.FinishDTP.Size = new System.Drawing.Size(80, 23);
            this.FinishDTP.TabIndex = 7;
            // 
            // StartDTP
            // 
            this.StartDTP.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.StartDTP.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.StartDTP.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.StartDTP.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.StartDTP.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.StartDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartDTP.Location = new System.Drawing.Point(66, 4);
            this.StartDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartDTP.Name = "StartDTP";
            this.StartDTP.Size = new System.Drawing.Size(81, 23);
            this.StartDTP.TabIndex = 6;
            // 
            // MentesBtn
            // 
            this.MentesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MentesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.MentesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.MentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MentesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MentesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.MentesBtn.Location = new System.Drawing.Point(584, 4);
            this.MentesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MentesBtn.Name = "MentesBtn";
            this.MentesBtn.Size = new System.Drawing.Size(69, 25);
            this.MentesBtn.TabIndex = 9;
            this.MentesBtn.Text = "Mentés";
            this.MentesBtn.UseVisualStyleBackColor = false;
            this.MentesBtn.Click += new System.EventHandler(this.MentesBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.label3.Location = new System.Drawing.Point(153, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Befejezés:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kezdés:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.label4.Location = new System.Drawing.Point(304, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Internet engedélyezése:";
            // 
            // IsInternetAllowedCb
            // 
            this.IsInternetAllowedCb.AutoSize = true;
            this.IsInternetAllowedCb.Location = new System.Drawing.Point(442, 9);
            this.IsInternetAllowedCb.Name = "IsInternetAllowedCb";
            this.IsInternetAllowedCb.Size = new System.Drawing.Size(15, 14);
            this.IsInternetAllowedCb.TabIndex = 10;
            this.IsInternetAllowedCb.UseVisualStyleBackColor = true;
            // 
            // TeacherNewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImage = global::DIA_Project.Properties.Resources.WinFormBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 435);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HomePnl);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeacherNewTestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherTestsUsersForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TestNameTb;
        private System.Windows.Forms.Panel HomePnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HozzaadasBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ClassesCB;
        private System.Windows.Forms.ComboBox SubjectsCB;
        private System.Windows.Forms.ComboBox TaskTypesCB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button MentesBtn;
        private System.Windows.Forms.DateTimePicker StartDTP;
        private System.Windows.Forms.DateTimePicker FinishDTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MegseBtn;
        private System.Windows.Forms.CheckBox IsInternetAllowedCb;
        private System.Windows.Forms.Label label4;
    }
}