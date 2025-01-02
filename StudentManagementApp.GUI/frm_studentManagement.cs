using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StudentManagementApp.BLL;
using StudentManagementApp.BLL.Services;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.GUI
{
    public partial class frm_studentManagement : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();
        private readonly StatusService statusService = new StatusService();
        private readonly Utilities utilities = new Utilities();

        public frm_studentManagement()
        {
            InitializeComponent();

            // Chỉnh sửa giao diện cho Form
            UIConfig.ConfigureForm(this);

            // Chỉnh sửa giao diện cho DataGridView
            UIConfig.ConfigureDataGridView(dgv_student);

            // Chỉnh sửa giao diện cho MenuStrip
            UIConfig.ConfigureMenuStrip(menuStrip1);

            // Chỉnh sửa giao diện cho ToolStrip
            UIConfig.ConfigureToolStrip(toolStrip1);

            // Chỉnh sửa giao diện cho Button
            UIConfig.ConfigureButton(btn_editStudent);
            UIConfig.ConfigureButton(btn_scoreManagement);
            UIConfig.ConfigureButton(btn_subjectRegistration);

            // Chỉnh sửa giao diện cho Label
            UIConfig.ConfigureLabel(lbl_studentID);
            UIConfig.ConfigureLabel(lbl_studentName);

            // Chỉnh sửa giao diện cho PictureBox
            UIConfig.ConfigurePictureBox(pic_student);
        }

        // Hàm Load Form
        private void frm_studentManagement_Load(object sender, EventArgs e)
        {
            try
            {
                ReloadData();
                FillClassCombobox();
                FillFacultyCombobox();
                FillStatusCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillStatusCombobox()
        {
            var listStatus = statusService.GetAll();
            menu_cbb_status.Items.Clear();
            foreach (var item in listStatus)
            {
                menu_cbb_status.Items.Add(item.StatusName);
            }
            menu_cbb_status.Items.Insert(0, "Chọn trạng thái");
            menu_cbb_status.SelectedIndex = 0;
        }

        private void FillFacultyCombobox()
        {
            var listFaculties = facultyService.GetAll();
            menu_cbb_faculty.Items.Clear();
            foreach (var item in listFaculties)
            {
                menu_cbb_faculty.Items.Add(item.FacultyName);
            }
            menu_cbb_faculty.Items.Insert(0, "Chọn khoa");
            menu_cbb_faculty.SelectedIndex = 0;
        }

        private void FillClassCombobox()
        {
            List<string> listClasses = utilities.GetAllClasses();
            menu_cbb_class.Items.Clear();
            foreach (var item in listClasses)
            {
                menu_cbb_class.Items.Add(item);
            }
            menu_cbb_class.Items.Insert(0, "Chọn lớp");
            menu_cbb_class.SelectedIndex = 0;
        }

        // Hàm binding gridView từ list sinh viên
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
                dgv_student.Rows[index].Cells[6].Value = item.Faculty?.FacultyName; // Sử dụng ?. để tránh lỗi NullReferenceException
                dgv_student.Rows[index].Cells[7].Value = item.Major?.MajorName;
                dgv_student.Rows[index].Cells[8].Value = item.Status?.StatusName;
                dgv_student.Rows[index].Cells[9].Value = item.Email;
                dgv_student.Rows[index].Cells[10].Value = item.Phone;
                dgv_student.Rows[index].Cells[11].Value = item.Address;
            }
        }

        // Load lại dữ liệu dataGridView
        private void ReloadData()
        {
            var listStudents = studentService.GetAll();
            BindGrid(listStudents);
            FillClassCombobox();
            FillFacultyCombobox();
            FillStatusCombobox();
            dgv_student.ClearSelection();
            grb_studentDetail.Visible = false;
        }

        // Hiển thị ảnh và thông tin sinh viên khi click vào dòng
        private void dgv_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào dòng hợp lệ không
            if (e.RowIndex >= 0)
            {
                grb_studentDetail.Visible = true;
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dgv_student.Rows[e.RowIndex];

                // Lấy thông tin từ các cột
                string studentID = selectedRow.Cells[0].Value?.ToString();
                string studentName = selectedRow.Cells[1].Value?.ToString();

                // Hiển thị thông tin lên các control
                lbl_studentID.Text = $"{studentID}";
                lbl_studentName.Text = $"{studentName}";

                // Lấy dữ liệu ảnh từ cơ sở dữ liệu
                byte[] avatarData = studentService.GetStudentAvatar(studentID);

                // Hiển thị ảnh nếu có
                if (avatarData != null && avatarData.Length > 0)
                {
                    using (var ms = new System.IO.MemoryStream(avatarData))
                    {
                        pic_student.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pic_student.Image = null; // Hiển thị ảnh trống nếu không có ảnh
                }
            }
        }

        private void btn_editStudent_Click(object sender, EventArgs e)
        {
            if (dgv_student.SelectedRows.Count > 0)
            {
                string studentID = dgv_student.SelectedRows[0].Cells[0].Value.ToString();
                frm_editStudent frm = new frm_editStudent(studentID);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    ReloadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menu_editStudent_Click(object sender, EventArgs e)
        {
            if (dgv_student.SelectedRows.Count > 0)
            {
                string studentID = dgv_student.SelectedRows[0].Cells[0].Value.ToString();
                frm_editStudent frm = new frm_editStudent(studentID);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    ReloadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolstr_btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_student.SelectedRows.Count > 0)
            {
                string studentID = dgv_student.SelectedRows[0].Cells[0].Value.ToString();
                frm_editStudent frm = new frm_editStudent(studentID);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    ReloadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menu_deleteStudent_Click(object sender, EventArgs e)
        {
            if (dgv_student.SelectedRows.Count > 0)
            {
                string studentID = dgv_student.SelectedRows[0].Cells[0].Value.ToString();
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên {studentID} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    studentService.Delete(studentID);
                    ReloadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolstr_btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_student.SelectedRows.Count > 0)
            {
                string studentID = dgv_student.SelectedRows[0].Cells[0].Value.ToString();
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên {studentID} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    studentService.Delete(studentID);
                    ReloadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menu_addStudent_Click(object sender, EventArgs e)
        {
            frm_addStudent frm = new frm_addStudent();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                ReloadData();
            }
        }

        private void toolstr_btn_add_Click(object sender, EventArgs e)
        {
            frm_addStudent frm = new frm_addStudent();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                ReloadData();
            }
        }

        private void quảnLýKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_courseManagement frm = new frm_courseManagement();
            frm.ShowDialog();
        }

        private void txt_findByID_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_findByID.Text.Trim();
            BindGrid(studentService.FilterByID(searchText));
        }

        private void menu_filterByGender_nam_Click(object sender, EventArgs e)
        {
            BindGrid(studentService.GetAllMale());
        }

        private void menu_filterByGender_nu_Click(object sender, EventArgs e)
        {
            BindGrid(studentService.GetAllFemale());
        }

        private void toolstr_btn_reload_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void menu_cbb_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menu_cbb_class.SelectedIndex != 0)
            {
                // Lấy lớp được chọn từ ComboBox
                string selectedClass = menu_cbb_class.SelectedItem.ToString();

                // Lọc danh sách học sinh theo lớp được chọn
                BindGrid(studentService.GetAllByClass(selectedClass));
            }
        }

        private void menu_cbb_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menu_cbb_faculty.SelectedIndex != 0)
            {
                // Bind các chuyên ngành của khoa được chọn vào ComboBox Major
                int selectedFacultyID = facultyService.FindIDByName(menu_cbb_faculty.SelectedItem.ToString());
                var listMajors = majorService.GetAllByFaculty(selectedFacultyID);
                menu_cbb_major.Items.Clear();
                foreach (var item in listMajors)
                {
                    menu_cbb_major.Items.Add(item.MajorName);
                }
                menu_cbb_major.Items.Insert(0, "Chọn chuyên ngành");
                menu_cbb_major.SelectedIndex = 0;

                // Lọc danh sách học sinh theo khoa được chọn
                BindGrid(studentService.GetAllByFaculty(facultyService.FindIDByName(menu_cbb_faculty.SelectedItem.ToString())));
            }
        }

        private void menu_cbb_major_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menu_cbb_major.SelectedIndex != 0)
            {
                // Lọc danh sách học sinh theo chuyên ngành được chọn
                BindGrid(studentService.GetAllByMajor(majorService.FindIDByName(menu_cbb_major.SelectedItem.ToString())));
            }
        }

        private void menu_cbb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menu_cbb_status.SelectedIndex != 0)
            {
                // Lọc danh sách học sinh theo trạng thái được chọn
                BindGrid(studentService.GetAllByStatus(statusService.FindIDByName(menu_cbb_status.SelectedItem.ToString())));
            }
        }

        private void btn_scoreManagement_Click(object sender, EventArgs e)
        {
            if (dgv_student.SelectedRows.Count > 0)
            {
                string studentID = dgv_student.SelectedRows[0].Cells[0].Value.ToString();
                frm_scoreManagement frm = new frm_scoreManagement(studentID);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    ReloadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần quản lý điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
