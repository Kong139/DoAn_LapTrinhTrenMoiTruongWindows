using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.BLL
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            StudentManagementModel context = new StudentManagementModel();
            return context.Students.ToList();
        }

        public List<Student> GetAllHasNoMajor()
        {
            StudentManagementModel context = new StudentManagementModel();
            return context.Students.Where(p => p.MajorID == null).ToList();
        }

        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            StudentManagementModel context = new StudentManagementModel();
            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }

        public Student FindById(string studentId)
        {
            StudentManagementModel context = new StudentManagementModel();
            return context.Students.FirstOrDefault(p => p.StudentID == studentId);
        }

        public void InsertUpdate(Student s)
        {
            StudentManagementModel context = new StudentManagementModel();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }

        public void Delete(string studentID)
        {
            StudentManagementModel context = new StudentManagementModel();
            var s = context.Students.FirstOrDefault(p => p.StudentID == studentID);
            if (s != null)
            {
                context.Students.Remove(s);
                context.SaveChanges();
            }
        }
    }
}
