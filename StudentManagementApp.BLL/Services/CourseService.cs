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

    }
}
