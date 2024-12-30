using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StudentManagementApp.BLL.Services;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.GUI
{
    public partial class frm_courseManagement : Form
    {
        private readonly CourseService courseService = new CourseService();
        private readonly SemesterService semesterService = new SemesterService();
        private readonly SubjectService subjectService = new SubjectService();

        public frm_courseManagement()
        {
            InitializeComponent();

            // Chỉnh sửa giao diện cho Form
            UIConfig.ConfigureForm(this);

            // Chỉnh sửa giao diện cho DataGridView
            UIConfig.ConfigureDataGridView(dgv_course);

            // Chỉnh sửa giao diện cho Groupbox
            UIConfig.ConfigureGroupBox(groupBox1);

            // Chỉnh sửa giao diện cho Button
            UIConfig.ConfigureButton(btn_add);
            UIConfig.ConfigureButton(btn_edit);
            UIConfig.ConfigureButton(btn_delete);
            UIConfig.ConfigureButton(btn_find);

            // Chỉnh sửa giao diện cho Label
            UIConfig.ConfigureLabel(lbl_find);
        }

        private void frm_courseManagement_Load(object sender, EventArgs e)
        {
            try
            {
                var listCourses = courseService.GetAll();
                var listSemesters = semesterService.GetAll();
                var listSubjects = subjectService.GetAll();
                FillSemesterCombobox(listSemesters);
                FillSubjectCombobox(listSubjects);
                BindGrid(listCourses);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillSubjectCombobox(List<Subject> listSubjects)
        {
            this.cbb_subject.DataSource = listSubjects;
            this.cbb_subject.DisplayMember = "SubjectName";
            this.cbb_subject.ValueMember = "SubjectID";
        }

        private void FillSemesterCombobox(List<Semester> listSemesters)
        {
            this.cbb_semester.DataSource = listSemesters;
            this.cbb_semester.DisplayMember = "SemesterName";
            this.cbb_semester.ValueMember = "SemesterID";
        }

        private void BindGrid(List<Course> listCourses)
        {
            dgv_course.Rows.Clear();
            foreach (var item in listCourses)
            {
                int index = dgv_course.Rows.Add();
                dgv_course.Rows[index].Cells[0].Value = item.CourseID;
                dgv_course.Rows[index].Cells[1].Value = item.Subject.SubjectName;
                dgv_course.Rows[index].Cells[2].Value = item.Teacher.TeacherName;
                dgv_course.Rows[index].Cells[3].Value = item.Semester.SemesterName;
                dgv_course.Rows[index].Cells[4].Value = item.Schedule;
                dgv_course.Rows[index].Cells[5].Value = item.CurrentStudents;
            }
        }

        private void dgv_course_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào dòng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dgv_course.Rows[e.RowIndex];

                // Hiển thị thông tin lên các control
                txt_courseID.Text = selectedRow.Cells[0].Value?.ToString();
                cbb_subject.SelectedValue = subjectService.GetSubjectID(selectedRow.Cells[1].Value?.ToString());
                txt_teacherName.Text = selectedRow.Cells[2].Value?.ToString();
                cbb_semester.SelectedValue = semesterService.GetSemesterID(selectedRow.Cells[3].Value?.ToString());
                txt_schedule.Text = selectedRow.Cells[4].Value?.ToString();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
