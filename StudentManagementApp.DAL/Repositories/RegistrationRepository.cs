using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.DAL.Repositories
{
    public class RegistrationRepository
    {
        private readonly CourseRepository courseRepository = new CourseRepository();

        public List<Registration> GetAllByStudentID(string studentID)
        {
            using (var db = new StudentManagementModel())
            {
                return db.Registrations
                         .Where(r => r.StudentID == studentID)
                         .Include(r => r.Course)
                         .Include(r => r.Course.Subject)
                         .Include(r => r.Course.Teacher)
                         .Include(r => r.Course.Semester)
                         .ToList();
            }
        }

        public void Add(Registration registration)
        {
            using (var db = new StudentManagementModel())
            {
                db.Registrations.Add(registration);
                db.SaveChanges();
            }
        }

        public void DeleteByStudentID(string studentID)
        {
            using (var db = new StudentManagementModel())
            {
                var registrations = db.Registrations.Where(r => r.StudentID == studentID);
                foreach (var registration in registrations)
                {
                    // Giảm số lượng sinh viên hiện tại trong khóa học
                    var course = courseRepository.GetByID(registration.CourseID);
                    if (course != null)
                    {
                        course.CurrentStudents--;
                        courseRepository.Update(course);
                    }
                }
                // Xóa tất cả các đăng ký của sinh viên
                db.Registrations.RemoveRange(registrations);
                db.SaveChanges();
            }
        }
    }
}
