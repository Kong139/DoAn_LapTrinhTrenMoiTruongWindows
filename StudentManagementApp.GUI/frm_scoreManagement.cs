using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StudentManagementApp.BLL;
using StudentManagementApp.BLL.Services;
using StudentManagementApp.BLL.Validators;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.GUI
{
    public partial class frm_scoreManagement : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly SubjectService subjectService = new SubjectService();
        private readonly ScoreService scoreService = new ScoreService();
        private readonly ScoreCategoryService scoreCategoryService = new ScoreCategoryService();
        string studentID;
        public frm_scoreManagement(string studentID)
        {
            InitializeComponent();
            this.studentID = studentID;

            // Cấu hình giao diện cho form
            UIConfig.ConfigureForm(this);
            UIConfig.ConfigureDataGridView(dgv_scoreManagement);
            UIConfig.ConfigureGroupBox(groupBox1);
            UIConfig.ConfigureGroupBox(groupBox2);
            UIConfig.ConfigureButton(btn_editScoreValue);
            UIConfig.ConfigureLabel(lbl_findSubjectID);
        }

        private void frm_scoreManagement_Load(object sender, EventArgs e)
        {
            var listScores = scoreService.GetAllByStudentID(studentID);
            BindGrid(listScores);
            FillScoreCategoryCombobox();
            txt_subjectName.Enabled = false;
            lbl_studentID.Text = studentID;
            lbl_studentName.Text = studentService.FindById(studentID).StudentName;
        }

        private void FillScoreCategoryCombobox()
        {
            var listScoreCategories = scoreCategoryService.GetAll();
            listScoreCategories.Insert(0, new ScoreCategory { ScoreCategoryID = "", ScoreCategoryName = "Chọn cột điểm" });
            cbb_scoreCategory.DataSource = listScoreCategories;
            cbb_scoreCategory.DisplayMember = "ScoreCategoryName";
            cbb_scoreCategory.ValueMember = "ScoreCategoryID";
            cbb_scoreCategory.SelectedIndex = 0;
        }

        private void BindGrid(List<Score> listScores)
        {
            dgv_scoreManagement.Rows.Clear();
            foreach (Score score in listScores)
            {
                int index = dgv_scoreManagement.Rows.Add();
                dgv_scoreManagement.Rows[index].Cells[0].Value = score.SubjectID;
                dgv_scoreManagement.Rows[index].Cells[1].Value = score.Subject.SubjectName;
                dgv_scoreManagement.Rows[index].Cells[2].Value = score.ScoreCategory.ScoreCategoryName;
                dgv_scoreManagement.Rows[index].Cells[3].Value = score.ScoreValue;
                dgv_scoreManagement.ClearSelection();
            }
        }

        private void dgv_scoreManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_scoreManagement.Rows[e.RowIndex];
                txt_subjectID.Text = row.Cells[0].Value.ToString();
                txt_subjectName.Text = row.Cells[1].Value.ToString();
                cbb_scoreCategory.SelectedValue = scoreCategoryService.GetIDByName(row.Cells[2].Value.ToString());
                txt_scoreValue.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void btn_editScoreValue_Click(object sender, EventArgs e)
        {
            var listScores = scoreService.GetAllByStudentID(studentID);
            bool isRegistered = false;

            foreach (var item in listScores)
            {
                if (item.SubjectID == txt_subjectID.Text)
                {
                    isRegistered = true;
                    break;
                }
            }

            if (isRegistered)
            {
                var score = scoreService.GetScore(studentID, txt_subjectID.Text, cbb_scoreCategory.SelectedValue.ToString());
                score.ScoreValue = double.Parse(txt_scoreValue.Text);

                // Kiểm tra giá trị nhập
                var validationMessage = ScoreValidator.ValidateScore(score);
                if (validationMessage != null)
                {
                    MessageBox.Show(validationMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật điểm
                scoreService.Update(score);
                MessageBox.Show("Cập nhật điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGrid(scoreService.GetAllByStudentID(studentID));
            }
            else
            {
                MessageBox.Show("Sinh viên chưa đăng kí môn học này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_findSubjectID_TextChanged(object sender, EventArgs e)
        {
            var listScores = scoreService.FilterBySubjectID(scoreService.GetAllByStudentID(studentID), txt_findSubjectID.Text);
            BindGrid(listScores);
        }

        private void txt_subjectID_TextChanged(object sender, EventArgs e)
        {
            txt_subjectName.Text = subjectService.GetSubjectNameByID(txt_subjectID.Text);
        }
    }
}
