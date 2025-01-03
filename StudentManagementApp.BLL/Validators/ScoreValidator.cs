using System.Linq;
using System.Text.RegularExpressions;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.BLL.Validators
{
    public class ScoreValidator
    {
        public static string ValidateScoreValue(double? scoreValue)
        {
            if (scoreValue < 0 || scoreValue > 10)
            {
                return "Điểm phải nằm trong khoảng từ 0 đến 10";
            }
            return null;
        }

        public static string ValidateScore(Score score)
        {
            var validationMessages = new[]
            {
                ValidateScoreValue(score.ScoreValue)
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
