using System.Collections.Generic;
using StudentManagementApp.DAL.Entities;
using StudentManagementApp.DAL.Repositories;
using StudentManagementApp.DAL.Services;

namespace StudentManagementApp.BLL
{
    public class StudentService
    {
        private readonly StudentRepository studentRepository = new StudentRepository();
        private readonly ScoreRepository scoreRepository = new ScoreRepository();
        private readonly RegistrationRepository registrationRepository = new RegistrationRepository();

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

        public void Add(Student student)
        {
            studentRepository.Add(student);
        }

        public void Update(Student student)
        {
            studentRepository.Update(student);
        }

        public void Delete(string studentID)
        {
            // Xóa tất cả các điểm của sinh viên
            scoreRepository.DeleteByStudentID(studentID);

            // Xóa tất cả các đăng ký môn học của sinh viên
            registrationRepository.DeleteByStudentID(studentID);

            // Xóa sinh viên
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

        public List<Student> FilterByID(string searchText)
        {
            return studentRepository.FilterByID(searchText);
        }

        public List<Student> GetAllMale()
        {
            return studentRepository.GetAllMale();
        }

        public List<Student> GetAllFemale()
        {
            return studentRepository.GetAllFemale();
        }

        public List<Student> GetAllByClass(string className)
        {
            return studentRepository.GetAllByClass(className);
        }

        public List<Student> GetAllByFaculty(int facultyID)
        {
            return studentRepository.GetAllByFaculty(facultyID);
        }

        public List<Student> GetAllByMajor(int majorID)
        {
            return studentRepository.GetAllByMajor(majorID);
        }

        public List<Student> GetAllByStatus(int statusID)
        {
            return studentRepository.GetAllByStatus(statusID);
        }
    }
}