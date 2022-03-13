
namespace DIA_Project.Forms.UserForms
{
    partial class UserTestWrittingForm
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
            this.HomePnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DNameL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LeadasBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePnl
            // 
            this.HomePnl.BackColor = System.Drawing.Color.Transparent;
            this.HomePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomePnl.Location = new System.Drawing.Point(0, 40);
            this.HomePnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePnl.Name = "HomePnl";
            this.HomePnl.Size = new System.Drawing.Size(665, 8);
            this.HomePnl.TabIndex = 1;
            this.HomePnl.TabStop = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.DNameL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 40);
            this.panel1.TabIndex = 10;
            // 
            // DNameL
            // 
            this.DNameL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DNameL.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DNameL.Location = new System.Drawing.Point(3, 0);
            this.DNameL.Name = "DNameL";
            this.DNameL.Size = new System.Drawing.Size(660, 38);
            this.DNameL.TabIndex = 0;
            this.DNameL.Text = "Dolgozat Neve";
            this.DNameL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.LeadasBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 32);
            this.panel2.TabIndex = 12;
            // 
            // LeadasBtn
            // 
            this.LeadasBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LeadasBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.LeadasBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeadasBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.LeadasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeadasBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LeadasBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.LeadasBtn.Location = new System.Drawing.Point(562, 4);
            this.LeadasBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeadasBtn.Name = "LeadasBtn";
            this.LeadasBtn.Size = new System.Drawing.Size(92, 25);
            this.LeadasBtn.TabIndex = 2;
            this.LeadasBtn.Text = "Leadás";
            this.LeadasBtn.UseVisualStyleBackColor = false;
            this.LeadasBtn.Click += new System.EventHandler(this.LeadasBtn_Click);
            // 
            // UserTestWrittingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImage = global::DIA_Project.Properties.Resources.WinFormBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 435);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HomePnl);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserTestWrittingForm";
            this.Text = "InfoForm";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherTestsForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HomePnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DNameL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LeadasBtn;
    }
}