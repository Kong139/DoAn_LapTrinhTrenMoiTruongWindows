namespace StudentManagementApp.GUI
{
    partial class frm_courseRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_courseRegistration));
            this.dgv_courseRegistered = new System.Windows.Forms.DataGridView();
            this.col_courseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_subjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_teacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_semesterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_findCourse = new System.Windows.Forms.Button();
            this.txt_findCourse = new System.Windows.Forms.TextBox();
            this.lbl_studentName = new System.Windows.Forms.Label();
            this.lbl_studentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseRegistered)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_courseRegistered
            // 
            this.dgv_courseRegistered.AllowUserToAddRows = false;
            this.dgv_courseRegistered.AllowUserToDeleteRows = false;
            this.dgv_courseRegistered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_courseRegistered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_courseID,
            this.col_subjectID,
            this.col_subjectName,
            this.col_teacherName,
            this.col_semesterName});
            this.dgv_courseRegistered.Location = new System.Drawing.Point(12, 175);
            this.dgv_courseRegistered.Name = "dgv_courseRegistered";
            this.dgv_courseRegistered.ReadOnly = true;
            this.dgv_courseRegistered.RowHeadersWidth = 51;
            this.dgv_courseRegistered.RowTemplate.Height = 24;
            this.dgv_courseRegistered.Size = new System.Drawing.Size(867, 428);
            this.dgv_courseRegistered.TabIndex = 0;
            // 
            // col_courseID
            // 
            this.col_courseID.HeaderText = "Mã học phần";
            this.col_courseID.MinimumWidth = 6;
            this.col_courseID.Name = "col_courseID";
            this.col_courseID.ReadOnly = true;
            this.col_courseID.Width = 125;
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
            this.col_subjectName.HeaderText = "Tên môn";
            this.col_subjectName.MinimumWidth = 6;
            this.col_subjectName.Name = "col_subjectName";
            this.col_subjectName.ReadOnly = true;
            this.col_subjectName.Width = 125;
            // 
            // col_teacherName
            // 
            this.col_teacherName.HeaderText = "Giảng viên";
            this.col_teacherName.MinimumWidth = 6;
            this.col_teacherName.Name = "col_teacherName";
            this.col_teacherName.ReadOnly = true;
            this.col_teacherName.Width = 125;
            // 
            // col_semesterName
            // 
            this.col_semesterName.HeaderText = "Học kỳ";
            this.col_semesterName.MinimumWidth = 6;
            this.col_semesterName.Name = "col_semesterName";
            this.col_semesterName.ReadOnly = true;
            this.col_semesterName.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Các học phần đã đăng ký";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_findCourse);
            this.groupBox1.Controls.Add(this.txt_findCourse);
            this.groupBox1.Location = new System.Drawing.Point(375, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 83);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập mã môn cần đăng ký:";
            // 
            // btn_findCourse
            // 
            this.btn_findCourse.Location = new System.Drawing.Point(358, 27);
            this.btn_findCourse.Name = "btn_findCourse";
            this.btn_findCourse.Size = new System.Drawing.Size(137, 33);
            this.btn_findCourse.TabIndex = 2;
            this.btn_findCourse.Text = "Tìm học phần";
            this.btn_findCourse.UseVisualStyleBackColor = true;
            this.btn_findCourse.Click += new System.EventHandler(this.btn_findCourse_Click);
            // 
            // txt_findCourse
            // 
            this.txt_findCourse.Location = new System.Drawing.Point(234, 32);
            this.txt_findCourse.Name = "txt_findCourse";
            this.txt_findCourse.Size = new System.Drawing.Size(109, 22);
            this.txt_findCourse.TabIndex = 1;
            // 
            // lbl_studentName
            // 
            this.lbl_studentName.Location = new System.Drawing.Point(43, 29);
            this.lbl_studentName.Name = "lbl_studentName";
            this.lbl_studentName.Size = new System.Drawing.Size(198, 46);
            this.lbl_studentName.TabIndex = 5;
            this.lbl_studentName.Text = "Họ tên";
            this.lbl_studentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_studentID
            // 
            this.lbl_studentID.Location = new System.Drawing.Point(52, 9);
            this.lbl_studentID.Name = "lbl_studentID";
            this.lbl_studentID.Size = new System.Drawing.Size(180, 20);
            this.lbl_studentID.TabIndex = 4;
            this.lbl_studentID.Text = "MSSV";
            this.lbl_studentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_courseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 616);
            this.Controls.Add(this.lbl_studentName);
            this.Controls.Add(this.lbl_studentID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_courseRegistered);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_courseRegistration";
            this.Text = "Đăng ký học phần";
            this.Load += new System.EventHandler(this.frm_courseRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseRegistered)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_courseRegistered;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_courseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_subjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_teacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_semesterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_findCourse;
        private System.Windows.Forms.Button btn_findCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_studentName;
        private System.Windows.Forms.Label lbl_studentID;
    }
}