using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StudentManagementApp.BLL;
using StudentManagementApp.BLL.Services;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.GUI
{
    public partial class frm_courseRegistration : Form
    {
        private readonly RegistrationService registrationService = new RegistrationService();
        private readonly StudentService studentService = new StudentService();
        private readonly SubjectService subjectService = new SubjectService();
        private string studentID;
        public frm_courseRegistration(string studentID)
        {
            InitializeComponent();
            this.studentID = studentID;

            UIConfig.ConfigureForm(this);
            UIConfig.ConfigureGroupBox(groupBox1);
            UIConfig.ConfigureDataGridView(dgv_courseRegistered);
            UIConfig.ConfigureLabel(lbl_studentID);
            UIConfig.ConfigureLabel(lbl_studentName);
        }

        private void frm_courseRegistration_Load(object sender, EventArgs e)
        {
            lbl_studentID.Text = studentID;
            lbl_studentName.Text = studentService.FindById(studentID).StudentName;

            var listRegisteredCourses = registrationService.GetAllByStudentID(studentID);
            BindGrid(listRegisteredCourses);
        }

        private void BindGrid(List<Registration> listRegisteredCourses)
        {
            dgv_courseRegistered.Rows.Clear();
            foreach (var item in listRegisteredCourses)
            {
                int index = dgv_courseRegistered.Rows.Add();
                dgv_courseRegistered.Rows[index].Cells[0].Value = item.CourseID;
                dgv_courseRegistered.Rows[index].Cells[1].Value = item.Course.SubjectID;
                dgv_courseRegistered.Rows[index].Cells[2].Value = item.Course.Subject.SubjectName;
                dgv_courseRegistered.Rows[index].Cells[3].Value = item.Course.Teacher.TeacherName;
                dgv_courseRegistered.Rows[index].Cells[4].Value = item.Course.Semester.SemesterName;
            }
            dgv_courseRegistered.ClearSelection();
        }

        private void btn_findCourse_Click(object sender, EventArgs e)
        {
            if (!subjectService.IsSubjectExist(txt_findCourse.Text))
            {
                MessageBox.Show("Không tìm thấy học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var listRegisteredCourses = registrationService.GetAllByStudentID(studentID);
            foreach (var item in listRegisteredCourses)
            {
                if (item.Course.SubjectID == txt_findCourse.Text)
                {
                    MessageBox.Show("Học phần đã được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            frm_chooseCourse frm = new frm_chooseCourse(studentID, txt_findCourse.Text);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                listRegisteredCourses = registrationService.GetAllByStudentID(studentID);
                BindGrid(listRegisteredCourses);
            }
        }
    }
}
