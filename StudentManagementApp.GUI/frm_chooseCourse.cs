using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementApp.BLL;
using StudentManagementApp.BLL.Services;
using StudentManagementApp.BLL.Validators;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.GUI
{
    public partial class frm_chooseCourse : Form
    {
        private readonly CourseService courseService = new CourseService();
        private readonly RegistrationService registrationService = new RegistrationService();
        private readonly ScoreService scoreService = new ScoreService();
        private string studentID;
        private string subjectID;

        public frm_chooseCourse(string studentID, string subjectID)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.subjectID = subjectID;

            UIConfig.ConfigureForm(this);
            UIConfig.ConfigureDataGridView(dgv_course);
            UIConfig.ConfigureButton(btn_register);
        }

        private void frm_chooseCourse_Load(object sender, EventArgs e)
        {
            var listCourses = courseService.GetAllBySubjectID(subjectID);
            foreach (var item in listCourses)
            {
                if(item.Semester.StartDate > DateTime.Now)
                {
                    int index = dgv_course.Rows.Add();
                    dgv_course.Rows[index].Cells[0].Value = item.CourseID;
                    dgv_course.Rows[index].Cells[1].Value = item.SubjectID;
                    dgv_course.Rows[index].Cells[2].Value = item.Subject.SubjectName;
                    dgv_course.Rows[index].Cells[3].Value = item.Teacher.TeacherName;
                    dgv_course.Rows[index].Cells[4].Value = item.Semester.SemesterName;
                    dgv_course.Rows[index].Cells[5].Value = item.Schedule;
                    dgv_course.Rows[index].Cells[6].Value = item.CurrentStudents;
                }
            }
            dgv_course.ClearSelection();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if(dgv_course.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một học phần để đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đăng ký học phần mới
            var courseID = dgv_course.SelectedRows[0].Cells[0].Value.ToString();
            var registration = new Registration
            {
                StudentID = studentID,
                CourseID = courseID,
                RegistrationDate = DateTime.Now
            };
            registrationService.Add(registration);

            // Cập nhật số lượng sinh viên hiện tại của học phần
            var course = courseService.GetByID(courseID);
            course.CurrentStudents++;
            courseService.Update(course);

            // Thêm các cột điểm cho học phần vào bảng điểm
            var scoreCC = new Score
            {
                StudentID = studentID,
                SubjectID = course.SubjectID,
                ScoreCategoryID = "CC",
                ScoreValue = null
            };
            var scoreGK = new Score
            {
                StudentID = studentID,
                SubjectID = course.SubjectID,
                ScoreCategoryID = "GK",
                ScoreValue = null
            };
            var scoreCK = new Score
            {
                StudentID = studentID,
                SubjectID = course.SubjectID,
                ScoreCategoryID = "CK",
                ScoreValue = null
            };
            scoreService.Add(scoreCC);
            scoreService.Add(scoreGK);
            scoreService.Add(scoreCK);

            MessageBox.Show("Đăng ký học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
