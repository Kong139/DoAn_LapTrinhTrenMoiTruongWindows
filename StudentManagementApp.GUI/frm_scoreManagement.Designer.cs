namespace StudentManagementApp.GUI
{
    partial class frm_scoreManagement
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
            this.dgv_scoreManagement = new System.Windows.Forms.DataGridView();
            this.btn_editScoreValue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.col_subjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_scoreCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_scoreValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_subjectName = new System.Windows.Forms.TextBox();
            this.txt_subjectID = new System.Windows.Forms.TextBox();
            this.txt_scoreValue = new System.Windows.Forms.TextBox();
            this.cbb_scoreCategory = new System.Windows.Forms.ComboBox();
            this.lbl_studentName = new System.Windows.Forms.Label();
            this.lbl_studentID = new System.Windows.Forms.Label();
            this.lbl_findSubjectID = new System.Windows.Forms.Label();
            this.txt_findSubjectID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_scoreManagement)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_scoreManagement
            // 
            this.dgv_scoreManagement.AllowUserToAddRows = false;
            this.dgv_scoreManagement.AllowUserToDeleteRows = false;
            this.dgv_scoreManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_scoreManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_subjectID,
            this.col_subjectName,
            this.col_scoreCategory,
            this.col_scoreValue});
            this.dgv_scoreManagement.Location = new System.Drawing.Point(12, 151);
            this.dgv_scoreManagement.Name = "dgv_scoreManagement";
            this.dgv_scoreManagement.ReadOnly = true;
            this.dgv_scoreManagement.RowHeadersWidth = 51;
            this.dgv_scoreManagement.RowTemplate.Height = 24;
            this.dgv_scoreManagement.Size = new System.Drawing.Size(969, 424);
            this.dgv_scoreManagement.TabIndex = 0;
            this.dgv_scoreManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_scoreManagement_CellClick);
            // 
            // btn_editScoreValue
            // 
            this.btn_editScoreValue.Location = new System.Drawing.Point(554, 8);
            this.btn_editScoreValue.Name = "btn_editScoreValue";
            this.btn_editScoreValue.Size = new System.Drawing.Size(122, 43);
            this.btn_editScoreValue.TabIndex = 1;
            this.btn_editScoreValue.Text = "Sửa điểm";
            this.btn_editScoreValue.UseVisualStyleBackColor = true;
            this.btn_editScoreValue.Click += new System.EventHandler(this.btn_editScoreValue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_scoreCategory);
            this.groupBox1.Controls.Add(this.txt_scoreValue);
            this.groupBox1.Controls.Add(this.txt_subjectName);
            this.groupBox1.Controls.Add(this.txt_subjectID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên môn học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cột điểm:";
            // 
            // col_subjectID
            // 
            this.col_subjectID.HeaderText = "Mã môn";
            this.col_subjectID.MinimumWidth = 6;
            this.col_subjectID.Name = "col_subjectID";
            this.col_subjectID.ReadOnly = true;
            this.col_subjectID.Width = 125;
            // 
            // col_subjectName
            // 
            this.col_subjectName.HeaderText = "Tên môn học";
            this.col_subjectName.MinimumWidth = 6;
            this.col_subjectName.Name = "col_subjectName";
            this.col_subjectName.ReadOnly = true;
            this.col_subjectName.Width = 125;
            // 
            // col_scoreCategory
            // 
            this.col_scoreCategory.HeaderText = "Cột điểm";
            this.col_scoreCategory.MinimumWidth = 6;
            this.col_scoreCategory.Name = "col_scoreCategory";
            this.col_scoreCategory.ReadOnly = true;
            this.col_scoreCategory.Width = 125;
            // 
            // col_scoreValue
            // 
            this.col_scoreValue.HeaderText = "Điểm";
            this.col_scoreValue.MinimumWidth = 6;
            this.col_scoreValue.Name = "col_scoreValue";
            this.col_scoreValue.ReadOnly = true;
            this.col_scoreValue.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm:";
            // 
            // txt_subjectName
            // 
            this.txt_subjectName.Location = new System.Drawing.Point(139, 58);
            this.txt_subjectName.Name = "txt_subjectName";
            this.txt_subjectName.Size = new System.Drawing.Size(246, 22);
            this.txt_subjectName.TabIndex = 1;
            // 
            // txt_subjectID
            // 
            this.txt_subjectID.Location = new System.Drawing.Point(139, 15);
            this.txt_subjectID.Name = "txt_subjectID";
            this.txt_subjectID.Size = new System.Drawing.Size(100, 22);
            this.txt_subjectID.TabIndex = 1;
            this.txt_subjectID.TextChanged += new System.EventHandler(this.txt_subjectID_TextChanged);
            // 
            // txt_scoreValue
            // 
            this.txt_scoreValue.Location = new System.Drawing.Point(429, 101);
            this.txt_scoreValue.Name = "txt_scoreValue";
            this.txt_scoreValue.Size = new System.Drawing.Size(75, 22);
            this.txt_scoreValue.TabIndex = 2;
            // 
            // cbb_scoreCategory
            // 
            this.cbb_scoreCategory.FormattingEnabled = true;
            this.cbb_scoreCategory.Location = new System.Drawing.Point(139, 101);
            this.cbb_scoreCategory.Name = "cbb_scoreCategory";
            this.cbb_scoreCategory.Size = new System.Drawing.Size(134, 24);
            this.cbb_scoreCategory.TabIndex = 3;
            // 
            // lbl_studentName
            // 
            this.lbl_studentName.Location = new System.Drawing.Point(21, 35);
            this.lbl_studentName.Name = "lbl_studentName";
            this.lbl_studentName.Size = new System.Drawing.Size(198, 46);
            this.lbl_studentName.TabIndex = 5;
            this.lbl_studentName.Text = "Họ tên";
            this.lbl_studentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_studentID
            // 
            this.lbl_studentID.Location = new System.Drawing.Point(30, 15);
            this.lbl_studentID.Name = "lbl_studentID";
            this.lbl_studentID.Size = new System.Drawing.Size(180, 20);
            this.lbl_studentID.TabIndex = 4;
            this.lbl_studentID.Text = "MSSV";
            this.lbl_studentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_findSubjectID
            // 
            this.lbl_findSubjectID.AutoSize = true;
            this.lbl_findSubjectID.Location = new System.Drawing.Point(720, 115);
            this.lbl_findSubjectID.Name = "lbl_findSubjectID";
            this.lbl_findSubjectID.Size = new System.Drawing.Size(84, 16);
            this.lbl_findSubjectID.TabIndex = 6;
            this.lbl_findSubjectID.Text = "Tìm mã môn:";
            // 
            // txt_findSubjectID
            // 
            this.txt_findSubjectID.Location = new System.Drawing.Point(840, 112);
            this.txt_findSubjectID.Name = "txt_findSubjectID";
            this.txt_findSubjectID.Size = new System.Drawing.Size(141, 22);
            this.txt_findSubjectID.TabIndex = 7;
            this.txt_findSubjectID.TextChanged += new System.EventHandler(this.txt_findSubjectID_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_studentName);
            this.groupBox2.Controls.Add(this.lbl_studentID);
            this.groupBox2.Location = new System.Drawing.Point(723, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 88);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // frm_scoreManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_findSubjectID);
            this.Controls.Add(this.lbl_findSubjectID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_editScoreValue);
            this.Controls.Add(this.dgv_scoreManagement);
            this.MaximizeBox = false;
            this.Name = "frm_scoreManagement";
            this.Text = "Quản lý điểm";
            this.Load += new System.EventHandler(this.frm_scoreManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_scoreManagement)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_scoreManagement;
        private System.Windows.Forms.Button btn_editScoreValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_subjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_scoreCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_scoreValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_scoreCategory;
        private System.Windows.Forms.TextBox txt_scoreValue;
        private System.Windows.Forms.TextBox txt_subjectName;
        private System.Windows.Forms.TextBox txt_subjectID;
        private System.Windows.Forms.Label lbl_studentName;
        private System.Windows.Forms.Label lbl_studentID;
        private System.Windows.Forms.Label lbl_findSubjectID;
        private System.Windows.Forms.TextBox txt_findSubjectID;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}