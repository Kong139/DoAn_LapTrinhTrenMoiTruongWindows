namespace StudentManagementApp.GUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.col_studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 709);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Xóa sinh viên";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(56, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Xem điểm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(56, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sửa thông tin";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MSSV";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_studentID,
            this.col_studentName,
            this.col_birthday,
            this.col_class,
            this.col_GPA,
            this.col_faculty,
            this.col_major,
            this.col_status,
            this.col_email,
            this.col_phone,
            this.col_Adress});
            this.dataGridView1.Location = new System.Drawing.Point(228, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1132, 702);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1372, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.chỉnhSửaToolStripMenuItem.Text = "Thao tác";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.viewToolStripMenuItem.Text = "Lọc";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // col_studentID
            // 
            this.col_studentID.HeaderText = "MSSV";
            this.col_studentID.MinimumWidth = 6;
            this.col_studentID.Name = "col_studentID";
            this.col_studentID.ReadOnly = true;
            this.col_studentID.Width = 125;
            // 
            // col_studentName
            // 
            this.col_studentName.HeaderText = "Họ tên";
            this.col_studentName.MinimumWidth = 6;
            this.col_studentName.Name = "col_studentName";
            this.col_studentName.ReadOnly = true;
            this.col_studentName.Width = 125;
            // 
            // col_birthday
            // 
            this.col_birthday.HeaderText = "Ngày sinh";
            this.col_birthday.MinimumWidth = 6;
            this.col_birthday.Name = "col_birthday";
            this.col_birthday.ReadOnly = true;
            this.col_birthday.Width = 125;
            // 
            // col_class
            // 
            this.col_class.HeaderText = "Lớp";
            this.col_class.MinimumWidth = 6;
            this.col_class.Name = "col_class";
            this.col_class.ReadOnly = true;
            this.col_class.Width = 125;
            // 
            // col_GPA
            // 
            this.col_GPA.HeaderText = "GPA";
            this.col_GPA.MinimumWidth = 6;
            this.col_GPA.Name = "col_GPA";
            this.col_GPA.ReadOnly = true;
            this.col_GPA.Width = 125;
            // 
            // col_faculty
            // 
            this.col_faculty.HeaderText = "Khoa";
            this.col_faculty.MinimumWidth = 6;
            this.col_faculty.Name = "col_faculty";
            this.col_faculty.ReadOnly = true;
            this.col_faculty.Width = 125;
            // 
            // col_major
            // 
            this.col_major.HeaderText = "Chuyên ngành";
            this.col_major.MinimumWidth = 6;
            this.col_major.Name = "col_major";
            this.col_major.ReadOnly = true;
            this.col_major.Width = 125;
            // 
            // col_status
            // 
            this.col_status.HeaderText = "Trạng thái";
            this.col_status.MinimumWidth = 6;
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            this.col_status.Width = 125;
            // 
            // col_email
            // 
            this.col_email.HeaderText = "Email";
            this.col_email.MinimumWidth = 6;
            this.col_email.Name = "col_email";
            this.col_email.ReadOnly = true;
            this.col_email.Width = 125;
            // 
            // col_phone
            // 
            this.col_phone.HeaderText = "SĐT";
            this.col_phone.MinimumWidth = 6;
            this.col_phone.Name = "col_phone";
            this.col_phone.ReadOnly = true;
            this.col_phone.Width = 125;
            // 
            // col_Adress
            // 
            this.col_Adress.HeaderText = "Địa chỉ";
            this.col_Adress.MinimumWidth = 6;
            this.col_Adress.Name = "col_Adress";
            this.col_Adress.ReadOnly = true;
            this.col_Adress.Width = 125;
            // 
            // frm_studentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 769);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_studentManagement";
            this.Text = "Quản lý sinh viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_major;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Adress;
    }
}

