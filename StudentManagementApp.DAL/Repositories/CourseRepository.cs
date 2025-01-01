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

        public Course GetByID(string id)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Courses
                              .Include(s => s.Subject)
                              .Include(s => s.Semester)
                              .Include(s => s.Teacher)
                              .SingleOrDefault(s => s.CourseID == id);
            }
        }

        public void Delete(string id)
        {
            using (var context = new StudentManagementModel())
            {
                var course = context.Courses.Find(id);
                context.Courses.Remove(course);
                context.SaveChanges();
            }
        }

        public void Update(Course course)
        {
            using (var context = new StudentManagementModel())
            {
                context.Entry(course).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Add(Course course)
        {
            using (var context = new StudentManagementModel())
            {
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }

        public string GetSubjectID(string courseID)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Courses
                              .SingleOrDefault(s => s.CourseID == courseID)
                              .SubjectID;
            }
        }

        public int GetTeacherID(string courseID)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Courses
                              .SingleOrDefault(s => s.CourseID == courseID)
                              .TeacherID;
            }
        }

        public int GetSemesterID(string courseID)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Courses
                              .SingleOrDefault(s => s.CourseID == courseID)
                              .SemesterID;
            }
        }

        public bool IsCourseIDExist(string id)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Courses.Any(s => s.CourseID == id);
            }
        }
    }
}
