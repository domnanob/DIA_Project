
namespace DIA_Project.Forms.TeacherForms
{
    partial class TeacherTestWatchingForm
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
            this.HomePnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserNameTb = new System.Windows.Forms.Label();
            this.DNameL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MentesBtn = new System.Windows.Forms.Button();
            this.VisszaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DIA_Project.Properties.Resources.repair_tool;
            this.pictureBox1.Location = new System.Drawing.Point(690, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // HomePnl
            // 
            this.HomePnl.BackColor = System.Drawing.Color.Transparent;
            this.HomePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomePnl.Location = new System.Drawing.Point(0, 54);
            this.HomePnl.Name = "HomePnl";
            this.HomePnl.Size = new System.Drawing.Size(760, 10);
            this.HomePnl.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.UserNameTb);
            this.panel1.Controls.Add(this.DNameL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 54);
            this.panel1.TabIndex = 10;
            // 
            // UserNameTb
            // 
            this.UserNameTb.Location = new System.Drawing.Point(0, 38);
            this.UserNameTb.Name = "UserNameTb";
            this.UserNameTb.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.UserNameTb.Size = new System.Drawing.Size(760, 18);
            this.UserNameTb.TabIndex = 1;
            this.UserNameTb.Text = "User Name";
            this.UserNameTb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DNameL
            // 
            this.DNameL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DNameL.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DNameL.Location = new System.Drawing.Point(3, 0);
            this.DNameL.Name = "DNameL";
            this.DNameL.Size = new System.Drawing.Size(754, 51);
            this.DNameL.TabIndex = 0;
            this.DNameL.Text = "Dolgozat Neve";
            this.DNameL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.VisszaBtn);
            this.panel2.Controls.Add(this.MentesBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 43);
            this.panel2.TabIndex = 12;
            // 
            // MentesBtn
            // 
            this.MentesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.MentesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.MentesBtn.FlatAppearance.BorderSize = 2;
            this.MentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MentesBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MentesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.MentesBtn.Location = new System.Drawing.Point(579, 3);
            this.MentesBtn.Name = "MentesBtn";
            this.MentesBtn.Size = new System.Drawing.Size(105, 36);
            this.MentesBtn.TabIndex = 10;
            this.MentesBtn.Text = "Mentés";
            this.MentesBtn.UseVisualStyleBackColor = false;
            this.MentesBtn.Click += new System.EventHandler(this.MentesBtn_Click);
            // 
            // VisszaBtn
            // 
            this.VisszaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.VisszaBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.VisszaBtn.FlatAppearance.BorderSize = 2;
            this.VisszaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisszaBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VisszaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.VisszaBtn.Location = new System.Drawing.Point(468, 3);
            this.VisszaBtn.Name = "VisszaBtn";
            this.VisszaBtn.Size = new System.Drawing.Size(105, 37);
            this.VisszaBtn.TabIndex = 32;
            this.VisszaBtn.Text = "Vissza";
            this.VisszaBtn.UseVisualStyleBackColor = false;
            this.VisszaBtn.Click += new System.EventHandler(this.VisszaBtn_Click);
            // 
            // TeacherTestWatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImage = global::DIA_Project.Properties.Resources.WinFormBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HomePnl);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherTestWatchingForm";
            this.Text = "InfoForm";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherTestsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel HomePnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DNameL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MentesBtn;
        private System.Windows.Forms.Label UserNameTb;
        private System.Windows.Forms.Button VisszaBtn;
    }
}