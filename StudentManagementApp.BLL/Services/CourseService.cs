using System.Collections.Generic;
using StudentManagementApp.DAL.Entities;
using StudentManagementApp.DAL.Repositories;

namespace StudentManagementApp.BLL.Services
{
    public class CourseService
    {
        private readonly CourseRepository courseRepository = new CourseRepository();

        public List<Course> GetAll()
        {
            return courseRepository.GetAll();
        }

        public List<Course> GetAllBySubjectID(string subjectID)
        {
            return courseRepository.GetAllBySubjectID(subjectID);
        }

        public Course GetByID(string id)
        {
            return courseRepository.GetByID(id);
        }

        public void Delete(string id)
        {
            courseRepository.Delete(id);
        }

        public void Update(Course course)
        {
            courseRepository.Update(course);
        }

        public void Add(Course course)
        {
            courseRepository.Add(course);
        }

        public string GetSubjectID(string courseID)
        {
            return courseRepository.GetSubjectID(courseID);
        }

        public int GetTeacherID(string courseID)
        {
            return courseRepository.GetTeacherID(courseID);
        }

        public int GetSemesterID(string courseID)
        {
            return courseRepository.GetSemesterID(courseID);
        }

        public bool IsCourseIDExist(string courseID)
        {
            return courseRepository.IsCourseIDExist(courseID);
        }
    }
}
