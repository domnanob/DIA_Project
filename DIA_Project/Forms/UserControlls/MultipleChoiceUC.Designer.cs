namespace DIA_Project.Forms.User_Controlls
{
    partial class MultipleChoiceUC
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PointsTb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HozzaadasBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskNameTb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonsuc1 = new DIA_Project.Forms.User_Controlls.RadioButtonsUC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.PointsTb);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.HozzaadasBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TaskNameTb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 43);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(462, 30);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(64, 1);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DIA_Project.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(637, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PointsTb
            // 
            this.PointsTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PointsTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PointsTb.ForeColor = System.Drawing.Color.White;
            this.PointsTb.Location = new System.Drawing.Point(462, 14);
            this.PointsTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PointsTb.Name = "PointsTb";
            this.PointsTb.PlaceholderText = "Pont";
            this.PointsTb.Size = new System.Drawing.Size(64, 16);
            this.PointsTb.TabIndex = 2;
            this.PointsTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PointsTb_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(60, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 1);
            this.panel3.TabIndex = 4;
            // 
            // HozzaadasBtn
            // 
            this.HozzaadasBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HozzaadasBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HozzaadasBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.HozzaadasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HozzaadasBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HozzaadasBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.HozzaadasBtn.Location = new System.Drawing.Point(551, 10);
            this.HozzaadasBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HozzaadasBtn.Name = "HozzaadasBtn";
            this.HozzaadasBtn.Size = new System.Drawing.Size(80, 22);
            this.HozzaadasBtn.TabIndex = 4;
            this.HozzaadasBtn.Text = "Hozzáadás";
            this.HozzaadasBtn.UseVisualStyleBackColor = true;
            this.HozzaadasBtn.Click += new System.EventHandler(this.HozzaadasBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kérdés:";
            // 
            // TaskNameTb
            // 
            this.TaskNameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TaskNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskNameTb.ForeColor = System.Drawing.Color.White;
            this.TaskNameTb.Location = new System.Drawing.Point(60, 14);
            this.TaskNameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskNameTb.Name = "TaskNameTb";
            this.TaskNameTb.PlaceholderText = "A feladat kérdése";
            this.TaskNameTb.Size = new System.Drawing.Size(380, 16);
            this.TaskNameTb.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonsuc1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 46);
            this.panel2.TabIndex = 3;
            // 
            // radioButtonsuc1
            // 
            this.radioButtonsuc1.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonsuc1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonsuc1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.radioButtonsuc1.Location = new System.Drawing.Point(0, 0);
            this.radioButtonsuc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonsuc1.Name = "radioButtonsuc1";
            this.radioButtonsuc1.Size = new System.Drawing.Size(665, 41);
            this.radioButtonsuc1.TabIndex = 3;
            this.radioButtonsuc1.BackColorChanged += new System.EventHandler(this.radioButtonsuc_BackColorChanged);
            // 
            // MultipleChoiseUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MultipleChoiseUC";
            this.Size = new System.Drawing.Size(665, 89);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TaskNameTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HozzaadasBtn;
        private RadioButtonsUC radioButtonsuc1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox PointsTb;
    }
}
