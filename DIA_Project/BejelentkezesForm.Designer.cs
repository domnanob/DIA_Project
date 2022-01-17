
namespace DIA_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.FelhTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.JelszoTB = new System.Windows.Forms.TextBox();
            this.BejelentkezesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév:";
            // 
            // FelhTB
            // 
            this.FelhTB.Location = new System.Drawing.Point(161, 33);
            this.FelhTB.Name = "FelhTB";
            this.FelhTB.Size = new System.Drawing.Size(321, 27);
            this.FelhTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jelszó:";
            // 
            // JelszoTB
            // 
            this.JelszoTB.Location = new System.Drawing.Point(161, 87);
            this.JelszoTB.Name = "JelszoTB";
            this.JelszoTB.PasswordChar = '*';
            this.JelszoTB.Size = new System.Drawing.Size(321, 27);
            this.JelszoTB.TabIndex = 3;
            // 
            // BejelentkezesBtn
            // 
            this.BejelentkezesBtn.Location = new System.Drawing.Point(322, 134);
            this.BejelentkezesBtn.Name = "BejelentkezesBtn";
            this.BejelentkezesBtn.Size = new System.Drawing.Size(160, 29);
            this.BejelentkezesBtn.TabIndex = 4;
            this.BejelentkezesBtn.Text = "Bejelentkezés";
            this.BejelentkezesBtn.UseVisualStyleBackColor = true;
            this.BejelentkezesBtn.Click += new System.EventHandler(this.BejelentkezesBtn_Click);
            // 
            // BejelentkezesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 188);
            this.Controls.Add(this.BejelentkezesBtn);
            this.Controls.Add(this.JelszoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FelhTB);
            this.Controls.Add(this.label1);
            this.Name = "BejelentkezesForm";
            this.Text = "Bejelentkezés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FelhTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox JelszoTB;
        private System.Windows.Forms.Button BejelentkezesBtn;
    }
}

