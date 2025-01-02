using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.DAL.Repositories
{
    public class RegistrationRepository
    {
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
    }
}
