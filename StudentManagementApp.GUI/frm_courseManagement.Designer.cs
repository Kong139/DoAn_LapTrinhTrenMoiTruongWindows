namespace StudentManagementApp.GUI
{
    partial class frm_courseManagement
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.lbl_find = new System.Windows.Forms.Label();
            this.dgv_course = new System.Windows.Forms.DataGridView();
            this.col_courseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_currentStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_semester = new System.Windows.Forms.ComboBox();
            this.txt_schedule = new System.Windows.Forms.TextBox();
            this.txt_teacherName = new System.Windows.Forms.TextBox();
            this.txt_courseID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_subject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_course)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(682, 143);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 32);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(324, 143);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(123, 32);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Sửa ";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(504, 143);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 32);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(1013, 11);
            this.btn_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(69, 28);
            this.btn_find.TabIndex = 9;
            this.btn_find.Text = "Tìm";
            this.btn_find.UseVisualStyleBackColor = true;
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(842, 14);
            this.txt_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(165, 22);
            this.txt_find.TabIndex = 8;
            // 
            // lbl_find
            // 
            this.lbl_find.AutoSize = true;
            this.lbl_find.Location = new System.Drawing.Point(713, 17);
            this.lbl_find.Name = "lbl_find";
            this.lbl_find.Size = new System.Drawing.Size(92, 16);
            this.lbl_find.TabIndex = 7;
            this.lbl_find.Text = "Tìm Học Phần";
            // 
            // dgv_course
            // 
            this.dgv_course.AllowUserToAddRows = false;
            this.dgv_course.AllowUserToDeleteRows = false;
            this.dgv_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_courseID,
            this.col_courseName,
            this.col_teacher,
            this.col_semester,
            this.col_schedule,
            this.col_currentStudents});
            this.dgv_course.Location = new System.Drawing.Point(3, 52);
            this.dgv_course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_course.Name = "dgv_course";
            this.dgv_course.ReadOnly = true;
            this.dgv_course.RowHeadersWidth = 62;
            this.dgv_course.RowTemplate.Height = 28;
            this.dgv_course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_course.Size = new System.Drawing.Size(1145, 243);
            this.dgv_course.TabIndex = 6;
            this.dgv_course.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_course_CellClick);
            // 
            // col_courseID
            // 
            this.col_courseID.HeaderText = "Mã học phần";
            this.col_courseID.MinimumWidth = 8;
            this.col_courseID.Name = "col_courseID";
            this.col_courseID.ReadOnly = true;
            this.col_courseID.Width = 150;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1151F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgv_course, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.83502F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.16499F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 503);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.cbb_subject);
            this.groupBox1.Controls.Add(this.cbb_semester);
            this.groupBox1.Controls.Add(this.txt_schedule);
            this.groupBox1.Controls.Add(this.txt_teacherName);
            this.groupBox1.Controls.Add(this.txt_courseID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1137, 198);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // cbb_semester
            // 
            this.cbb_semester.FormattingEnabled = true;
            this.cbb_semester.Location = new System.Drawing.Point(131, 74);
            this.cbb_semester.Name = "cbb_semester";
            this.cbb_semester.Size = new System.Drawing.Size(199, 24);
            this.cbb_semester.TabIndex = 17;
            // 
            // txt_schedule
            // 
            this.txt_schedule.Location = new System.Drawing.Point(467, 74);
            this.txt_schedule.Name = "txt_schedule";
            this.txt_schedule.Size = new System.Drawing.Size(233, 22);
            this.txt_schedule.TabIndex = 16;
            // 
            // txt_teacherName
            // 
            this.txt_teacherName.Location = new System.Drawing.Point(467, 19);
            this.txt_teacherName.Name = "txt_teacherName";
            this.txt_teacherName.Size = new System.Drawing.Size(233, 22);
            this.txt_teacherName.TabIndex = 16;
            // 
            // txt_courseID
            // 
            this.txt_courseID.Location = new System.Drawing.Point(131, 19);
            this.txt_courseID.Name = "txt_courseID";
            this.txt_courseID.Size = new System.Drawing.Size(110, 22);
            this.txt_courseID.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Môn học:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã học phần:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lịch học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Giảng viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Học kỳ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_find);
            this.groupBox2.Controls.Add(this.lbl_find);
            this.groupBox2.Controls.Add(this.btn_find);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1145, 44);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // cbb_subject
            // 
            this.cbb_subject.FormattingEnabled = true;
            this.cbb_subject.Location = new System.Drawing.Point(831, 19);
            this.cbb_subject.Name = "cbb_subject";
            this.cbb_subject.Size = new System.Drawing.Size(282, 24);
            this.cbb_subject.TabIndex = 17;
            // 
            // frm_courseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frm_courseManagement";
            this.Text = "Quản lý học phần";
            this.Load += new System.EventHandler(this.frm_courseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_course)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label lbl_find;
        private System.Windows.Forms.DataGridView dgv_course;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_courseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_courseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_currentStudents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_semester;
        private System.Windows.Forms.TextBox txt_schedule;
        private System.Windows.Forms.TextBox txt_teacherName;
        private System.Windows.Forms.TextBox txt_courseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_subject;
    }
}