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

        public void Add(Student student)
        {
            using (var context = new StudentManagementModel())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public void Update(Student student)
        {
            using (var context = new StudentManagementModel())
            {
                context.Students.AddOrUpdate(student);
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

        public List<Student> FilterByID(string searchText)
        {
            return GetAll().Where(s => s.StudentID.Contains(searchText)).ToList();
        }

        public List<Student> GetAllMale()
        {
            return GetAll().Where(s => s.Gender == true).ToList();
        }

        public List<Student> GetAllFemale()
        {
            return GetAll().Where(s => s.Gender == false).ToList();
        }

        public List<Student> GetAllByClass(string className)
        {
            return GetAll().Where(s => s.Class == className).ToList();
        }
    }
}