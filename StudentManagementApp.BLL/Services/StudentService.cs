using System.Collections.Generic;
using StudentManagementApp.DAL.Entities;
using StudentManagementApp.DAL.Services;

namespace StudentManagementApp.BLL
{
    public class StudentService
    {
        private readonly StudentRepository studentRepository = new StudentRepository();

        public List<Student> GetAll()
        {
            return studentRepository.GetAll();
        }

        public List<Student> GetAllHasNoMajor()
        {
            return studentRepository.GetAllHasNoMajor();
        }

        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            return studentRepository.GetAllHasNoMajor(facultyID);
        }

        public Student FindById(string studentId)
        {
            return studentRepository.FindById(studentId);
        }

        public void InsertUpdate(Student s)
        {
            studentRepository.InsertUpdate(s);
        }

        public void Delete(string studentID)
        {
            studentRepository.Delete(studentID);
        }

        public byte[] GetStudentAvatar(string studentID)
        {
            return studentRepository.GetStudentAvatar(studentID);
        }

        public bool IsStudentIDExists(string studentID)
        {
            return studentRepository.IsStudentIDExists(studentID);
        }
    }
}