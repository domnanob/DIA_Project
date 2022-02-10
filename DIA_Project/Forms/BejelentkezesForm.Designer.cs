
namespace DIA_Project.Forms
{
    partial class BejelentkezesForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.JelszoTB = new System.Windows.Forms.TextBox();
            this.BejelentkezesBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FelhTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DIA_Project.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(91, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.MinimizeBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 33);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MinimizeBtn.Image = global::DIA_Project.Properties.Resources.minus;
            this.MinimizeBtn.Location = new System.Drawing.Point(275, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(30, 30);
            this.MinimizeBtn.TabIndex = 6;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Image = global::DIA_Project.Properties.Resources.cancel;
            this.ExitBtn.Location = new System.Drawing.Point(311, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DIA_Project.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(29, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(29, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 1);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(29, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 1);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DIA_Project.Properties.Resources.key;
            this.pictureBox3.Location = new System.Drawing.Point(29, 256);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // JelszoTB
            // 
            this.JelszoTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(108)))));
            this.JelszoTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JelszoTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JelszoTB.ForeColor = System.Drawing.Color.White;
            this.JelszoTB.Location = new System.Drawing.Point(67, 265);
            this.JelszoTB.Name = "JelszoTB";
            this.JelszoTB.PasswordChar = '●';
            this.JelszoTB.PlaceholderText = "Jelszó";
            this.JelszoTB.Size = new System.Drawing.Size(246, 23);
            this.JelszoTB.TabIndex = 2;
            this.JelszoTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_Press);
            // 
            // BejelentkezesBtn
            // 
            this.BejelentkezesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.BejelentkezesBtn.FlatAppearance.BorderSize = 0;
            this.BejelentkezesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BejelentkezesBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BejelentkezesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BejelentkezesBtn.Location = new System.Drawing.Point(29, 348);
            this.BejelentkezesBtn.Name = "BejelentkezesBtn";
            this.BejelentkezesBtn.Size = new System.Drawing.Size(284, 47);
            this.BejelentkezesBtn.TabIndex = 3;
            this.BejelentkezesBtn.Text = "Bejelentkezés";
            this.BejelentkezesBtn.UseVisualStyleBackColor = false;
            this.BejelentkezesBtn.Click += new System.EventHandler(this.BejelentkezesBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.button1.Location = new System.Drawing.Point(29, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Regisztráció\r\n";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FelhTB
            // 
            this.FelhTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(65)))), ((int)(((byte)(113)))));
            this.FelhTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FelhTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FelhTB.ForeColor = System.Drawing.Color.White;
            this.FelhTB.Location = new System.Drawing.Point(67, 211);
            this.FelhTB.Name = "FelhTB";
            this.FelhTB.PlaceholderText = "Felhasználónév";
            this.FelhTB.Size = new System.Drawing.Size(246, 23);
            this.FelhTB.TabIndex = 1;
            this.FelhTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_Press);
            // 
            // BejelentkezesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImage = global::DIA_Project.Properties.Resources.WinFormBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(341, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BejelentkezesBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.FelhTB);
            this.Controls.Add(this.JelszoTB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BejelentkezesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BejelentkezesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox JelszoTB;
        private System.Windows.Forms.Button BejelentkezesBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FelhTB;
    }
}

