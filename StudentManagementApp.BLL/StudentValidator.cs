using System;
using System.Text.RegularExpressions;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.BLL.Validators
{
    public class StudentValidator
    {
        public static string ValidateStudentID(string studentID)
        {
            if (string.IsNullOrWhiteSpace(studentID))
            {
                return "Mã sinh viên không được để trống.";
            }
            if (studentID.Length != 10)
            {
                return "Mã sinh viên phải có 10 ký tự.";
            }
            return null;
        }

        public static string ValidateStudentName(string studentName)
        {
            if (string.IsNullOrWhiteSpace(studentName))
            {
                return "Tên sinh viên không được để trống.";
            }
            if (studentName.Length > 50)
            {
                return "Tên sinh viên tối đa 50 ký tự.";
            }
            return null;
        }

        public static string ValidateClass(string studentClass)
        {
            if (string.IsNullOrWhiteSpace(studentClass))
            {
                return "Lớp không được để trống.";
            }
            if (studentClass.Length > 10)
            {
                return "Lớp tối đa 10 ký tự.";
            }
            return null;
        }

        public static string ValidatePhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return "Số điện thoại không được để trống.";
            }
            var regex = new Regex(@"^\d{10,11}$");
            if (!regex.IsMatch(phone))
            {
                return "Số điện thoại phải có 10-11 chữ số.";
            }
            return null;
        }

        public static string ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return "Email không được để trống.";
            }
            if (email.Length > 50)
            {
                return "Email tối đa 50 ký tự.";
            }
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regex.IsMatch(email))
            {
                return "Email không hợp lệ.";
            }
            return null;
        }

        public static string ValidateAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                return "Địa chỉ không được để trống.";
            }
            if (address.Length > 100)
            {
                return "Địa chỉ tối đa 100 ký tự.";
            }
            return null;
        }

        public static string ValidateBirthday(DateTime birthday)
        {
            if (birthday > DateTime.Now)
            {
                return "Ngày sinh không hợp lệ.";
            }
            return null;
        }

        public static string ValidateStudent(Student student)
        {
            var validationMessages = new[]
            {
                ValidateStudentID(student.StudentID),
                ValidateStudentName(student.StudentName),
                ValidateClass(student.Class),
                ValidatePhone(student.Phone),
                ValidateEmail(student.Email),
                ValidateAddress(student.Address),
                ValidateBirthday(student.Birthday)
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