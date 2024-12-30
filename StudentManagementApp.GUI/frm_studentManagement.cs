﻿using System;
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
                var listStudents = studentService.GetAll();
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
