
namespace DIA_Project.Forms.UserForms
{
    partial class UserStoreForm
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
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DIA_Project.Properties.Resources.coins;
            this.pictureBox2.Location = new System.Drawing.Point(606, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // PontL
            // 
            this.PontL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PontL.BackColor = System.Drawing.Color.Transparent;
            this.PontL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PontL.Location = new System.Drawing.Point(561, 46);
            this.PontL.Name = "PontL";
            this.PontL.Size = new System.Drawing.Size(44, 15);
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
            this.Panel1.Location = new System.Drawing.Point(30, 91);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.MaximumSize = new System.Drawing.Size(373, 180);
            this.Panel1.MinimumSize = new System.Drawing.Size(188, 90);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(188, 90);
            this.Panel1.TabIndex = 1;
            this.Panel1.TabStop = true;
            this.Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panels_MouseClick);
            this.Panel1.Region = System.Drawing.Region.FromHrgn(DIA_Project.Lib.BorderRadius.CreateRoundRectRgn(0, 0, this.Panel1.Width, this.Panel1.Height, 10, 10));

            // 
            // Info1Pb
            // 
            this.Info1Pb.Cursor = System.Windows.Forms.Cursors.Help;
            this.Info1Pb.Image = global::DIA_Project.Properties.Resources.info__2_B;
            this.Info1Pb.Location = new System.Drawing.Point(10, 10);
            this.Info1Pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Info1Pb.Name = "Info1Pb";
            this.Info1Pb.Size = new System.Drawing.Size(14, 12);
            this.Info1Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Info1Pb.TabIndex = 18;
            this.Info1Pb.TabStop = false;
            this.Info1Pb.MouseEnter += new System.EventHandler(this.InfoPb_Enter);
            // 
            // Panel1Text
            // 
            this.Panel1Text.AutoSize = true;
            this.Panel1Text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel1Text.Location = new System.Drawing.Point(29, 32);
            this.Panel1Text.Name = "Panel1Text";
            this.Panel1Text.Size = new System.Drawing.Size(127, 19);
            this.Panel1Text.TabIndex = 14;
            this.Panel1Text.Text = "Javítási lehetőség";
            this.Panel1Text.Click += new System.EventHandler(this.Labels_Click);
            // 
            // Panel1PriceL
            // 
            this.Panel1PriceL.AutoSize = true;
            this.Panel1PriceL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel1PriceL.Location = new System.Drawing.Point(137, 64);
            this.Panel1PriceL.Name = "Panel1PriceL";
            this.Panel1PriceL.Size = new System.Drawing.Size(21, 15);
            this.Panel1PriceL.TabIndex = 13;
            this.Panel1PriceL.Text = "50";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::DIA_Project.Properties.Resources.coins;
            this.pictureBox3.Location = new System.Drawing.Point(161, 67);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 12);
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
            this.Panel2.Location = new System.Drawing.Point(239, 91);
            this.Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel2.MaximumSize = new System.Drawing.Size(373, 180);
            this.Panel2.MinimumSize = new System.Drawing.Size(188, 90);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(188, 90);
            this.Panel2.TabIndex = 2;
            this.Panel2.TabStop = true;
            this.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panels_MouseClick);
            this.Panel2.Region = System.Drawing.Region.FromHrgn(DIA_Project.Lib.BorderRadius.CreateRoundRectRgn(0, 0, this.Panel2.Width, this.Panel2.Height, 10, 10));

            // 
            // Info2Pb
            // 
            this.Info2Pb.Cursor = System.Windows.Forms.Cursors.Help;
            this.Info2Pb.Image = global::DIA_Project.Properties.Resources.info__2_B;
            this.Info2Pb.Location = new System.Drawing.Point(11, 10);
            this.Info2Pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Info2Pb.Name = "Info2Pb";
            this.Info2Pb.Size = new System.Drawing.Size(14, 12);
            this.Info2Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Info2Pb.TabIndex = 17;
            this.Info2Pb.TabStop = false;
            this.Info2Pb.MouseEnter += new System.EventHandler(this.InfoPb_Enter);
            // 
            // Panel2Text
            // 
            this.Panel2Text.AutoSize = true;
            this.Panel2Text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel2Text.Location = new System.Drawing.Point(13, 32);
            this.Panel2Text.Name = "Panel2Text";
            this.Panel2Text.Size = new System.Drawing.Size(155, 19);
            this.Panel2Text.TabIndex = 16;
            this.Panel2Text.Text = "Házifeladat felmentés";
            this.Panel2Text.Click += new System.EventHandler(this.Labels_Click);
            // 
            // Panel2PriceL
            // 
            this.Panel2PriceL.AutoSize = true;
            this.Panel2PriceL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel2PriceL.Location = new System.Drawing.Point(138, 64);
            this.Panel2PriceL.Name = "Panel2PriceL";
            this.Panel2PriceL.Size = new System.Drawing.Size(21, 15);
            this.Panel2PriceL.TabIndex = 15;
            this.Panel2PriceL.Text = "80";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::DIA_Project.Properties.Resources.coins;
            this.pictureBox4.Location = new System.Drawing.Point(162, 67);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(14, 12);
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
            this.Panel3.Location = new System.Drawing.Point(445, 91);
            this.Panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel3.MaximumSize = new System.Drawing.Size(373, 180);
            this.Panel3.MinimumSize = new System.Drawing.Size(188, 90);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(188, 90);
            this.Panel3.TabIndex = 3;
            this.Panel3.TabStop = true;
            this.Panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panels_MouseClick);
            this.Panel3.Region = System.Drawing.Region.FromHrgn(DIA_Project.Lib.BorderRadius.CreateRoundRectRgn(0, 0, this.Panel3.Width, this.Panel3.Height, 10, 10));

            // 
            // Info3Pb
            // 
            this.Info3Pb.Cursor = System.Windows.Forms.Cursors.Help;
            this.Info3Pb.Image = global::DIA_Project.Properties.Resources.info__2_B;
            this.Info3Pb.Location = new System.Drawing.Point(10, 10);
            this.Info3Pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Info3Pb.Name = "Info3Pb";
            this.Info3Pb.Size = new System.Drawing.Size(14, 12);
            this.Info3Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Info3Pb.TabIndex = 18;
            this.Info3Pb.TabStop = false;
            this.Info3Pb.MouseEnter += new System.EventHandler(this.InfoPb_Enter);
            // 
            // Panel3Text
            // 
            this.Panel3Text.AutoSize = true;
            this.Panel3Text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel3Text.Location = new System.Drawing.Point(41, 32);
            this.Panel3Text.Name = "Panel3Text";
            this.Panel3Text.Size = new System.Drawing.Size(105, 19);
            this.Panel3Text.TabIndex = 18;
            this.Panel3Text.Text = "Késés igazolás";
            this.Panel3Text.Click += new System.EventHandler(this.Labels_Click);
            // 
            // Panel3PriceL
            // 
            this.Panel3PriceL.AutoSize = true;
            this.Panel3PriceL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel3PriceL.Location = new System.Drawing.Point(128, 64);
            this.Panel3PriceL.Name = "Panel3PriceL";
            this.Panel3PriceL.Size = new System.Drawing.Size(28, 15);
            this.Panel3PriceL.TabIndex = 17;
            this.Panel3PriceL.Text = "100";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::DIA_Project.Properties.Resources.coins;
            this.pictureBox5.Location = new System.Drawing.Point(160, 67);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(14, 12);
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
            this.Panel4.Location = new System.Drawing.Point(30, 198);
            this.Panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel4.MaximumSize = new System.Drawing.Size(373, 180);
            this.Panel4.MinimumSize = new System.Drawing.Size(188, 90);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(188, 90);
            this.Panel4.TabIndex = 4;
            this.Panel4.TabStop = true;
            this.Panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panels_MouseClick);
            this.Panel4.Region = System.Drawing.Region.FromHrgn(DIA_Project.Lib.BorderRadius.CreateRoundRectRgn(0, 0, this.Panel4.Width, this.Panel4.Height, 10, 10));

            // 
            // Info4Pb
            // 
            this.Info4Pb.Cursor = System.Windows.Forms.Cursors.Help;
            this.Info4Pb.Image = global::DIA_Project.Properties.Resources.info__2_B;
            this.Info4Pb.Location = new System.Drawing.Point(10, 9);
            this.Info4Pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Info4Pb.Name = "Info4Pb";
            this.Info4Pb.Size = new System.Drawing.Size(14, 12);
            this.Info4Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Info4Pb.TabIndex = 19;
            this.Info4Pb.TabStop = false;
            this.Info4Pb.MouseEnter += new System.EventHandler(this.InfoPb_Enter);
            // 
            // Panel4Text
            // 
            this.Panel4Text.AutoSize = true;
            this.Panel4Text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel4Text.Location = new System.Drawing.Point(35, 34);
            this.Panel4Text.Name = "Panel4Text";
            this.Panel4Text.Size = new System.Drawing.Size(118, 19);
            this.Panel4Text.TabIndex = 18;
            this.Panel4Text.Text = "Jeles érdemjegy";
            this.Panel4Text.Click += new System.EventHandler(this.Labels_Click);
            // 
            // Panel4PriceL
            // 
            this.Panel4PriceL.AutoSize = true;
            this.Panel4PriceL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Panel4PriceL.Location = new System.Drawing.Point(130, 68);
            this.Panel4PriceL.Name = "Panel4PriceL";
            this.Panel4PriceL.Size = new System.Drawing.Size(28, 15);
            this.Panel4PriceL.TabIndex = 17;
            this.Panel4PriceL.Text = "120";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = global::DIA_Project.Properties.Resources.coins;
            this.pictureBox6.Location = new System.Drawing.Point(161, 69);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(14, 12);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // InfoL
            // 
            this.InfoL.BackColor = System.Drawing.Color.Transparent;
            this.InfoL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoL.Location = new System.Drawing.Point(30, 356);
            this.InfoL.Name = "InfoL";
            this.InfoL.Size = new System.Drawing.Size(604, 38);
            this.InfoL.TabIndex = 16;
            this.InfoL.Text = "Info: Ha az egeret az i-betűre viszed, többet tudhatsz meg arról az elemről!";
            // 
            // UserBoltForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImage = global::DIA_Project.Properties.Resources.WinFormBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 435);
            this.Controls.Add(this.InfoL);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.PontL);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserBoltForm";
            this.Text = "BoltForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoltForm_FormClosed);
            this.Load += new System.EventHandler(this.UserBoltForm_Load);
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