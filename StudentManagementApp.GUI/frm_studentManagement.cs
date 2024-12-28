using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StudentManagementApp.BLL;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.GUI
{
    public partial class frm_studentManagement : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();

        public frm_studentManagement()
        {
            InitializeComponent();

            // Cấu hình cho Form
            UIConfig.ConfigureForm(this);

            // Cấu hình cho DataGridView
            UIConfig.ConfigureDataGridView(dgv_student);

            // Cấu hình cho MenuStrip
            UIConfig.ConfigureMenuStrip(menuStrip1);

            // Cấu hình cho ToolStrip
            UIConfig.ConfigureToolStrip(toolStrip1);

            // Cấu hình cho Button
            UIConfig.ConfigureButton(btn_editStudent);
            UIConfig.ConfigureButton(btn_scoreManagement);
            UIConfig.ConfigureButton(btn_subjectRegistration);

            // Cấu hình cho Label
            UIConfig.ConfigureLabel(lbl_studentID);
            UIConfig.ConfigureLabel(lbl_studentName);
        }

        //Hàm Load Form
        private void frm_studentManagement_Load(object sender, EventArgs e)
        {
            try
            {
                var listStudents = studentService.GetAll();
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hàm binding gridView từ list sinh viên
        private void BindGrid(List<Student> listStudent)
        {
            dgv_student.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgv_student.Rows.Add();
                dgv_student.Rows[index].Cells[0].Value = item.StudentID;
                dgv_student.Rows[index].Cells[1].Value = item.StudentName;
                dgv_student.Rows[index].Cells[2].Value = item.Gender ? "Nam" : "Nữ";
                dgv_student.Rows[index].Cells[3].Value = item.Birthday.ToString("dd/MM/yyyy");
                dgv_student.Rows[index].Cells[4].Value = item.Class;
                dgv_student.Rows[index].Cells[5].Value = item.GPA + "";
                dgv_student.Rows[index].Cells[6].Value = item.Faculty.FacultyName;
                if (item.MajorID != null)
                    dgv_student.Rows[index].Cells[7].Value = item.Major.MajorName;
                dgv_student.Rows[index].Cells[8].Value = item.Status.StatusName;
                dgv_student.Rows[index].Cells[9].Value = item.Email;
                dgv_student.Rows[index].Cells[10].Value = item.Phone;
                dgv_student.Rows[index].Cells[11].Value = item.Address;
            }
        }

        //Hiển thị ảnh và thông tin sinh viên khi click vào dòng
        private void dgv_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào dòng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dgv_student.Rows[e.RowIndex];

                // Lấy thông tin từ các cột
                string studentID = selectedRow.Cells[0].Value?.ToString();
                string studentName = selectedRow.Cells[1].Value?.ToString();
                string studentImagePath = studentService.GetStudentImagePath(studentID);

                // Hiển thị thông tin lên các control
                lbl_studentID.Text = $"{studentID}";
                lbl_studentName.Text = $"{studentName}";

                // Hiển thị ảnh nếu có
                if (!string.IsNullOrEmpty(studentImagePath) && System.IO.File.Exists(studentImagePath))
                {
                    pictureBox_student.Image = Image.FromFile(studentImagePath);
                }
                else
                {
                    pictureBox_student.Image = null; // Hiển thị ảnh trống nếu không có ảnh
                }
            }
        }

        private void btn_editStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
