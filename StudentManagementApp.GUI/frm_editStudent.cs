using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StudentManagementApp.BLL;
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
        private string avatarFilePath = string.Empty;

        public frm_editStudent(string studentID)
        {
            InitializeComponent();

            this.studentID = studentID;

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
        }

        private void frm_editStudent_Load(object sender, EventArgs e)
        {
            // Lấy danh sách khoa, ngành, trạng thái
            var listFacultys = facultyService.GetAll();
            FillFalcultyCombobox(listFacultys);

            var listMajors = majorService.GetAllByFaculty(studentService.FindById(studentID).FacultyID);
            FillMajorCombobox(listMajors);

            var listStatus = statusService.GetAll();
            FillStatusCombobox(listStatus);

            // Binding dữ liệu sinh viên lên form
            if (studentService.FindById(studentID).Avatar != null)
                pic_student.Image = Image.FromFile(studentService.FindById(studentID).Avatar);
            txt_studentID.Text = studentService.FindById(studentID).StudentID;
            txt_studentName.Text = studentService.FindById(studentID).StudentName;
            if (studentService.FindById(studentID).Gender == true)
                rb_nam.Checked = true;
            else
                rb_nu.Checked = true;
            dtp_birthday.Value = studentService.FindById(studentID).Birthday;
            txt_class.Text = studentService.FindById(studentID).Class;
            cbb_faculty.SelectedValue = studentService.FindById(studentID).FacultyID;
            if (studentService.FindById(studentID).MajorID != null)
                cbb_major.SelectedValue = studentService.FindById(studentID).MajorID;
            cbb_status.SelectedValue = studentService.FindById(studentID).StatusID;
            txt_phone.Text = studentService.FindById(studentID).Phone;
            txt_email.Text = studentService.FindById(studentID).Email;
            txt_address.Text = studentService.FindById(studentID).Address;
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
    }
}
