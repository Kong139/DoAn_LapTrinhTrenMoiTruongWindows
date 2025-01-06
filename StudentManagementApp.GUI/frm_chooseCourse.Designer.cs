namespace StudentManagementApp.GUI
{
    partial class frm_chooseCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_chooseCourse));
            this.btn_register = new System.Windows.Forms.Button();
            this.dgv_course = new System.Windows.Forms.DataGridView();
            this.col_courseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_subjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_currentStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_course)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(481, 280);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(125, 33);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Đăng ký";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // dgv_course
            // 
            this.dgv_course.AllowUserToAddRows = false;
            this.dgv_course.AllowUserToDeleteRows = false;
            this.dgv_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_courseID,
            this.col_subjectID,
            this.col_courseName,
            this.col_teacher,
            this.col_semester,
            this.col_schedule,
            this.col_currentStudents});
            this.dgv_course.Location = new System.Drawing.Point(12, 11);
            this.dgv_course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_course.Name = "dgv_course";
            this.dgv_course.ReadOnly = true;
            this.dgv_course.RowHeadersWidth = 62;
            this.dgv_course.RowTemplate.Height = 28;
            this.dgv_course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_course.Size = new System.Drawing.Size(1056, 248);
            this.dgv_course.TabIndex = 7;
            // 
            // col_courseID
            // 
            this.col_courseID.HeaderText = "Mã học phần";
            this.col_courseID.MinimumWidth = 8;
            this.col_courseID.Name = "col_courseID";
            this.col_courseID.ReadOnly = true;
            this.col_courseID.Width = 150;
            // 
            // col_subjectID
            // 
            this.col_subjectID.HeaderText = "Mã môn học";
            this.col_subjectID.MinimumWidth = 6;
            this.col_subjectID.Name = "col_subjectID";
            this.col_subjectID.ReadOnly = true;
            this.col_subjectID.Width = 125;
            // 
            // col_courseName
            // 
            this.col_courseName.HeaderText = "Tên môn học";
            this.col_courseName.MinimumWidth = 8;
            this.col_courseName.Name = "col_courseName";
            this.col_courseName.ReadOnly = true;
            this.col_courseName.Width = 150;
            // 
            // col_teacher
            // 
            this.col_teacher.HeaderText = "Giảng Viên";
            this.col_teacher.MinimumWidth = 8;
            this.col_teacher.Name = "col_teacher";
            this.col_teacher.ReadOnly = true;
            this.col_teacher.Width = 150;
            // 
            // col_semester
            // 
            this.col_semester.HeaderText = "Học kỳ";
            this.col_semester.MinimumWidth = 8;
            this.col_semester.Name = "col_semester";
            this.col_semester.ReadOnly = true;
            this.col_semester.Width = 150;
            // 
            // col_schedule
            // 
            this.col_schedule.HeaderText = "Lịch học";
            this.col_schedule.MinimumWidth = 8;
            this.col_schedule.Name = "col_schedule";
            this.col_schedule.ReadOnly = true;
            this.col_schedule.Width = 150;
            // 
            // col_currentStudents
            // 
            this.col_currentStudents.HeaderText = "Số sinh viên đã đăng ký";
            this.col_currentStudents.MinimumWidth = 8;
            this.col_currentStudents.Name = "col_currentStudents";
            this.col_currentStudents.ReadOnly = true;
            this.col_currentStudents.Width = 150;
            // 
            // frm_chooseCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 325);
            this.Controls.Add(this.dgv_course);
            this.Controls.Add(this.btn_register);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_chooseCourse";
            this.Text = "Chọn học phần";
            this.Load += new System.EventHandler(this.frm_chooseCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.DataGridView dgv_course;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_courseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_subjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_courseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_currentStudents;
    }
}