
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DIA_Project.Properties.Resources.repair_tool;
            this.pictureBox1.Location = new System.Drawing.Point(716, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClassesCB);
            this.panel1.Controls.Add(this.SubjectsCB);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TestNameTb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 81);
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
            this.ClassesCB.Location = new System.Drawing.Point(623, 25);
            this.ClassesCB.Name = "ClassesCB";
            this.ClassesCB.Size = new System.Drawing.Size(94, 28);
            this.ClassesCB.TabIndex = 36;
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
            this.SubjectsCB.Location = new System.Drawing.Point(479, 25);
            this.SubjectsCB.Name = "SubjectsCB";
            this.SubjectsCB.Size = new System.Drawing.Size(138, 28);
            this.SubjectsCB.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(73, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 1);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cím:";
            // 
            // TestNameTb
            // 
            this.TestNameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TestNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TestNameTb.ForeColor = System.Drawing.Color.White;
            this.TestNameTb.Location = new System.Drawing.Point(73, 28);
            this.TestNameTb.Name = "TestNameTb";
            this.TestNameTb.PlaceholderText = "A dolgozat címe";
            this.TestNameTb.Size = new System.Drawing.Size(400, 20);
            this.TestNameTb.TabIndex = 0;
            // 
            // HomePnl
            // 
            this.HomePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomePnl.Location = new System.Drawing.Point(0, 81);
            this.HomePnl.Name = "HomePnl";
            this.HomePnl.Size = new System.Drawing.Size(760, 10);
            this.HomePnl.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TaskTypesCB);
            this.panel2.Controls.Add(this.HozzaadasBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 47);
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
            this.TaskTypesCB.Location = new System.Drawing.Point(404, 6);
            this.TaskTypesCB.Name = "TaskTypesCB";
            this.TaskTypesCB.Size = new System.Drawing.Size(213, 28);
            this.TaskTypesCB.TabIndex = 34;
            // 
            // HozzaadasBtn
            // 
            this.HozzaadasBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HozzaadasBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.HozzaadasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HozzaadasBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HozzaadasBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.HozzaadasBtn.Location = new System.Drawing.Point(623, 6);
            this.HozzaadasBtn.Name = "HozzaadasBtn";
            this.HozzaadasBtn.Size = new System.Drawing.Size(94, 29);
            this.HozzaadasBtn.TabIndex = 7;
            this.HozzaadasBtn.Text = "Hozzáadás";
            this.HozzaadasBtn.UseVisualStyleBackColor = true;
            this.HozzaadasBtn.Click += new System.EventHandler(this.HozzaadasBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 506);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 42);
            this.panel4.TabIndex = 11;
            // 
            // TeacherNewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(760, 548);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HomePnl);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherNewTestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherTestsUsersForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}