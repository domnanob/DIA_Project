
namespace DIA_Project.Forms.TeacherForms
{
    partial class TeacherTestsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TestsDGV = new System.Windows.Forms.DataGridView();
            this.ClassesCB = new System.Windows.Forms.ComboBox();
            this.NewTestBtn = new System.Windows.Forms.Button();
            this.MegnyitasBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DIA_Project.Properties.Resources.repair_tool;
            this.pictureBox1.Location = new System.Drawing.Point(684, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TestsDGV
            // 
            this.TestsDGV.AllowUserToAddRows = false;
            this.TestsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.TestsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TestsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TestsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TestsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TestsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TestsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TestsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TestsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TestsDGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.TestsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.TestsDGV.Location = new System.Drawing.Point(50, 123);
            this.TestsDGV.MultiSelect = false;
            this.TestsDGV.Name = "TestsDGV";
            this.TestsDGV.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TestsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.TestsDGV.RowHeadersVisible = false;
            this.TestsDGV.RowHeadersWidth = 51;
            this.TestsDGV.RowTemplate.Height = 29;
            this.TestsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TestsDGV.Size = new System.Drawing.Size(645, 343);
            this.TestsDGV.TabIndex = 6;
            this.TestsDGV.DataSourceChanged += new System.EventHandler(this.PurchasesDGV_DataSourceChanged);
            // 
            // ClassesCB
            // 
            this.ClassesCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClassesCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassesCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassesCB.ForeColor = System.Drawing.Color.White;
            this.ClassesCB.FormattingEnabled = true;
            this.ClassesCB.Items.AddRange(new object[] {
            "None"});
            this.ClassesCB.Location = new System.Drawing.Point(50, 77);
            this.ClassesCB.Name = "ClassesCB";
            this.ClassesCB.Size = new System.Drawing.Size(214, 28);
            this.ClassesCB.TabIndex = 8;
            // 
            // NewTestBtn
            // 
            this.NewTestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.NewTestBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.NewTestBtn.FlatAppearance.BorderSize = 2;
            this.NewTestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTestBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewTestBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.NewTestBtn.Location = new System.Drawing.Point(590, 72);
            this.NewTestBtn.Name = "NewTestBtn";
            this.NewTestBtn.Size = new System.Drawing.Size(105, 36);
            this.NewTestBtn.TabIndex = 9;
            this.NewTestBtn.Text = "Új";
            this.NewTestBtn.UseVisualStyleBackColor = false;
            this.NewTestBtn.Click += new System.EventHandler(this.NewTestBtn_Click);
            // 
            // MegnyitasBtn
            // 
            this.MegnyitasBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.MegnyitasBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.MegnyitasBtn.FlatAppearance.BorderSize = 2;
            this.MegnyitasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MegnyitasBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MegnyitasBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.MegnyitasBtn.Location = new System.Drawing.Point(479, 72);
            this.MegnyitasBtn.Name = "MegnyitasBtn";
            this.MegnyitasBtn.Size = new System.Drawing.Size(105, 36);
            this.MegnyitasBtn.TabIndex = 9;
            this.MegnyitasBtn.Text = "Megnyitás";
            this.MegnyitasBtn.UseVisualStyleBackColor = false;
            this.MegnyitasBtn.Click += new System.EventHandler(this.MegnyitasBtn_Click);
            // 
            // TeacherTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(760, 548);
            this.Controls.Add(this.MegnyitasBtn);
            this.Controls.Add(this.NewTestBtn);
            this.Controls.Add(this.ClassesCB);
            this.Controls.Add(this.TestsDGV);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherTestsForm";
            this.Text = "InfoForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherTestsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView TestsDGV;
        private System.Windows.Forms.ComboBox ClassesCB;
        private System.Windows.Forms.Button NewTestBtn;
        private System.Windows.Forms.Button MegnyitasBtn;
    }
}