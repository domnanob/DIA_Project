
namespace DIA_Project.Forms.UserForms
{
    partial class UserBoltForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PontL = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Info1Pb = new System.Windows.Forms.PictureBox();
            this.Panel1Text = new System.Windows.Forms.Label();
            this.Panel1PriceL = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Info2Pb = new System.Windows.Forms.PictureBox();
            this.Panel2Text = new System.Windows.Forms.Label();
            this.Panel2PriceL = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Info3Pb = new System.Windows.Forms.PictureBox();
            this.Panel3Text = new System.Windows.Forms.Label();
            this.Panel3PriceL = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Info4Pb = new System.Windows.Forms.PictureBox();
            this.Panel4Text = new System.Windows.Forms.Label();
            this.Panel4PriceL = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.InfoL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info1Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info2Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info3Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info4Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DIA_Project.Properties.Resources.repair_tool;
            this.pictureBox1.Location = new System.Drawing.Point(684, 504);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DIA_Project.Properties.Resources.coins;
            this.pictureBox2.Location = new System.Drawing.Point(692, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // PontL
            // 
            this.PontL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PontL.BackColor = System.Drawing.Color.Transparent;
            this.PontL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PontL.Location = new System.Drawing.Point(641, 62);
            this.PontL.Name = "PontL";
            this.PontL.Size = new System.Drawing.Size(50, 20);
            this.PontL.TabIndex = 12;
            this.PontL.Text = "Pont";
            this.PontL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.Panel1.Controls.Add(this.Info1Pb);
            this.Panel1.Controls.Add(this.Panel1Text);
            this.Panel1.Controls.Add(this.Panel1PriceL);
            this.Panel1.Controls.Add(this.pictureBox3);
            this.Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel1.Location = new System.Drawing.Point(34, 121);
            this.Panel1.MaximumSize = new System.Drawing.Size(426, 240);
            this.Panel1.MinimumSize = new System.Drawing.Size(215, 120);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(215, 120);
            this.Panel1.TabIndex = 13;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panels_Paint);
            this.Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panels_MouseClick);
            // 
            // Info1Pb
            // 
            this.Info1Pb.Image = global::DIA_Project.Properties.Resources.info__2_B;
            this.Info1Pb.Location = new System.Drawing.Point(12, 13);
            this.Info1Pb.Name = "Info1Pb";
            this.Info1Pb.Size = new System.Drawing.Size(16, 16);
            this.Info1Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Info1Pb.TabIndex = 18;
            this.Info1Pb.TabStop = false;
            this.Info1Pb.MouseEnter += new System.EventHandler(this.InfoPb_Enter);
            // 
            // Panel1Text
            // 
            this.Panel1Text.AutoSize = true;
            this.Panel1Text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel1Text.Location = new System.Drawing.Point(33, 43);
            this.Panel1Text.Name = "Panel1Text";
            this.Panel1Text.Size = new System.Drawing.Size(151, 23);
            this.Panel1Text.TabIndex = 14;
            this.Panel1Text.Text = "Javítási lehetőség";
            this.Panel1Text.Click += new System.EventHandler(this.Labels_Click);
            // 
            // Panel1PriceL
            // 
            this.Panel1PriceL.AutoSize = true;
            this.Panel1PriceL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel1PriceL.Location = new System.Drawing.Point(157, 86);
            this.Panel1PriceL.Name = "Panel1PriceL";
            this.Panel1PriceL.Size = new System.Drawing.Size(27, 20);
            this.Panel1PriceL.TabIndex = 13;
            this.Panel1PriceL.Text = "50";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::DIA_Project.Properties.Resources.coins;
            this.pictureBox3.Location = new System.Drawing.Point(184, 89);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.Panel2.Controls.Add(this.Info2Pb);
            this.Panel2.Controls.Add(this.Panel2Text);
            this.Panel2.Controls.Add(this.Panel2PriceL);
            this.Panel2.Controls.Add(this.pictureBox4);
            this.Panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel2.Location = new System.Drawing.Point(273, 121);
            this.Panel2.MaximumSize = new System.Drawing.Size(426, 240);
            this.Panel2.MinimumSize = new System.Drawing.Size(215, 120);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(215, 120);
            this.Panel2.TabIndex = 14;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panels_Paint);
            this.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panels_MouseClick);
            // 
            // Info2Pb
            // 
            this.Info2Pb.Image = global::DIA_Project.Properties.Resources.info__2_B;
            this.Info2Pb.Location = new System.Drawing.Point(13, 13);
            this.Info2Pb.Name = "Info2Pb";
            this.Info2Pb.Size = new System.Drawing.Size(16, 16);
            this.Info2Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Info2Pb.TabIndex = 17;
            this.Info2Pb.TabStop = false;
            this.Info2Pb.MouseEnter += new System.EventHandler(this.InfoPb_Enter);
            // 
            // Panel2Text
            // 
            this.Panel2Text.AutoSize = true;
            this.Panel2Text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel2Text.Location = new System.Drawing.Point(15, 43);
            this.Panel2Text.Name = "Panel2Text";
            this.Panel2Text.Size = new System.Drawing.Size(186, 23);
            this.Panel2Text.TabIndex = 16;
            this.Panel2Text.Text = "Házifeladat felmentés";
            this.Panel2Text.Click += new System.EventHandler(this.Labels_Click);
            // 
            // Panel2PriceL
            // 
            this.Panel2PriceL.AutoSize = true;
            this.Panel2PriceL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel2PriceL.Location = new System.Drawing.Point(158, 86);
            this.Panel2PriceL.Name = "Panel2PriceL";
            this.Panel2PriceL.Size = new System.Drawing.Size(27, 20);
            this.Panel2PriceL.TabIndex = 15;
            this.Panel2PriceL.Text = "80";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::DIA_Project.Properties.Resources.coins;
            this.pictureBox4.Location = new System.Drawing.Point(185, 89);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.Panel3.Controls.Add(this.Info3Pb);
            this.Panel3.Controls.Add(this.Panel3Text);
            this.Panel3.Controls.Add(this.Panel3PriceL);
            this.Panel3.Controls.Add(this.pictureBox5);
            this.Panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel3.Location = new System.Drawing.Point(509, 121);
            this.Panel3.MaximumSize = new System.Drawing.Size(426, 240);
            this.Panel3.MinimumSize = new System.Drawing.Size(215, 120);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(215, 120);
            this.Panel3.TabIndex = 14;
            this.Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panels_Paint);
            this.Panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panels_MouseClick);
            // 
            // Info3Pb
            // 
            this.Info3Pb.Image = global::DIA_Project.Properties.Resources.info__2_B;
            this.Info3Pb.Location = new System.Drawing.Point(12, 13);
            this.Info3Pb.Name = "Info3Pb";
            this.Info3Pb.Size = new System.Drawing.Size(16, 16);
            this.Info3Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Info3Pb.TabIndex = 18;
            this.Info3Pb.TabStop = false;
            this.Info3Pb.MouseEnter += new System.EventHandler(this.InfoPb_Enter);
            // 
            // Panel3Text
            // 
            this.Panel3Text.AutoSize = true;
            this.Panel3Text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel3Text.Location = new System.Drawing.Point(47, 43);
            this.Panel3Text.Name = "Panel3Text";
            this.Panel3Text.Size = new System.Drawing.Size(122, 23);
            this.Panel3Text.TabIndex = 18;
            this.Panel3Text.Text = "Késés igazolás";
            this.Panel3Text.Click += new System.EventHandler(this.Labels_Click);
            // 
            // Panel3PriceL
            // 
            this.Panel3PriceL.AutoSize = true;
            this.Panel3PriceL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel3PriceL.Location = new System.Drawing.Point(146, 85);
            this.Panel3PriceL.Name = "Panel3PriceL";
            this.Panel3PriceL.Size = new System.Drawing.Size(36, 20);
            this.Panel3PriceL.TabIndex = 17;
            this.Panel3PriceL.Text = "100";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::DIA_Project.Properties.Resources.coins;
            this.pictureBox5.Location = new System.Drawing.Point(183, 89);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 16);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.Panel4.Controls.Add(this.Info4Pb);
            this.Panel4.Controls.Add(this.Panel4Text);
            this.Panel4.Controls.Add(this.Panel4PriceL);
            this.Panel4.Controls.Add(this.pictureBox6);
            this.Panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel4.Location = new System.Drawing.Point(34, 264);
            this.Panel4.MaximumSize = new System.Drawing.Size(426, 240);
            this.Panel4.MinimumSize = new System.Drawing.Size(215, 120);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(215, 120);
            this.Panel4.TabIndex = 15;
            this.Panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panels_Paint);
            this.Panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panels_MouseClick);
            // 
            // Info4Pb
            // 
            this.Info4Pb.Image = global::DIA_Project.Properties.Resources.info__2_B;
            this.Info4Pb.Location = new System.Drawing.Point(12, 12);
            this.Info4Pb.Name = "Info4Pb";
            this.Info4Pb.Size = new System.Drawing.Size(16, 16);
            this.Info4Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Info4Pb.TabIndex = 19;
            this.Info4Pb.TabStop = false;
            this.Info4Pb.MouseEnter += new System.EventHandler(this.InfoPb_Enter);
            // 
            // Panel4Text
            // 
            this.Panel4Text.AutoSize = true;
            this.Panel4Text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel4Text.Location = new System.Drawing.Point(40, 46);
            this.Panel4Text.Name = "Panel4Text";
            this.Panel4Text.Size = new System.Drawing.Size(139, 23);
            this.Panel4Text.TabIndex = 18;
            this.Panel4Text.Text = "Jeles érdemjegy";
            this.Panel4Text.Click += new System.EventHandler(this.Labels_Click);
            // 
            // Panel4PriceL
            // 
            this.Panel4PriceL.AutoSize = true;
            this.Panel4PriceL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel4PriceL.Location = new System.Drawing.Point(148, 90);
            this.Panel4PriceL.Name = "Panel4PriceL";
            this.Panel4PriceL.Size = new System.Drawing.Size(36, 20);
            this.Panel4PriceL.TabIndex = 17;
            this.Panel4PriceL.Text = "120";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = global::DIA_Project.Properties.Resources.coins;
            this.pictureBox6.Location = new System.Drawing.Point(184, 92);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(16, 16);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // InfoL
            // 
            this.InfoL.BackColor = System.Drawing.Color.Transparent;
            this.InfoL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoL.Location = new System.Drawing.Point(34, 437);
            this.InfoL.Name = "InfoL";
            this.InfoL.Size = new System.Drawing.Size(690, 51);
            this.InfoL.TabIndex = 16;
            this.InfoL.Text = "Info: Az i-betüre kattintva tudhatsz meg többet az egyes lehetőségekről!";
            // 
            // UserBoltForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImage = global::DIA_Project.Properties.Resources.WinFormBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 580);
            this.Controls.Add(this.InfoL);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.PontL);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserBoltForm";
            this.Text = "BoltForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoltForm_FormClosed);
            this.Load += new System.EventHandler(this.UserBoltForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info1Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info2Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info3Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info4Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label PontL;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Panel1PriceL;
        private System.Windows.Forms.Label Panel2PriceL;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Panel3PriceL;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label Panel4PriceL;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Panel1Text;
        private System.Windows.Forms.Label Panel2Text;
        private System.Windows.Forms.Label Panel3Text;
        private System.Windows.Forms.Label Panel4Text;
        private System.Windows.Forms.PictureBox Info2Pb;
        private System.Windows.Forms.PictureBox Info3Pb;
        private System.Windows.Forms.PictureBox Info4Pb;
        private System.Windows.Forms.PictureBox Info1Pb;
        private System.Windows.Forms.Label InfoL;
    }
}