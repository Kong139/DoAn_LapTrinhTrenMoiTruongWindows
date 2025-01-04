using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StudentManagementApp.BLL;
using StudentManagementApp.BLL.Services;
using StudentManagementApp.BLL.Validators;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.GUI
{
    public partial class frm_scoreManagement : Form
    {
        public event EventHandler GPAUpdated;
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

            // Đảo lại vị trí của cột giữa kỳ và cuối kỳ vì mặc định nó sắp xếp theo chữ cái đầu (CC, CK, GK)
            ScoreCategory s1 = listScoreCategories[2];
            listScoreCategories[2] = listScoreCategories[3];
            listScoreCategories[3] = s1;

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
                if (txt_scoreValue.Text == "")
                {
                    score.ScoreValue = null;
                }
                else
                {
                    score.ScoreValue = double.Parse(txt_scoreValue.Text);
                }

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

                // Cập nhật GPA
                UpdateStudentGPA(studentID);

                // Kích hoạt sự kiện GPAUpdated
                GPAUpdated?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Sinh viên chưa đăng kí môn học này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateStudentGPA(string studentID)
        {
            // Lấy tất cả các điểm của sinh viên theo ID
            var scores = scoreService.GetAllByStudentID(studentID);

            // Dictionary để lưu điểm tổng của từng môn
            var subjectTotalScores = new Dictionary<string, double>();
            var subjectTotalWeights = new Dictionary<string, double>();

            // Duyệt qua từng điểm của sinh viên
            foreach (var score in scores)
            {
                // Bỏ qua các điểm có giá trị null
                if (!score.ScoreValue.HasValue)
                {
                    continue;
                }

                // Lấy thông tin loại điểm dựa vào ScoreCategoryID
                var scoreCategory = scoreCategoryService.GetByID(score.ScoreCategoryID);

                // Tính trọng số của điểm (ScoreValue * Weight)
                double weightedScore = score.ScoreValue.Value * scoreCategory.Weight;

                // Kiểm tra nếu môn học đã có trong từ điển chưa
                if (!subjectTotalScores.ContainsKey(score.SubjectID))
                {
                    subjectTotalScores[score.SubjectID] = 0;
                    subjectTotalWeights[score.SubjectID] = 0;
                }

                // Cộng dồn điểm và trọng số vào từ điển
                subjectTotalScores[score.SubjectID] += weightedScore;
                subjectTotalWeights[score.SubjectID] += scoreCategory.Weight;
            }

            double totalWeightedScore = 0;
            double totalWeightedCreditHours = 0;

            // Tính điểm tổng của từng môn (trung bình các điểm thành phần)
            foreach (var subjectID in subjectTotalScores.Keys)
            {
                // Lấy thông tin môn học dựa vào SubjectID
                var subject = subjectService.GetByID(subjectID);

                // Kiểm tra nếu môn học có bất kỳ cột điểm nào bị null
                var subjectScores = scores.Where(s => s.SubjectID == subjectID).ToList();
                if (subjectScores.Any(s => !s.ScoreValue.HasValue))
                {
                    continue;
                }

                // Tính điểm trung bình của môn học
                double averageScore = subjectTotalScores[subjectID] / subjectTotalWeights[subjectID];

                // Quy đổi điểm từ thang điểm 10 sang thang điểm 4
                double gpaScore = ConvertToGPA(averageScore);

                // Bỏ qua các điểm F
                if (gpaScore == 0)
                {
                    continue;
                }

                // Tính tổng điểm có trọng số (GPA Score * CreditHours)
                totalWeightedScore += gpaScore * subject.CreditHours;

                // Tính tổng số tín chỉ có trọng số (CreditHours)
                totalWeightedCreditHours += subject.CreditHours;
            }

            // Tính GPA bằng cách chia tổng điểm có trọng số cho tổng số tín chỉ có trọng số
            double gpa = totalWeightedCreditHours == 0 ? 0 : totalWeightedScore / totalWeightedCreditHours;

            // Làm tròn GPA đến 2 chữ số thập phân
            gpa = Math.Round(gpa, 2);

            // Lấy thông tin sinh viên
            var student = studentService.FindById(studentID);

            // Cập nhật GPA cho sinh viên
            student.GPA = gpa;

            // Lưu thay đổi vào cơ sở dữ liệu
            studentService.Update(student);
        }

        private double ConvertToGPA(double score)
        {
            if (score >= 8.5)
                return 4.0;
            else if (score >= 7.0)
                return 3.0;
            else if (score >= 5.5)
                return 2.0;
            else if (score >= 4.0)
                return 1.0;
            else
                return 0.0;
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
