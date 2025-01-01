using System.Linq;
using System.Text.RegularExpressions;
using StudentManagementApp.DAL.Entities;

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


        public static string ValidateSchedule(string schedule)
        {
            // Định nghĩa pattern cho ngày trong tuần và tiết học
            string dayPattern = @"Thứ [2-7CN]";
            string periodPattern = @"Tiết (\d+)-(\d+)";

            // Tạo regex pattern tổng thể
            string fullPattern = $@"^{dayPattern}(, {dayPattern})*, {periodPattern}$";

            // Kiểm tra format tổng thể
            if (!Regex.IsMatch(schedule, fullPattern))
            {
                return "Lịch học không đúng định dạng. Ví dụ đúng: 'Thứ 2, Thứ 3, Tiết 1-3'";
            }

            // Tách ngày và tiết học
            var parts = schedule.Split(',');
            var days = parts.Take(parts.Length - 1).Select(d => d.Trim()).ToList();
            var periods = parts.Last().Trim();

            // Kiểm tra ngày hợp lệ
            foreach (var day in days)
            {
                if (!Regex.IsMatch(day, dayPattern))
                {
                    return $"Ngày '{day}' không hợp lệ. Ngày hợp lệ phải là 'Thứ 2' đến 'Chủ Nhật'.";
                }
            }

            // Kiểm tra tiết học hợp lệ
            var periodMatch = Regex.Match(periods, periodPattern);
            if (periodMatch.Success)
            {
                int startPeriod = int.Parse(periodMatch.Groups[1].Value);
                int endPeriod = int.Parse(periodMatch.Groups[2].Value);

                if (startPeriod < 1 || endPeriod > 15 || startPeriod >= endPeriod)
                {
                    return "Tiết học phải từ 1-15 và tiết bắt đầu phải nhỏ hơn tiết kết thúc.";
                }
            }
            else
            {
                return "Lịch học không đúng định dạng tiết học. Ví dụ đúng: 'Thứ 2, Thứ 3, Tiết 1-3'";
            }

            return null;
        }

        public static string ValidateCourse(Course course)
        {
            var validationMessages = new[]
            {
                ValidateCourseID(course.CourseID),
                ValidateSchedule(course.Schedule)
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
