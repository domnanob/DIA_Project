
namespace DIA_Project.Forms.AdminForms
{
    partial class AdminHomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NavP = new System.Windows.Forms.Panel();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.NavArrowP = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.TeachersBtn = new System.Windows.Forms.Button();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DesktopP = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.NavP.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DesktopP.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavP
            // 
            this.NavP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.NavP.Controls.Add(this.InfoBtn);
            this.NavP.Controls.Add(this.NavArrowP);
            this.NavP.Controls.Add(this.LogoutBtn);
            this.NavP.Controls.Add(this.TeachersBtn);
            this.NavP.Controls.Add(this.UsersBtn);
            this.NavP.Controls.Add(this.HomeBtn);
            this.NavP.Controls.Add(this.panel2);
            this.NavP.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavP.Location = new System.Drawing.Point(0, 0);
            this.NavP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NavP.Name = "NavP";
            this.NavP.Size = new System.Drawing.Size(166, 435);
            this.NavP.TabIndex = 0;
            // 
            // InfoBtn
            // 
            this.InfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoBtn.FlatAppearance.BorderSize = 0;
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.InfoBtn.Image = global::DIA_Project.Properties.Resources.info;
            this.InfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoBtn.Location = new System.Drawing.Point(0, 228);
            this.InfoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.InfoBtn.Size = new System.Drawing.Size(166, 40);
            this.InfoBtn.TabIndex = 7;
            this.InfoBtn.Text = "Info";
            this.InfoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.NavButtons_Click);
            // 
            // NavArrowP
            // 
            this.NavArrowP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.NavArrowP.Location = new System.Drawing.Point(0, 146);
            this.NavArrowP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NavArrowP.Name = "NavArrowP";
            this.NavArrowP.Size = new System.Drawing.Size(3, 75);
            this.NavArrowP.TabIndex = 6;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.LogoutBtn.Image = global::DIA_Project.Properties.Resources.logout;
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 395);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.LogoutBtn.Size = new System.Drawing.Size(166, 40);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "Kijelentkezés";
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // TeachersBtn
            // 
            this.TeachersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeachersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TeachersBtn.FlatAppearance.BorderSize = 0;
            this.TeachersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeachersBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeachersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.TeachersBtn.Image = global::DIA_Project.Properties.Resources.user;
            this.TeachersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TeachersBtn.Location = new System.Drawing.Point(0, 188);
            this.TeachersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeachersBtn.Name = "TeachersBtn";
            this.TeachersBtn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TeachersBtn.Size = new System.Drawing.Size(166, 40);
            this.TeachersBtn.TabIndex = 3;
            this.TeachersBtn.Text = "Tanárok";
            this.TeachersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TeachersBtn.UseVisualStyleBackColor = true;
            this.TeachersBtn.Click += new System.EventHandler(this.NavButtons_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersBtn.FlatAppearance.BorderSize = 0;
            this.UsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.UsersBtn.Image = global::DIA_Project.Properties.Resources.tests;
            this.UsersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsersBtn.Location = new System.Drawing.Point(0, 148);
            this.UsersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.UsersBtn.Size = new System.Drawing.Size(166, 40);
            this.UsersBtn.TabIndex = 2;
            this.UsersBtn.Text = "Diákok";
            this.UsersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.UsersBtn.UseVisualStyleBackColor = true;
            this.UsersBtn.Click += new System.EventHandler(this.NavButtons_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.HomeBtn.Image = global::DIA_Project.Properties.Resources.home;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeBtn.Location = new System.Drawing.Point(0, 108);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.HomeBtn.Size = new System.Drawing.Size(166, 40);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.NavButtons_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 108);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::DIA_Project.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(24, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DIA_Project.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(24, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DIA_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(24, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DesktopP
            // 
            this.DesktopP.AutoScroll = true;
            this.DesktopP.BackgroundImage = global::DIA_Project.Properties.Resources.WinFormBg2D;
            this.DesktopP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DesktopP.Controls.Add(this.panel3);
            this.DesktopP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopP.Location = new System.Drawing.Point(166, 0);
            this.DesktopP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DesktopP.Name = "DesktopP";
            this.DesktopP.Size = new System.Drawing.Size(665, 435);
            this.DesktopP.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.ExitBtn);
            this.panel3.Controls.Add(this.MinimizeBtn);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 26);
            this.panel3.TabIndex = 0;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Image = global::DIA_Project.Properties.Resources.cancel;
            this.ExitBtn.Location = new System.Drawing.Point(639, 1);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(26, 22);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MinimizeBtn.Image = global::DIA_Project.Properties.Resources.minus;
            this.MinimizeBtn.Location = new System.Drawing.Point(607, 1);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(26, 22);
            this.MinimizeBtn.TabIndex = 10;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(831, 435);
            this.Controls.Add(this.DesktopP);
            this.Controls.Add(this.NavP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.NavP.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DesktopP.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavP;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button TeachersBtn;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel NavArrowP;
        private System.Windows.Forms.Panel DesktopP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button InfoBtn;
    }
}

