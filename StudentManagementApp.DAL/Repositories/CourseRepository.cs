using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.DAL.Repositories
{
    public class CourseRepository
    {
        public List<Course> GetAll()
        {
            using (var context = new StudentManagementModel())
            {
                return context.Courses
                              .Include(s => s.Subject)
                              .Include(s => s.Semester)
                              .Include(s => s.Teacher)
                              .ToList();
            }
        }
    }
}
