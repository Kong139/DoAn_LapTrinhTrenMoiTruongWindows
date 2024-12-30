using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StudentManagementApp.BLL;
using StudentManagementApp.BLL.Services;
using StudentManagementApp.BLL.Validators;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.GUI
{
    public partial class frm_editStudent : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();
        private readonly StatusService statusService = new StatusService();
        private string studentID;
        private string avatarFilePath = null;

        public frm_editStudent(string ID)
        {
            InitializeComponent();
            studentID = ID;

            // Chỉnh sửa giao diện cho Form
            UIConfig.ConfigureForm(this);

            // Chỉnh sửa giao diện cho Groupbox
            UIConfig.ConfigureGroupBox(groupBox1);
            UIConfig.ConfigureGroupBox(groupBox2);
            UIConfig.ConfigureGroupBox(groupBox3);

            // Chỉnh sửa giao diện cho PictureBox
            UIConfig.ConfigurePictureBox(pic_student);

            // Chỉnh sửa giao diện cho button
            UIConfig.ConfigureButton(btn_uploadPicture);
            UIConfig.ConfigureButton(btn_deletePicture);
            UIConfig.ConfigureButton(btn_done);
            UIConfig.ConfigureButton(btn_cancel);
        }

        private void frm_editStudent_Load(object sender, EventArgs e)
        {
            // Lấy sinh viên từ cơ sở dữ liệu
            var student = studentService.FindById(studentID);

            // Lấy danh sách khoa, ngành, trạng thái
            var listFacultys = facultyService.GetAll();
            FillFalcultyCombobox(listFacultys);

            var listMajors = majorService.GetAllByFaculty(student.FacultyID);
            FillMajorCombobox(listMajors);

            var listStatus = statusService.GetAll();
            FillStatusCombobox(listStatus);

            // Binding dữ liệu sinh viên lên form
            if (student.Avatar != null && student.Avatar.Length > 0)
            {
                using (var ms = new System.IO.MemoryStream(student.Avatar))
                {
                    pic_student.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pic_student.Image = null; // Hiển thị ảnh trống nếu không có ảnh
            }

            txt_studentID.Text = student.StudentID;
            txt_studentName.Text = student.StudentName;
            if (student.Gender == true)
                rb_nam.Checked = true;
            else
                rb_nu.Checked = true;

            dtp_birthday.Value = student.Birthday;
            txt_class.Text = student.Class;
            cbb_faculty.SelectedValue = student.FacultyID;
            if (student.MajorID != null)
                cbb_major.SelectedValue = student.MajorID;

            cbb_status.SelectedValue = student.StatusID;
            txt_phone.Text = student.Phone;
            txt_email.Text = student.Email;
            txt_address.Text = student.Address;
        }

        //Hàm binding list dữ liệu khoa vào combobox có tên hiện thị là tên khoa, giá trị là Mã khoa
        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            this.cbb_faculty.DataSource = listFacultys;
            this.cbb_faculty.DisplayMember = "FacultyName";
            this.cbb_faculty.ValueMember = "FacultyID";
        }

        // Hàm binding danh sách Major vào ComboBox
        private void FillMajorCombobox(List<Major> listMajors)
        {
            listMajors.Insert(0, new Major());
            this.cbb_major.DataSource = listMajors;
            this.cbb_major.DisplayMember = "MajorName";
            this.cbb_major.ValueMember = "MajorID";
        }

        // Hàm binding danh sách Status vào ComboBox
        private void FillStatusCombobox(List<Status> listStatus)
        {
            listStatus.Insert(0, new Status());
            this.cbb_status.DataSource = listStatus;
            this.cbb_status.DisplayMember = "StatusName";
            this.cbb_status.ValueMember = "StatusID";
        }

        // Bind lại danh sách Major khi chọn khoa
        private void cbb_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy FacultyID của khoa được chọn
            if (cbb_faculty.SelectedValue is int selectedFacultyID)
            {
                // Lấy danh sách các ngành học theo khoa
                var listMajors = majorService.GetAllByFaculty(selectedFacultyID);

                // Cập nhật ComboBox ngành học
                FillMajorCombobox(listMajors);
            }
        }

        private void btn_uploadPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    avatarFilePath = openFileDialog.FileName;
                    pic_student.Image = Image.FromFile(avatarFilePath);
                }
            }
        }

        private void btn_deletePicture_Click(object sender, EventArgs e)
        {
            pic_student.Image = null;
            avatarFilePath = null;
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy sinh viên từ cơ sở dữ liệu
                var student = studentService.FindById(studentID);
                if (student == null)
                {
                    MessageBox.Show("Sinh viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lưu lại MSSV hiện tại
                var currentStudentID = student.StudentID;

                // Cập nhật thông tin sinh viên
                student.StudentID = txt_studentID.Text;
                student.StudentName = txt_studentName.Text;
                student.Gender = rb_nam.Checked;
                student.Birthday = dtp_birthday.Value;
                student.Class = txt_class.Text;
                student.FacultyID = (int)cbb_faculty.SelectedValue;
                student.MajorID = cbb_major.SelectedValue as int?;
                student.StatusID = (int)cbb_status.SelectedValue;
                student.Phone = txt_phone.Text;
                student.Email = txt_email.Text;
                student.Address = txt_address.Text;

                // Kiểm tra nếu có ảnh mới được upload
                if (!string.IsNullOrEmpty(avatarFilePath))
                {
                    student.Avatar = System.IO.File.ReadAllBytes(avatarFilePath);
                }
                else
                {
                    student.Avatar = null;
                }

                // Kiểm tra giá trị nhập
                var validationMessage = StudentValidator.ValidateStudent(student);
                if (validationMessage != null)
                {
                    MessageBox.Show(validationMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra xem MSSV đã tồn tại chưa (chỉ kiểm tra nếu MSSV mới khác với MSSV hiện tại)
                if (currentStudentID != student.StudentID && studentService.IsStudentIDExists(student.StudentID))
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nếu MSSV thay đổi, xóa sinh viên cũ và thêm sinh viên mới
                if (currentStudentID != student.StudentID)
                {
                    // Xóa sinh viên cũ
                    studentService.Delete(currentStudentID);

                    // Thêm sinh viên mới
                    studentService.InsertUpdate(student);
                }
                else
                {
                    // Cập nhật sinh viên hiện tại
                    studentService.InsertUpdate(student);
                }

                MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
