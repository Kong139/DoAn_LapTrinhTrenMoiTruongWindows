﻿namespace StudentManagementApp.GUI
{
    partial class frm_studentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_studentManagement));
            this.grb_studentDetail = new System.Windows.Forms.GroupBox();
            this.btn_courseRegistration = new System.Windows.Forms.Button();
            this.btn_scoreManagement = new System.Windows.Forms.Button();
            this.btn_editStudent = new System.Windows.Forms.Button();
            this.lbl_studentName = new System.Windows.Forms.Label();
            this.lbl_studentID = new System.Windows.Forms.Label();
            this.pic_student = new System.Windows.Forms.PictureBox();
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.col_studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtFileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_restore = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhóaHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_addStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_editStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_deleteStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoGiớiTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_filterByGender_nam = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_filterByGender_nu = new System.Windows.Forms.ToolStripMenuItem();
            this.theoLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cbb_class = new System.Windows.Forms.ToolStripComboBox();
            this.theoKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cbb_faculty = new System.Windows.Forms.ToolStripComboBox();
            this.menu_cbb_major = new System.Windows.Forms.ToolStripComboBox();
            this.theoTrạngTháiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cbb_status = new System.Windows.Forms.ToolStripComboBox();
            this.theoGPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_filterByGPAxx = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_filterByGPAgioi = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_filterByGPAkha = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_filterByGPAtb = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_filterByGPAyeu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_filterByGPAkem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txt_findByID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolstr_btn_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstr_btn_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstr_btn_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstr_btn_reload = new System.Windows.Forms.ToolStripButton();
            this.grb_studentDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_studentDetail
            // 
            this.grb_studentDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grb_studentDetail.Controls.Add(this.btn_courseRegistration);
            this.grb_studentDetail.Controls.Add(this.btn_scoreManagement);
            this.grb_studentDetail.Controls.Add(this.btn_editStudent);
            this.grb_studentDetail.Controls.Add(this.lbl_studentName);
            this.grb_studentDetail.Controls.Add(this.lbl_studentID);
            this.grb_studentDetail.Controls.Add(this.pic_student);
            this.grb_studentDetail.Location = new System.Drawing.Point(12, 63);
            this.grb_studentDetail.Name = "grb_studentDetail";
            this.grb_studentDetail.Size = new System.Drawing.Size(210, 573);
            this.grb_studentDetail.TabIndex = 5;
            this.grb_studentDetail.TabStop = false;
            this.grb_studentDetail.Visible = false;
            // 
            // btn_courseRegistration
            // 
            this.btn_courseRegistration.Location = new System.Drawing.Point(29, 427);
            this.btn_courseRegistration.Name = "btn_courseRegistration";
            this.btn_courseRegistration.Size = new System.Drawing.Size(150, 33);
            this.btn_courseRegistration.TabIndex = 13;
            this.btn_courseRegistration.Text = "Đăng ký học phần";
            this.btn_courseRegistration.UseVisualStyleBackColor = true;
            this.btn_courseRegistration.Click += new System.EventHandler(this.btn_courseRegistration_Click);
            // 
            // btn_scoreManagement
            // 
            this.btn_scoreManagement.Location = new System.Drawing.Point(29, 388);
            this.btn_scoreManagement.Name = "btn_scoreManagement";
            this.btn_scoreManagement.Size = new System.Drawing.Size(150, 33);
            this.btn_scoreManagement.TabIndex = 12;
            this.btn_scoreManagement.Text = "Quản lý điểm";
            this.btn_scoreManagement.UseVisualStyleBackColor = true;
            this.btn_scoreManagement.Click += new System.EventHandler(this.btn_scoreManagement_Click);
            // 
            // btn_editStudent
            // 
            this.btn_editStudent.Location = new System.Drawing.Point(29, 349);
            this.btn_editStudent.Name = "btn_editStudent";
            this.btn_editStudent.Size = new System.Drawing.Size(150, 33);
            this.btn_editStudent.TabIndex = 11;
            this.btn_editStudent.Text = "Sửa thông tin";
            this.btn_editStudent.UseVisualStyleBackColor = true;
            this.btn_editStudent.Click += new System.EventHandler(this.btn_editStudent_Click);
            // 
            // lbl_studentName
            // 
            this.lbl_studentName.Location = new System.Drawing.Point(6, 286);
            this.lbl_studentName.Name = "lbl_studentName";
            this.lbl_studentName.Size = new System.Drawing.Size(198, 46);
            this.lbl_studentName.TabIndex = 2;
            this.lbl_studentName.Text = "Họ tên";
            this.lbl_studentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_studentID
            // 
            this.lbl_studentID.Location = new System.Drawing.Point(15, 266);
            this.lbl_studentID.Name = "lbl_studentID";
            this.lbl_studentID.Size = new System.Drawing.Size(180, 20);
            this.lbl_studentID.TabIndex = 1;
            this.lbl_studentID.Text = "MSSV";
            this.lbl_studentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_student
            // 
            this.pic_student.Location = new System.Drawing.Point(18, 21);
            this.pic_student.Name = "pic_student";
            this.pic_student.Size = new System.Drawing.Size(175, 233);
            this.pic_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_student.TabIndex = 0;
            this.pic_student.TabStop = false;
            // 
            // dgv_student
            // 
            this.dgv_student.AllowUserToAddRows = false;
            this.dgv_student.AllowUserToDeleteRows = false;
            this.dgv_student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_student.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_studentID,
            this.col_studentName,
            this.col_gender,
            this.col_birthday,
            this.col_class,
            this.col_GPA,
            this.col_faculty,
            this.col_major,
            this.col_status,
            this.col_email,
            this.col_phone,
            this.col_Adress});
            this.dgv_student.Location = new System.Drawing.Point(228, 70);
            this.dgv_student.MultiSelect = false;
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.ReadOnly = true;
            this.dgv_student.RowHeadersWidth = 51;
            this.dgv_student.RowTemplate.Height = 24;
            this.dgv_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_student.Size = new System.Drawing.Size(1022, 566);
            this.dgv_student.TabIndex = 3;
            this.dgv_student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_student_CellClick);
            // 
            // col_studentID
            // 
            this.col_studentID.HeaderText = "MSSV";
            this.col_studentID.MinimumWidth = 6;
            this.col_studentID.Name = "col_studentID";
            this.col_studentID.ReadOnly = true;
            this.col_studentID.Width = 74;
            // 
            // col_studentName
            // 
            this.col_studentName.HeaderText = "Họ tên";
            this.col_studentName.MinimumWidth = 6;
            this.col_studentName.Name = "col_studentName";
            this.col_studentName.ReadOnly = true;
            this.col_studentName.Width = 75;
            // 
            // col_gender
            // 
            this.col_gender.HeaderText = "Giới tính";
            this.col_gender.MinimumWidth = 6;
            this.col_gender.Name = "col_gender";
            this.col_gender.ReadOnly = true;
            this.col_gender.Width = 83;
            // 
            // col_birthday
            // 
            this.col_birthday.HeaderText = "Ngày sinh";
            this.col_birthday.MinimumWidth = 6;
            this.col_birthday.Name = "col_birthday";
            this.col_birthday.ReadOnly = true;
            this.col_birthday.Width = 96;
            // 
            // col_class
            // 
            this.col_class.HeaderText = "Lớp";
            this.col_class.MinimumWidth = 6;
            this.col_class.Name = "col_class";
            this.col_class.ReadOnly = true;
            this.col_class.Width = 59;
            // 
            // col_GPA
            // 
            this.col_GPA.HeaderText = "GPA";
            this.col_GPA.MinimumWidth = 6;
            this.col_GPA.Name = "col_GPA";
            this.col_GPA.ReadOnly = true;
            this.col_GPA.Width = 64;
            // 
            // col_faculty
            // 
            this.col_faculty.HeaderText = "Khoa";
            this.col_faculty.MinimumWidth = 6;
            this.col_faculty.Name = "col_faculty";
            this.col_faculty.ReadOnly = true;
            this.col_faculty.Width = 67;
            // 
            // col_major
            // 
            this.col_major.HeaderText = "Chuyên ngành";
            this.col_major.MinimumWidth = 6;
            this.col_major.Name = "col_major";
            this.col_major.ReadOnly = true;
            this.col_major.Width = 121;
            // 
            // col_status
            // 
            this.col_status.HeaderText = "Trạng thái";
            this.col_status.MinimumWidth = 6;
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            this.col_status.Width = 96;
            // 
            // col_email
            // 
            this.col_email.HeaderText = "Email";
            this.col_email.MinimumWidth = 6;
            this.col_email.Name = "col_email";
            this.col_email.ReadOnly = true;
            this.col_email.Width = 70;
            // 
            // col_phone
            // 
            this.col_phone.HeaderText = "SĐT";
            this.col_phone.MinimumWidth = 6;
            this.col_phone.Name = "col_phone";
            this.col_phone.ReadOnly = true;
            this.col_phone.Width = 63;
            // 
            // col_Adress
            // 
            this.col_Adress.HeaderText = "Địa chỉ";
            this.col_Adress.MinimumWidth = 6;
            this.col_Adress.Name = "col_Adress";
            this.col_Adress.ReadOnly = true;
            this.col_Adress.Width = 76;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtFileExcelToolStripMenuItem,
            this.menu_backup,
            this.menu_restore});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // xuấtFileExcelToolStripMenuItem
            // 
            this.xuấtFileExcelToolStripMenuItem.Name = "xuấtFileExcelToolStripMenuItem";
            this.xuấtFileExcelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xuấtFileExcelToolStripMenuItem.Text = "Xuất file excel";
            this.xuấtFileExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtFileExcelToolStripMenuItem_Click);
            // 
            // menu_backup
            // 
            this.menu_backup.Name = "menu_backup";
            this.menu_backup.Size = new System.Drawing.Size(224, 26);
            this.menu_backup.Text = "Backup";
            this.menu_backup.Click += new System.EventHandler(this.menu_backup_Click);
            // 
            // menu_restore
            // 
            this.menu_restore.Name = "menu_restore";
            this.menu_restore.Size = new System.Drawing.Size(224, 26);
            this.menu_restore.Text = "Restore data";
            this.menu_restore.Click += new System.EventHandler(this.menu_restore_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKhóaHọcToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // quảnLýKhóaHọcToolStripMenuItem
            // 
            this.quảnLýKhóaHọcToolStripMenuItem.Name = "quảnLýKhóaHọcToolStripMenuItem";
            this.quảnLýKhóaHọcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLýKhóaHọcToolStripMenuItem.Text = "Quản lý học phần";
            this.quảnLýKhóaHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhóaHọcToolStripMenuItem_Click);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_addStudent,
            this.menu_editStudent,
            this.menu_deleteStudent,
            this.toolStripSeparator1});
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.chỉnhSửaToolStripMenuItem.Text = "Thao tác";
            // 
            // menu_addStudent
            // 
            this.menu_addStudent.Name = "menu_addStudent";
            this.menu_addStudent.Size = new System.Drawing.Size(242, 26);
            this.menu_addStudent.Text = "Thêm sinh viên";
            this.menu_addStudent.Click += new System.EventHandler(this.menu_addStudent_Click);
            // 
            // menu_editStudent
            // 
            this.menu_editStudent.Name = "menu_editStudent";
            this.menu_editStudent.Size = new System.Drawing.Size(242, 26);
            this.menu_editStudent.Text = "Sửa thông tin sinh viên";
            this.menu_editStudent.Click += new System.EventHandler(this.menu_editStudent_Click);
            // 
            // menu_deleteStudent
            // 
            this.menu_deleteStudent.Name = "menu_deleteStudent";
            this.menu_deleteStudent.ShortcutKeyDisplayString = "Delete";
            this.menu_deleteStudent.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menu_deleteStudent.Size = new System.Drawing.Size(242, 26);
            this.menu_deleteStudent.Text = "Xóa sinh viên";
            this.menu_deleteStudent.Click += new System.EventHandler(this.menu_deleteStudent_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoGiớiTínhToolStripMenuItem,
            this.theoLớpToolStripMenuItem,
            this.theoKhoaToolStripMenuItem,
            this.theoTrạngTháiToolStripMenuItem,
            this.theoGPAToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.viewToolStripMenuItem.Text = "Lọc";
            // 
            // theoGiớiTínhToolStripMenuItem
            // 
            this.theoGiớiTínhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_filterByGender_nam,
            this.menu_filterByGender_nu});
            this.theoGiớiTínhToolStripMenuItem.Name = "theoGiớiTínhToolStripMenuItem";
            this.theoGiớiTínhToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.theoGiớiTínhToolStripMenuItem.Text = "Theo giới tính";
            // 
            // menu_filterByGender_nam
            // 
            this.menu_filterByGender_nam.Name = "menu_filterByGender_nam";
            this.menu_filterByGender_nam.Size = new System.Drawing.Size(124, 26);
            this.menu_filterByGender_nam.Text = "Nam";
            this.menu_filterByGender_nam.Click += new System.EventHandler(this.menu_filterByGender_nam_Click);
            // 
            // menu_filterByGender_nu
            // 
            this.menu_filterByGender_nu.Name = "menu_filterByGender_nu";
            this.menu_filterByGender_nu.Size = new System.Drawing.Size(124, 26);
            this.menu_filterByGender_nu.Text = "Nữ";
            this.menu_filterByGender_nu.Click += new System.EventHandler(this.menu_filterByGender_nu_Click);
            // 
            // theoLớpToolStripMenuItem
            // 
            this.theoLớpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cbb_class});
            this.theoLớpToolStripMenuItem.Name = "theoLớpToolStripMenuItem";
            this.theoLớpToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.theoLớpToolStripMenuItem.Text = "Theo lớp";
            // 
            // menu_cbb_class
            // 
            this.menu_cbb_class.Name = "menu_cbb_class";
            this.menu_cbb_class.Size = new System.Drawing.Size(121, 28);
            this.menu_cbb_class.SelectedIndexChanged += new System.EventHandler(this.menu_cbb_class_SelectedIndexChanged);
            // 
            // theoKhoaToolStripMenuItem
            // 
            this.theoKhoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cbb_faculty,
            this.menu_cbb_major});
            this.theoKhoaToolStripMenuItem.Name = "theoKhoaToolStripMenuItem";
            this.theoKhoaToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.theoKhoaToolStripMenuItem.Text = "Theo khoa/chuyên ngành";
            // 
            // menu_cbb_faculty
            // 
            this.menu_cbb_faculty.Name = "menu_cbb_faculty";
            this.menu_cbb_faculty.Size = new System.Drawing.Size(150, 28);
            this.menu_cbb_faculty.SelectedIndexChanged += new System.EventHandler(this.menu_cbb_faculty_SelectedIndexChanged);
            // 
            // menu_cbb_major
            // 
            this.menu_cbb_major.Name = "menu_cbb_major";
            this.menu_cbb_major.Size = new System.Drawing.Size(150, 28);
            this.menu_cbb_major.SelectedIndexChanged += new System.EventHandler(this.menu_cbb_major_SelectedIndexChanged);
            // 
            // theoTrạngTháiToolStripMenuItem
            // 
            this.theoTrạngTháiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cbb_status});
            this.theoTrạngTháiToolStripMenuItem.Name = "theoTrạngTháiToolStripMenuItem";
            this.theoTrạngTháiToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.theoTrạngTháiToolStripMenuItem.Text = "Theo trạng thái";
            // 
            // menu_cbb_status
            // 
            this.menu_cbb_status.Name = "menu_cbb_status";
            this.menu_cbb_status.Size = new System.Drawing.Size(121, 28);
            this.menu_cbb_status.SelectedIndexChanged += new System.EventHandler(this.menu_cbb_status_SelectedIndexChanged);
            // 
            // theoGPAToolStripMenuItem
            // 
            this.theoGPAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_filterByGPAxx,
            this.menu_filterByGPAgioi,
            this.menu_filterByGPAkha,
            this.menu_filterByGPAtb,
            this.menu_filterByGPAyeu,
            this.menu_filterByGPAkem});
            this.theoGPAToolStripMenuItem.Name = "theoGPAToolStripMenuItem";
            this.theoGPAToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.theoGPAToolStripMenuItem.Text = "Theo GPA";
            // 
            // menu_filterByGPAxx
            // 
            this.menu_filterByGPAxx.Name = "menu_filterByGPAxx";
            this.menu_filterByGPAxx.Size = new System.Drawing.Size(228, 26);
            this.menu_filterByGPAxx.Text = "Xuất sắc (3.6 - 4.0)";
            this.menu_filterByGPAxx.Click += new System.EventHandler(this.menu_filterByGPAxx_Click);
            // 
            // menu_filterByGPAgioi
            // 
            this.menu_filterByGPAgioi.Name = "menu_filterByGPAgioi";
            this.menu_filterByGPAgioi.Size = new System.Drawing.Size(228, 26);
            this.menu_filterByGPAgioi.Text = "Giỏi (3.2 - 3.6)";
            this.menu_filterByGPAgioi.Click += new System.EventHandler(this.menu_filterByGPAgioi_Click);
            // 
            // menu_filterByGPAkha
            // 
            this.menu_filterByGPAkha.Name = "menu_filterByGPAkha";
            this.menu_filterByGPAkha.Size = new System.Drawing.Size(228, 26);
            this.menu_filterByGPAkha.Text = "Khá (2.5 - 3.2)";
            this.menu_filterByGPAkha.Click += new System.EventHandler(this.menu_filterByGPAkha_Click);
            // 
            // menu_filterByGPAtb
            // 
            this.menu_filterByGPAtb.Name = "menu_filterByGPAtb";
            this.menu_filterByGPAtb.Size = new System.Drawing.Size(228, 26);
            this.menu_filterByGPAtb.Text = "Trung bình (2.0 - 2.5)";
            this.menu_filterByGPAtb.Click += new System.EventHandler(this.menu_filterByGPAtb_Click);
            // 
            // menu_filterByGPAyeu
            // 
            this.menu_filterByGPAyeu.Name = "menu_filterByGPAyeu";
            this.menu_filterByGPAyeu.Size = new System.Drawing.Size(228, 26);
            this.menu_filterByGPAyeu.Text = "Yếu (1.0 - 2.0)";
            this.menu_filterByGPAyeu.Click += new System.EventHandler(this.menu_filterByGPAyeu_Click);
            // 
            // menu_filterByGPAkem
            // 
            this.menu_filterByGPAkem.Name = "menu_filterByGPAkem";
            this.menu_filterByGPAkem.Size = new System.Drawing.Size(228, 26);
            this.menu_filterByGPAkem.Text = "Kém (0 - 1.0)";
            this.menu_filterByGPAkem.Click += new System.EventHandler(this.menu_filterByGPAkem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_findByID,
            this.toolStripLabel1,
            this.toolstr_btn_add,
            this.toolStripSeparator2,
            this.toolstr_btn_edit,
            this.toolStripSeparator3,
            this.toolstr_btn_delete,
            this.toolStripSeparator4,
            this.toolstr_btn_reload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1250, 33);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txt_findByID
            // 
            this.txt_findByID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_findByID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_findByID.Name = "txt_findByID";
            this.txt_findByID.Size = new System.Drawing.Size(170, 33);
            this.txt_findByID.TextChanged += new System.EventHandler(this.txt_findByID_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(127, 30);
            this.toolStripLabel1.Text = "Tìm theo MSSV";
            // 
            // toolstr_btn_add
            // 
            this.toolstr_btn_add.Image = ((System.Drawing.Image)(resources.GetObject("toolstr_btn_add.Image")));
            this.toolstr_btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstr_btn_add.Name = "toolstr_btn_add";
            this.toolstr_btn_add.Size = new System.Drawing.Size(77, 30);
            this.toolstr_btn_add.Text = "Thêm";
            this.toolstr_btn_add.Click += new System.EventHandler(this.toolstr_btn_add_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolstr_btn_edit
            // 
            this.toolstr_btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("toolstr_btn_edit.Image")));
            this.toolstr_btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstr_btn_edit.Name = "toolstr_btn_edit";
            this.toolstr_btn_edit.Size = new System.Drawing.Size(62, 30);
            this.toolstr_btn_edit.Text = "Sửa";
            this.toolstr_btn_edit.Click += new System.EventHandler(this.toolstr_btn_edit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // toolstr_btn_delete
            // 
            this.toolstr_btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("toolstr_btn_delete.Image")));
            this.toolstr_btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstr_btn_delete.Name = "toolstr_btn_delete";
            this.toolstr_btn_delete.Size = new System.Drawing.Size(63, 30);
            this.toolstr_btn_delete.Text = "Xóa";
            this.toolstr_btn_delete.Click += new System.EventHandler(this.toolstr_btn_delete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // toolstr_btn_reload
            // 
            this.toolstr_btn_reload.Image = ((System.Drawing.Image)(resources.GetObject("toolstr_btn_reload.Image")));
            this.toolstr_btn_reload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstr_btn_reload.Name = "toolstr_btn_reload";
            this.toolstr_btn_reload.Size = new System.Drawing.Size(86, 30);
            this.toolstr_btn_reload.Text = "Reload";
            this.toolstr_btn_reload.Click += new System.EventHandler(this.toolstr_btn_reload_Click);
            // 
            // frm_studentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 648);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grb_studentDetail);
            this.Controls.Add(this.dgv_student);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_studentManagement";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frm_studentManagement_Load);
            this.grb_studentDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_studentDetail;
        private System.Windows.Forms.Button btn_editStudent;
        private System.Windows.Forms.Label lbl_studentName;
        private System.Windows.Forms.PictureBox pic_student;
        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button btn_scoreManagement;
        private System.Windows.Forms.ToolStripMenuItem menu_addStudent;
        private System.Windows.Forms.ToolStripMenuItem menu_editStudent;
        private System.Windows.Forms.ToolStripMenuItem menu_deleteStudent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_findByID;
        private System.Windows.Forms.ToolStripMenuItem theoLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox menu_cbb_class;
        private System.Windows.Forms.ToolStripMenuItem theoKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox menu_cbb_faculty;
        private System.Windows.Forms.ToolStripComboBox menu_cbb_major;
        private System.Windows.Forms.ToolStripMenuItem theoTrạngTháiToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox menu_cbb_status;
        private System.Windows.Forms.ToolStripButton toolstr_btn_add;
        private System.Windows.Forms.ToolStripButton toolstr_btn_delete;
        private System.Windows.Forms.ToolStripButton toolstr_btn_edit;
        private System.Windows.Forms.ToolStripMenuItem theoGPAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_filterByGPAxx;
        private System.Windows.Forms.ToolStripMenuItem menu_filterByGPAgioi;
        private System.Windows.Forms.ToolStripMenuItem menu_filterByGPAkha;
        private System.Windows.Forms.ToolStripMenuItem menu_filterByGPAtb;
        private System.Windows.Forms.ToolStripMenuItem menu_filterByGPAyeu;
        private System.Windows.Forms.ToolStripMenuItem menu_filterByGPAkem;
        private System.Windows.Forms.Button btn_courseRegistration;
        private System.Windows.Forms.ToolStripMenuItem theoGiớiTínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_filterByGender_nam;
        private System.Windows.Forms.ToolStripMenuItem menu_filterByGender_nu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtFileExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhóaHọcToolStripMenuItem;
        private System.Windows.Forms.Label lbl_studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_major;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Adress;
        private System.Windows.Forms.ToolStripButton toolstr_btn_reload;
        private System.Windows.Forms.ToolStripMenuItem menu_backup;
        private System.Windows.Forms.ToolStripMenuItem menu_restore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

