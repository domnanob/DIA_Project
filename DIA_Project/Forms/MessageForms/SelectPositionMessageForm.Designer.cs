
namespace DIA_Project.Forms
{
    partial class SelectPositionMessageForm
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
            this.KerdesL = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.ClassesCB = new System.Windows.Forms.ComboBox();
            this.SubjectCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DIA_Project.Properties.Resources.warning;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // KerdesL
            // 
            this.KerdesL.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KerdesL.ForeColor = System.Drawing.Color.White;
            this.KerdesL.Location = new System.Drawing.Point(92, 22);
            this.KerdesL.Name = "KerdesL";
            this.KerdesL.Size = new System.Drawing.Size(356, 27);
            this.KerdesL.TabIndex = 1;
            this.KerdesL.Text = "Válassz osztályt és a tantárgyat!";
            this.KerdesL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.CancelBtn.FlatAppearance.BorderSize = 2;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.CancelBtn.Location = new System.Drawing.Point(258, 107);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(92, 29);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Mégse";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.OKBtn.FlatAppearance.BorderSize = 0;
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OKBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.OKBtn.Location = new System.Drawing.Point(356, 107);
            this.OKBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(92, 29);
            this.OKBtn.TabIndex = 12;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // ClassesCB
            // 
            this.ClassesCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClassesCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassesCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassesCB.ForeColor = System.Drawing.Color.White;
            this.ClassesCB.FormattingEnabled = true;
            this.ClassesCB.Items.AddRange(new object[] {
            "Osztály"});
            this.ClassesCB.Location = new System.Drawing.Point(92, 60);
            this.ClassesCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesCB.Name = "ClassesCB";
            this.ClassesCB.Size = new System.Drawing.Size(139, 23);
            this.ClassesCB.TabIndex = 13;
            // 
            // SubjectCb
            // 
            this.SubjectCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.SubjectCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubjectCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectCb.ForeColor = System.Drawing.Color.White;
            this.SubjectCb.FormattingEnabled = true;
            this.SubjectCb.Items.AddRange(new object[] {
            "Tantárgy"});
            this.SubjectCb.Location = new System.Drawing.Point(237, 60);
            this.SubjectCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectCb.Name = "SubjectCb";
            this.SubjectCb.Size = new System.Drawing.Size(139, 23);
            this.SubjectCb.TabIndex = 14;
            // 
            // SelectPositionMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(471, 157);
            this.Controls.Add(this.SubjectCb);
            this.Controls.Add(this.ClassesCB);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.KerdesL);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectPositionMessageForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label KerdesL;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.ComboBox ClassesCB;
        private System.Windows.Forms.ComboBox SubjectCb;
    }
}