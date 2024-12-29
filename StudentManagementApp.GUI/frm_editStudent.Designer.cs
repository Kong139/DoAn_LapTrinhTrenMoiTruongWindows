namespace StudentManagementApp.GUI
{
    partial class frm_editStudent
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
            this.pic_student = new System.Windows.Forms.PictureBox();
            this.lbl_studentID = new System.Windows.Forms.Label();
            this.lbl_studentName = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_faculty = new System.Windows.Forms.Label();
            this.lbl_major = new System.Windows.Forms.Label();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_uploadPicture = new System.Windows.Forms.Button();
            this.txt_studentID = new System.Windows.Forms.TextBox();
            this.txt_studentName = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_status = new System.Windows.Forms.ComboBox();
            this.cbb_major = new System.Windows.Forms.ComboBox();
            this.cbb_faculty = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_deletePicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_student)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_student
            // 
            this.pic_student.Location = new System.Drawing.Point(21, 18);
            this.pic_student.Name = "pic_student";
            this.pic_student.Size = new System.Drawing.Size(175, 233);
            this.pic_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_student.TabIndex = 1;
            this.pic_student.TabStop = false;
            // 
            // lbl_studentID
            // 
            this.lbl_studentID.AutoSize = true;
            this.lbl_studentID.Location = new System.Drawing.Point(14, 27);
            this.lbl_studentID.Name = "lbl_studentID";
            this.lbl_studentID.Size = new System.Drawing.Size(48, 16);
            this.lbl_studentID.TabIndex = 2;
            this.lbl_studentID.Text = "MSSV:";
            // 
            // lbl_studentName
            // 
            this.lbl_studentName.AutoSize = true;
            this.lbl_studentName.Location = new System.Drawing.Point(292, 27);
            this.lbl_studentName.Name = "lbl_studentName";
            this.lbl_studentName.Size = new System.Drawing.Size(49, 16);
            this.lbl_studentName.TabIndex = 3;
            this.lbl_studentName.Text = "Họ tên:";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(14, 73);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(57, 16);
            this.lbl_gender.TabIndex = 4;
            this.lbl_gender.Text = "Giới tính:";
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Location = new System.Drawing.Point(14, 23);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(33, 16);
            this.lbl_class.TabIndex = 5;
            this.lbl_class.Text = "Lớp:";
            // 
            // lbl_faculty
            // 
            this.lbl_faculty.AutoSize = true;
            this.lbl_faculty.Location = new System.Drawing.Point(14, 75);
            this.lbl_faculty.Name = "lbl_faculty";
            this.lbl_faculty.Size = new System.Drawing.Size(41, 16);
            this.lbl_faculty.TabIndex = 6;
            this.lbl_faculty.Text = "Khoa:";
            // 
            // lbl_major
            // 
            this.lbl_major.AutoSize = true;
            this.lbl_major.Location = new System.Drawing.Point(292, 23);
            this.lbl_major.Name = "lbl_major";
            this.lbl_major.Size = new System.Drawing.Size(95, 16);
            this.lbl_major.TabIndex = 7;
            this.lbl_major.Text = "Chuyên ngành:";
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Location = new System.Drawing.Point(292, 73);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(70, 16);
            this.lbl_birthday.TabIndex = 8;
            this.lbl_birthday.Text = "Ngày sinh:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(14, 26);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(37, 16);
            this.lbl_phone.TabIndex = 9;
            this.lbl_phone.Text = "SĐT:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(14, 79);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(50, 16);
            this.lbl_address.TabIndex = 10;
            this.lbl_address.Text = "Địa chỉ:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(292, 26);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(44, 16);
            this.lbl_email.TabIndex = 11;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(292, 75);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(69, 16);
            this.lbl_status.TabIndex = 12;
            this.lbl_status.Text = "Tình trạng:";
            // 
            // btn_uploadPicture
            // 
            this.btn_uploadPicture.Location = new System.Drawing.Point(65, 270);
            this.btn_uploadPicture.Name = "btn_uploadPicture";
            this.btn_uploadPicture.Size = new System.Drawing.Size(90, 33);
            this.btn_uploadPicture.TabIndex = 13;
            this.btn_uploadPicture.Text = "Chọn ảnh";
            this.btn_uploadPicture.UseVisualStyleBackColor = true;
            this.btn_uploadPicture.Click += new System.EventHandler(this.btn_uploadPicture_Click);
            // 
            // txt_studentID
            // 
            this.txt_studentID.Location = new System.Drawing.Point(105, 24);
            this.txt_studentID.Name = "txt_studentID";
            this.txt_studentID.Size = new System.Drawing.Size(149, 22);
            this.txt_studentID.TabIndex = 14;
            // 
            // txt_studentName
            // 
            this.txt_studentName.Location = new System.Drawing.Point(459, 24);
            this.txt_studentName.Name = "txt_studentName";
            this.txt_studentName.Size = new System.Drawing.Size(223, 22);
            this.txt_studentName.TabIndex = 14;
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(105, 20);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(118, 22);
            this.txt_class.TabIndex = 14;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(459, 23);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(187, 22);
            this.txt_email.TabIndex = 14;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(105, 23);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(149, 22);
            this.txt_phone.TabIndex = 14;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(105, 76);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(261, 22);
            this.txt_address.TabIndex = 14;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(105, 71);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(57, 20);
            this.rb_nam.TabIndex = 15;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(192, 71);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(45, 20);
            this.rb_nu.TabIndex = 15;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_birthday);
            this.groupBox1.Controls.Add(this.rb_nu);
            this.groupBox1.Controls.Add(this.lbl_studentID);
            this.groupBox1.Controls.Add(this.rb_nam);
            this.groupBox1.Controls.Add(this.lbl_studentName);
            this.groupBox1.Controls.Add(this.lbl_gender);
            this.groupBox1.Controls.Add(this.lbl_birthday);
            this.groupBox1.Controls.Add(this.txt_studentID);
            this.groupBox1.Controls.Add(this.txt_studentName);
            this.groupBox1.Location = new System.Drawing.Point(212, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 110);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.CustomFormat = "dd/MM/yyyy";
            this.dtp_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_birthday.Location = new System.Drawing.Point(459, 68);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(133, 22);
            this.dtp_birthday.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_status);
            this.groupBox2.Controls.Add(this.cbb_major);
            this.groupBox2.Controls.Add(this.cbb_faculty);
            this.groupBox2.Controls.Add(this.txt_class);
            this.groupBox2.Controls.Add(this.lbl_class);
            this.groupBox2.Controls.Add(this.lbl_faculty);
            this.groupBox2.Controls.Add(this.lbl_major);
            this.groupBox2.Controls.Add(this.lbl_status);
            this.groupBox2.Location = new System.Drawing.Point(212, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 110);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // cbb_status
            // 
            this.cbb_status.FormattingEnabled = true;
            this.cbb_status.Location = new System.Drawing.Point(459, 72);
            this.cbb_status.Name = "cbb_status";
            this.cbb_status.Size = new System.Drawing.Size(133, 24);
            this.cbb_status.TabIndex = 15;
            // 
            // cbb_major
            // 
            this.cbb_major.FormattingEnabled = true;
            this.cbb_major.Location = new System.Drawing.Point(459, 20);
            this.cbb_major.Name = "cbb_major";
            this.cbb_major.Size = new System.Drawing.Size(187, 24);
            this.cbb_major.TabIndex = 15;
            // 
            // cbb_faculty
            // 
            this.cbb_faculty.FormattingEnabled = true;
            this.cbb_faculty.Location = new System.Drawing.Point(105, 72);
            this.cbb_faculty.Name = "cbb_faculty";
            this.cbb_faculty.Size = new System.Drawing.Size(167, 24);
            this.cbb_faculty.TabIndex = 15;
            this.cbb_faculty.SelectedIndexChanged += new System.EventHandler(this.cbb_faculty_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_address);
            this.groupBox3.Controls.Add(this.lbl_phone);
            this.groupBox3.Controls.Add(this.lbl_email);
            this.groupBox3.Controls.Add(this.txt_email);
            this.groupBox3.Controls.Add(this.txt_phone);
            this.groupBox3.Controls.Add(this.txt_address);
            this.groupBox3.Location = new System.Drawing.Point(212, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 110);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(729, 393);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(75, 33);
            this.btn_done.TabIndex = 19;
            this.btn_done.Text = "Xong";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(837, 393);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 33);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_deletePicture
            // 
            this.btn_deletePicture.Location = new System.Drawing.Point(65, 315);
            this.btn_deletePicture.Name = "btn_deletePicture";
            this.btn_deletePicture.Size = new System.Drawing.Size(90, 33);
            this.btn_deletePicture.TabIndex = 13;
            this.btn_deletePicture.Text = "Xóa ảnh";
            this.btn_deletePicture.UseVisualStyleBackColor = true;
            this.btn_deletePicture.Click += new System.EventHandler(this.btn_deletePicture_Click);
            // 
            // frm_editStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 454);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_deletePicture);
            this.Controls.Add(this.btn_uploadPicture);
            this.Controls.Add(this.pic_student);
            this.Name = "frm_editStudent";
            this.Text = "Sửa thông tin sinh viên";
            this.Load += new System.EventHandler(this.frm_editStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_student)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_student;
        private System.Windows.Forms.Label lbl_studentID;
        private System.Windows.Forms.Label lbl_studentName;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label lbl_faculty;
        private System.Windows.Forms.Label lbl_major;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_uploadPicture;
        private System.Windows.Forms.TextBox txt_studentID;
        private System.Windows.Forms.TextBox txt_studentName;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.ComboBox cbb_status;
        private System.Windows.Forms.ComboBox cbb_major;
        private System.Windows.Forms.ComboBox cbb_faculty;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_deletePicture;
    }
}