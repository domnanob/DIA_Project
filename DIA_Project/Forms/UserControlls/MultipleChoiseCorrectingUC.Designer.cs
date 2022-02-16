namespace DIA_Project.Forms.User_Controlls
{
    partial class MultipleChoiseCorrectingUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TaskNameL = new System.Windows.Forms.Label();
            this.CorrectTitlePnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CorrectAnsPnl = new System.Windows.Forms.Panel();
            this.ChoosenTitlePnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ChoosenAnsPnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PontTb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.CorrectTitlePnl.SuspendLayout();
            this.ChoosenTitlePnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.TaskNameL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 57);
            this.panel1.TabIndex = 0;
            // 
            // TaskNameL
            // 
            this.TaskNameL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskNameL.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TaskNameL.ForeColor = System.Drawing.Color.White;
            this.TaskNameL.Location = new System.Drawing.Point(0, 0);
            this.TaskNameL.Name = "TaskNameL";
            this.TaskNameL.Size = new System.Drawing.Size(760, 57);
            this.TaskNameL.TabIndex = 0;
            this.TaskNameL.Text = "Choose the right option/options from the following answers!";
            this.TaskNameL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CorrectTitlePnl
            // 
            this.CorrectTitlePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(150)))), ((int)(((byte)(56)))));
            this.CorrectTitlePnl.Controls.Add(this.label1);
            this.CorrectTitlePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.CorrectTitlePnl.Location = new System.Drawing.Point(0, 57);
            this.CorrectTitlePnl.Name = "CorrectTitlePnl";
            this.CorrectTitlePnl.Size = new System.Drawing.Size(760, 20);
            this.CorrectTitlePnl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Helyes válaszok:";
            // 
            // CorrectAnsPnl
            // 
            this.CorrectAnsPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(150)))), ((int)(((byte)(56)))));
            this.CorrectAnsPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.CorrectAnsPnl.Location = new System.Drawing.Point(0, 77);
            this.CorrectAnsPnl.Name = "CorrectAnsPnl";
            this.CorrectAnsPnl.Size = new System.Drawing.Size(760, 5);
            this.CorrectAnsPnl.TabIndex = 4;
            // 
            // ChoosenTitlePnl
            // 
            this.ChoosenTitlePnl.Controls.Add(this.label2);
            this.ChoosenTitlePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChoosenTitlePnl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChoosenTitlePnl.ForeColor = System.Drawing.Color.White;
            this.ChoosenTitlePnl.Location = new System.Drawing.Point(0, 82);
            this.ChoosenTitlePnl.Name = "ChoosenTitlePnl";
            this.ChoosenTitlePnl.Size = new System.Drawing.Size(760, 20);
            this.ChoosenTitlePnl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(760, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Válasz:";
            // 
            // ChoosenAnsPnl
            // 
            this.ChoosenAnsPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChoosenAnsPnl.Location = new System.Drawing.Point(0, 102);
            this.ChoosenAnsPnl.Name = "ChoosenAnsPnl";
            this.ChoosenAnsPnl.Size = new System.Drawing.Size(760, 5);
            this.ChoosenAnsPnl.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PontTb);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 27);
            this.panel2.TabIndex = 7;
            // 
            // PontTb
            // 
            this.PontTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PontTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.PontTb.Location = new System.Drawing.Point(3, 3);
            this.PontTb.Name = "PontTb";
            this.PontTb.Size = new System.Drawing.Size(74, 20);
            this.PontTb.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DIA_Project.Properties.Resources.check_lists;
            this.pictureBox1.Location = new System.Drawing.Point(80, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // MultipleChoiseCorrectingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ChoosenAnsPnl);
            this.Controls.Add(this.ChoosenTitlePnl);
            this.Controls.Add(this.CorrectAnsPnl);
            this.Controls.Add(this.CorrectTitlePnl);
            this.Controls.Add(this.panel1);
            this.Name = "MultipleChoiseCorrectingUC";
            this.Size = new System.Drawing.Size(760, 135);
            this.panel1.ResumeLayout(false);
            this.CorrectTitlePnl.ResumeLayout(false);
            this.ChoosenTitlePnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel CorrectTitlePnl;
        private System.Windows.Forms.Label TaskNameL;
        private System.Windows.Forms.Panel CorrectAnsPnl;
        private System.Windows.Forms.Panel ChoosenTitlePnl;
        private System.Windows.Forms.Panel ChoosenAnsPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PontTb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
