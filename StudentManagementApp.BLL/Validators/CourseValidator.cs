using StudentManagementApp.DAL.Entities;
using StudentManagementApp.BLL.Validators;

namespace StudentManagementApp.BLL.Validators
{
    public class CourseValidator
    {
        public static string ValidateCourseID(string courseID)
        {
            if (string.IsNullOrWhiteSpace(courseID))
            {
                return "Mã học phần không được để trống.";
            }
            if (courseID.Length != 5)
            {
                return "Mã học phần phải có 5 ký tự.";
            }
            return null;
        }

        public static string ValidateCourse(Course course)
        {
            var validationMessages = new[]
            {
                ValidateCourseID(course.CourseID)
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
