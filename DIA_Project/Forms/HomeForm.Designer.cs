
namespace DIA_Project.Forms
{
    partial class HomeForm
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
            this.NavArrowP = new System.Windows.Forms.Panel();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.BoltBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ProfilBtn = new System.Windows.Forms.Button();
            this.DolgozatokBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MaximizeBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DesktopP = new System.Windows.Forms.Panel();
            this.NavP.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavP
            // 
            this.NavP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.NavP.Controls.Add(this.NavArrowP);
            this.NavP.Controls.Add(this.InfoBtn);
            this.NavP.Controls.Add(this.BoltBtn);
            this.NavP.Controls.Add(this.LogoutBtn);
            this.NavP.Controls.Add(this.ProfilBtn);
            this.NavP.Controls.Add(this.DolgozatokBtn);
            this.NavP.Controls.Add(this.HomeBtn);
            this.NavP.Controls.Add(this.panel2);
            this.NavP.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavP.Location = new System.Drawing.Point(0, 0);
            this.NavP.Name = "NavP";
            this.NavP.Size = new System.Drawing.Size(190, 580);
            this.NavP.TabIndex = 0;
            // 
            // NavArrowP
            // 
            this.NavArrowP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.NavArrowP.Location = new System.Drawing.Point(0, 195);
            this.NavArrowP.Name = "NavArrowP";
            this.NavArrowP.Size = new System.Drawing.Size(3, 100);
            this.NavArrowP.TabIndex = 6;
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
            this.InfoBtn.Location = new System.Drawing.Point(0, 324);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.InfoBtn.Size = new System.Drawing.Size(190, 45);
            this.InfoBtn.TabIndex = 5;
            this.InfoBtn.Text = "Info";
            this.InfoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.NavButtons_Click);
            // 
            // BoltBtn
            // 
            this.BoltBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoltBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoltBtn.FlatAppearance.BorderSize = 0;
            this.BoltBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoltBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoltBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.BoltBtn.Image = global::DIA_Project.Properties.Resources.cart;
            this.BoltBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BoltBtn.Location = new System.Drawing.Point(0, 279);
            this.BoltBtn.Name = "BoltBtn";
            this.BoltBtn.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.BoltBtn.Size = new System.Drawing.Size(190, 45);
            this.BoltBtn.TabIndex = 4;
            this.BoltBtn.Text = "Bolt";
            this.BoltBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BoltBtn.UseVisualStyleBackColor = true;
            this.BoltBtn.Click += new System.EventHandler(this.NavButtons_Click);
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
            this.LogoutBtn.Location = new System.Drawing.Point(0, 535);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.LogoutBtn.Size = new System.Drawing.Size(190, 45);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "Kijelentkezés";
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ProfilBtn
            // 
            this.ProfilBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfilBtn.FlatAppearance.BorderSize = 0;
            this.ProfilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfilBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProfilBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.ProfilBtn.Image = global::DIA_Project.Properties.Resources.user;
            this.ProfilBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProfilBtn.Location = new System.Drawing.Point(0, 234);
            this.ProfilBtn.Name = "ProfilBtn";
            this.ProfilBtn.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.ProfilBtn.Size = new System.Drawing.Size(190, 45);
            this.ProfilBtn.TabIndex = 3;
            this.ProfilBtn.Text = "Profil";
            this.ProfilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ProfilBtn.UseVisualStyleBackColor = true;
            this.ProfilBtn.Click += new System.EventHandler(this.NavButtons_Click);
            // 
            // DolgozatokBtn
            // 
            this.DolgozatokBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DolgozatokBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DolgozatokBtn.FlatAppearance.BorderSize = 0;
            this.DolgozatokBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DolgozatokBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DolgozatokBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.DolgozatokBtn.Image = global::DIA_Project.Properties.Resources.tests;
            this.DolgozatokBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DolgozatokBtn.Location = new System.Drawing.Point(0, 189);
            this.DolgozatokBtn.Name = "DolgozatokBtn";
            this.DolgozatokBtn.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.DolgozatokBtn.Size = new System.Drawing.Size(190, 45);
            this.DolgozatokBtn.TabIndex = 2;
            this.DolgozatokBtn.Text = "Dolgozatok";
            this.DolgozatokBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DolgozatokBtn.UseVisualStyleBackColor = true;
            this.DolgozatokBtn.Click += new System.EventHandler(this.NavButtons_Click);
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
            this.HomeBtn.Location = new System.Drawing.Point(0, 144);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.HomeBtn.Size = new System.Drawing.Size(190, 45);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 144);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::DIA_Project.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(27, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 104);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DIA_Project.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(27, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DIA_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Image = global::DIA_Project.Properties.Resources.cancel;
            this.ExitBtn.Location = new System.Drawing.Point(730, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBtn.FlatAppearance.BorderSize = 0;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.Image = global::DIA_Project.Properties.Resources.maximize;
            this.MaximizeBtn.Location = new System.Drawing.Point(694, 0);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(30, 30);
            this.MaximizeBtn.TabIndex = 2;
            this.MaximizeBtn.UseVisualStyleBackColor = true;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MinimizeBtn.Image = global::DIA_Project.Properties.Resources.minus;
            this.MinimizeBtn.Location = new System.Drawing.Point(658, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(30, 30);
            this.MinimizeBtn.TabIndex = 3;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ExitBtn);
            this.panel3.Controls.Add(this.MinimizeBtn);
            this.panel3.Controls.Add(this.MaximizeBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(190, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 32);
            this.panel3.TabIndex = 4;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // DesktopP
            // 
            this.DesktopP.AutoScroll = true;
            this.DesktopP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopP.Location = new System.Drawing.Point(190, 32);
            this.DesktopP.Name = "DesktopP";
            this.DesktopP.Size = new System.Drawing.Size(760, 548);
            this.DesktopP.TabIndex = 5;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(950, 580);
            this.Controls.Add(this.DesktopP);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.NavP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.NavP.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavP;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ProfilBtn;
        private System.Windows.Forms.Button DolgozatokBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MaximizeBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button BoltBtn;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel NavArrowP;
        private System.Windows.Forms.Panel DesktopP;
    }
}

