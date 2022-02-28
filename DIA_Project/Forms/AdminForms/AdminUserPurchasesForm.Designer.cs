
namespace DIA_Project.Forms.AdminForms
{
    partial class AdminUserPurchasesForm
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
            this.VisszaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.JelesECb = new System.Windows.Forms.ComboBox();
            this.KesesICb = new System.Windows.Forms.ComboBox();
            this.HaziFCb = new System.Windows.Forms.ComboBox();
            this.JavLCb = new System.Windows.Forms.ComboBox();
            this.MentesBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisszaBtn
            // 
            this.VisszaBtn.BackColor = System.Drawing.Color.Transparent;
            this.VisszaBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.VisszaBtn.FlatAppearance.BorderSize = 2;
            this.VisszaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisszaBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VisszaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.VisszaBtn.Location = new System.Drawing.Point(422, 77);
            this.VisszaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisszaBtn.Name = "VisszaBtn";
            this.VisszaBtn.Size = new System.Drawing.Size(92, 28);
            this.VisszaBtn.TabIndex = 2;
            this.VisszaBtn.Text = "Vissza";
            this.VisszaBtn.UseVisualStyleBackColor = false;
            this.VisszaBtn.Click += new System.EventHandler(this.VisszaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Javítási lehetőség:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Házifeladat felmentés:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Késés igazolás:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jeles érdemjegy:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.JelesECb);
            this.panel1.Controls.Add(this.KesesICb);
            this.panel1.Controls.Add(this.HaziFCb);
            this.panel1.Controls.Add(this.JavLCb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(52, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 266);
            this.panel1.TabIndex = 12;
            // 
            // JelesECb
            // 
            this.JelesECb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JelesECb.FormattingEnabled = true;
            this.JelesECb.Items.AddRange(new object[] {
            "Nincs!",
            "Vam!"});
            this.JelesECb.Location = new System.Drawing.Point(344, 161);
            this.JelesECb.Name = "JelesECb";
            this.JelesECb.Size = new System.Drawing.Size(121, 23);
            this.JelesECb.TabIndex = 8;
            // 
            // KesesICb
            // 
            this.KesesICb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KesesICb.FormattingEnabled = true;
            this.KesesICb.Items.AddRange(new object[] {
            "Nincs!",
            "Van!"});
            this.KesesICb.Location = new System.Drawing.Point(344, 124);
            this.KesesICb.Name = "KesesICb";
            this.KesesICb.Size = new System.Drawing.Size(121, 23);
            this.KesesICb.TabIndex = 8;
            // 
            // HaziFCb
            // 
            this.HaziFCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HaziFCb.FormattingEnabled = true;
            this.HaziFCb.Items.AddRange(new object[] {
            "Nincs!",
            "Van!"});
            this.HaziFCb.Location = new System.Drawing.Point(344, 86);
            this.HaziFCb.Name = "HaziFCb";
            this.HaziFCb.Size = new System.Drawing.Size(121, 23);
            this.HaziFCb.TabIndex = 8;
            // 
            // JavLCb
            // 
            this.JavLCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JavLCb.FormattingEnabled = true;
            this.JavLCb.Items.AddRange(new object[] {
            "Nincs!",
            "Van!"});
            this.JavLCb.Location = new System.Drawing.Point(344, 48);
            this.JavLCb.Name = "JavLCb";
            this.JavLCb.Size = new System.Drawing.Size(121, 23);
            this.JavLCb.TabIndex = 8;
            // 
            // MentesBtn
            // 
            this.MentesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.MentesBtn.FlatAppearance.BorderSize = 0;
            this.MentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MentesBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MentesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.MentesBtn.Location = new System.Drawing.Point(520, 77);
            this.MentesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MentesBtn.Name = "MentesBtn";
            this.MentesBtn.Size = new System.Drawing.Size(92, 29);
            this.MentesBtn.TabIndex = 13;
            this.MentesBtn.Text = "Mentés";
            this.MentesBtn.UseVisualStyleBackColor = false;
            this.MentesBtn.Click += new System.EventHandler(this.MentesBtn_Click);
            // 
            // AdminUserPurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImage = global::DIA_Project.Properties.Resources.WinFormBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 435);
            this.Controls.Add(this.MentesBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VisszaBtn);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminUserPurchasesForm";
            this.Text = "InfoForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherTestsUsersForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button VisszaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox JelesECb;
        private System.Windows.Forms.ComboBox KesesICb;
        private System.Windows.Forms.ComboBox HaziFCb;
        private System.Windows.Forms.ComboBox JavLCb;
        private System.Windows.Forms.Button MentesBtn;
    }
}