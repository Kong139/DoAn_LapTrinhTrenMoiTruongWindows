using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.DAL.Services
{
    public class StudentRepository
    {
        public List<Student> GetAll()
        {
            using (var context = new StudentManagementModel())
            {
                return context.Students
                              .Include(s => s.Faculty)
                              .Include(s => s.Major)
                              .Include(s => s.Status)
                              .ToList();
            }
        }

        public List<Student> GetAllHasNoMajor()
        {
            using (var context = new StudentManagementModel())
            {
                return context.Students.Where(p => p.MajorID == null).ToList();
            }
        }

        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
            }
        }

        public Student FindById(string studentId)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Students.FirstOrDefault(p => p.StudentID == studentId);
            }
        }

        public void InsertUpdate(Student s)
        {
            using (var context = new StudentManagementModel())
            {
                context.Students.AddOrUpdate(s);
                context.SaveChanges();
            }
        }

        public void Delete(string studentID)
        {
            using (var context = new StudentManagementModel())
            {
                var s = context.Students.FirstOrDefault(p => p.StudentID == studentID);
                if (s != null)
                {
                    context.Students.Remove(s);
                    context.SaveChanges();
                }
            }
        }

        public byte[] GetStudentAvatar(string studentID)
        {
            using (var context = new StudentManagementModel())
            {
                var student = context.Students.FirstOrDefault(p => p.StudentID == studentID);
                return student?.Avatar;
            }
        }

        public bool IsStudentIDExists(string studentID)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Students.Any(s => s.StudentID == studentID);
            }
        }
    }
}