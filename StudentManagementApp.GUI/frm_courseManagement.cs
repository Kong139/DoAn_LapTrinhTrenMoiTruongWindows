using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StudentManagementApp.BLL.Services;
using StudentManagementApp.BLL.Validators;
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
            listSubjects.Insert(0, new Subject()
            {
                SubjectID = "",
                SubjectName = "Chọn môn học"
            });
            this.cbb_subject.DataSource = listSubjects;
            this.cbb_subject.DisplayMember = "SubjectName";
            this.cbb_subject.ValueMember = "SubjectID";
        }

        private void FillSemesterCombobox(List<Semester> listSemesters)
        {
            listSemesters.Insert(0, new Semester()
            {
                SemesterID = 0,
                SemesterName = "Chọn học kỳ"
            });
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

        private void ReloadData()
        {
            var listCourses = courseService.GetAll();
            BindGrid(listCourses);
            txt_courseID.Text = "";
            txt_schedule.Text = "";
            cbb_subject.SelectedIndex = 0;
            cbb_teacher.SelectedIndex = 0;
            cbb_semester.SelectedIndex = 0;
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
                cbb_subject.SelectedValue = courseService.GetSubjectID(selectedRow.Cells[0].Value?.ToString());
                cbb_teacher.SelectedValue = courseService.GetTeacherID(selectedRow.Cells[0].Value?.ToString());
                cbb_semester.SelectedValue = courseService.GetSemesterID(selectedRow.Cells[0].Value?.ToString());
                txt_schedule.Text = selectedRow.Cells[4].Value?.ToString();
            }
        }

        private void cbb_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Teacher> listTeachers = subjectService.GetAllTeachers(cbb_subject.SelectedValue.ToString());
            listTeachers.Insert(0, new Teacher()
            {
                TeacherID = 0,
                TeacherName = "Chọn giáo viên"
            });
            cbb_teacher.DataSource = listTeachers;
            cbb_teacher.DisplayMember = "TeacherName";
            cbb_teacher.ValueMember = "TeacherID";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_course.SelectedRows.Count > 0)
                {
                    // Lấy học phần từ cơ sở dữ liệu
                    var course = courseService.GetByID(dgv_course.SelectedRows[0].Cells[0].Value.ToString());
                    if (course == null)
                    {
                        MessageBox.Show("Khóa học không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Lưu lại ID hiện tại
                    var currentCourseID = course.CourseID;

                    // Cập nhật thông tin học phần
                    course.CourseID = txt_courseID.Text;
                    course.SubjectID = cbb_subject.SelectedValue.ToString();
                    course.TeacherID = (int)cbb_teacher.SelectedValue;
                    course.SemesterID = (int)cbb_semester.SelectedValue;
                    course.Schedule = txt_schedule.Text;

                    // Kiểm tra giá trị nhập
                    var validationMessage = CourseValidator.ValidateCourse(course);
                    if (validationMessage != null)
                    {
                        MessageBox.Show(validationMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (cbb_semester.SelectedIndex == 0)
                    {
                        MessageBox.Show("Vui lòng chọn học kỳ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (cbb_subject.SelectedIndex == 0)
                    {
                        MessageBox.Show("Vui lòng chọn môn học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (cbb_teacher.SelectedIndex == 0)
                    {
                        MessageBox.Show("Vui lòng chọn giảng viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra xem ID học phần đã tồn tại chưa (chỉ kiểm tra nếu ID mới khác với ID hiện tại)
                    if (currentCourseID != course.CourseID && courseService.IsCourseIDExist(course.CourseID))
                    {
                        MessageBox.Show("Mã học phần đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cập nhật học phần hiện tại
                    courseService.Update(course);

                    MessageBox.Show("Cập nhật thông tin học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadData();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn học phần cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var course = new Course()
                {
                    CourseID = txt_courseID.Text,
                    SubjectID = cbb_subject.SelectedValue.ToString(),
                    TeacherID = (int)cbb_teacher.SelectedValue,
                    SemesterID = (int)cbb_semester.SelectedValue,
                    Schedule = txt_schedule.Text
                };

                // Kiểm tra giá trị nhập
                var validationMessage = CourseValidator.ValidateCourse(course);
                if (validationMessage != null)
                {
                    MessageBox.Show(validationMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbb_semester.SelectedIndex == 0)
                {
                    MessageBox.Show("Vui lòng chọn học kỳ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbb_subject.SelectedIndex == 0)
                {
                    MessageBox.Show("Vui lòng chọn môn học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbb_teacher.SelectedIndex == 0)
                {
                    MessageBox.Show("Vui lòng chọn giảng viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra xem ID học phần đã tồn tại chưa
                if (courseService.IsCourseIDExist(course.CourseID))
                {
                    MessageBox.Show("Mã học phần đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm sinh viên mới
                courseService.Add(course);

                MessageBox.Show("Thêm học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_course.SelectedRows.Count > 0)
                {
                    string courseID = dgv_course.SelectedRows[0].Cells[0].Value.ToString();
                    if (MessageBox.Show($"Bạn có chắc chắn muốn xóa học phần {courseID} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        courseService.Delete(courseID);
                        ReloadData();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn học phần cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Có sinh viên đã đăng ký học phần này, không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ textbox txt_find
                string searchKeyword = txt_find.Text.Trim();

                // Nếu không có từ khóa tìm kiếm, tải lại toàn bộ danh sách học phần
                if (string.IsNullOrWhiteSpace(searchKeyword))
                {
                    ReloadData();
                    return;
                }

                // Tìm các học phần có ID chứa chuỗi tìm kiếm
                var matchingCourses = courseService.GetAll()
                                                   .Where(c => c.CourseID.Contains(searchKeyword))
                                                   .ToList();

                if (matchingCourses.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy học phần nào với từ khóa vừa nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Hiển thị các học phần tìm thấy lên DataGridView
                BindGrid(matchingCourses);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
