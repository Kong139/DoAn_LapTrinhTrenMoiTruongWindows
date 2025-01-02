using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.BLL.Validators
{
    public class SubjectValidator
    {
        public static string ValidateSubjectName(string subjectName)
        {
            if (string.IsNullOrWhiteSpace(subjectName))
            {
                return "Tên môn học không được để trống.";
            }
            if (subjectName.Length > 50)
            {
                return "Tên môn học tối đa 50 ký tự.";
            }
            return null;
        }
        public static string ValidateCredit(int credit)
        {
            if (credit < 0)
            {
                return "Số tín chỉ không được nhỏ hơn 0.";
            }
            if (credit > 3)
            {
                return "Số tín chỉ không được lớn hơn 3.";
            }
            return null;
        }
        public static string ValidateSubject(Subject subject)
        {
            var validationMessages = new[]
            {
                ValidateSubjectName(subject.SubjectName),
                ValidateCredit(subject.CreditHours)
            };
            foreach (var message in validationMessages)
            {
                if (message != null)
                {
                    return message; // Trả về thông báo lỗi đầu tiên gặp phải
                }
            }
            return null;
        }
    }
}
