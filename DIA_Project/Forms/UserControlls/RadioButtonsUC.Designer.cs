namespace DIA_Project.Forms.User_Controlls
{
    partial class RadioButtonsUC
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.AnswerTB = new System.Windows.Forms.TextBox();
            this.CorrectCb = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(88, 13);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // AnswerTB
            // 
            this.AnswerTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.AnswerTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerTB.ForeColor = System.Drawing.Color.White;
            this.AnswerTB.Location = new System.Drawing.Point(116, 11);
            this.AnswerTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.PlaceholderText = "Válasz";
            this.AnswerTB.Size = new System.Drawing.Size(350, 16);
            this.AnswerTB.TabIndex = 1;
            // 
            // CorrectCb
            // 
            this.CorrectCb.AutoSize = true;
            this.CorrectCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CorrectCb.Location = new System.Drawing.Point(480, 13);
            this.CorrectCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CorrectCb.Name = "CorrectCb";
            this.CorrectCb.Size = new System.Drawing.Size(61, 19);
            this.CorrectCb.TabIndex = 2;
            this.CorrectCb.Text = "Helyes";
            this.CorrectCb.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(116, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 1);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DIA_Project.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(564, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RadioButtonsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CorrectCb);
            this.Controls.Add(this.AnswerTB);
            this.Controls.Add(this.radioButton1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RadioButtonsUC";
            this.Size = new System.Drawing.Size(665, 41);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox AnswerTB;
        private System.Windows.Forms.CheckBox CorrectCb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
