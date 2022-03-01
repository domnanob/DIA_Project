
namespace DIA_Project.Forms.TeacherForms
{
    partial class TeacherTestsUsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UsersTestsDGV = new System.Windows.Forms.DataGridView();
            this.MegnyitasBtn = new System.Windows.Forms.Button();
            this.VisszaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTestsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersTestsDGV
            // 
            this.UsersTestsDGV.AllowUserToAddRows = false;
            this.UsersTestsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.UsersTestsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersTestsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersTestsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UsersTestsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.UsersTestsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersTestsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.UsersTestsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersTestsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersTestsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersTestsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.UsersTestsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.UsersTestsDGV.Location = new System.Drawing.Point(50, 105);
            this.UsersTestsDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsersTestsDGV.MultiSelect = false;
            this.UsersTestsDGV.Name = "UsersTestsDGV";
            this.UsersTestsDGV.ReadOnly = true;
            this.UsersTestsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersTestsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UsersTestsDGV.RowHeadersVisible = false;
            this.UsersTestsDGV.RowHeadersWidth = 51;
            this.UsersTestsDGV.RowTemplate.Height = 29;
            this.UsersTestsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersTestsDGV.Size = new System.Drawing.Size(562, 257);
            this.UsersTestsDGV.TabIndex = 1;
            this.UsersTestsDGV.DataSourceChanged += new System.EventHandler(this.PurchasesDGV_DataSourceChanged);
            // 
            // MegnyitasBtn
            // 
            this.MegnyitasBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.MegnyitasBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MegnyitasBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.MegnyitasBtn.FlatAppearance.BorderSize = 2;
            this.MegnyitasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MegnyitasBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MegnyitasBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.MegnyitasBtn.Location = new System.Drawing.Point(520, 74);
            this.MegnyitasBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MegnyitasBtn.Name = "MegnyitasBtn";
            this.MegnyitasBtn.Size = new System.Drawing.Size(92, 27);
            this.MegnyitasBtn.TabIndex = 3;
            this.MegnyitasBtn.Text = "Megnyitás";
            this.MegnyitasBtn.UseVisualStyleBackColor = false;
            this.MegnyitasBtn.Click += new System.EventHandler(this.MegnyitasBtn_Click);
            // 
            // VisszaBtn
            // 
            this.VisszaBtn.BackColor = System.Drawing.Color.Transparent;
            this.VisszaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisszaBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.VisszaBtn.FlatAppearance.BorderSize = 2;
            this.VisszaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisszaBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VisszaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.VisszaBtn.Location = new System.Drawing.Point(422, 74);
            this.VisszaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisszaBtn.Name = "VisszaBtn";
            this.VisszaBtn.Size = new System.Drawing.Size(92, 28);
            this.VisszaBtn.TabIndex = 2;
            this.VisszaBtn.Text = "Vissza";
            this.VisszaBtn.UseVisualStyleBackColor = false;
            this.VisszaBtn.Click += new System.EventHandler(this.VisszaBtn_Click);
            // 
            // TeacherTestsUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImage = global::DIA_Project.Properties.Resources.WinFormBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 435);
            this.Controls.Add(this.VisszaBtn);
            this.Controls.Add(this.MegnyitasBtn);
            this.Controls.Add(this.UsersTestsDGV);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeacherTestsUsersForm";
            this.Text = "InfoForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherTestsUsersForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTestsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView UsersTestsDGV;
        private System.Windows.Forms.Button MegnyitasBtn;
        private System.Windows.Forms.Button VisszaBtn;
    }
}