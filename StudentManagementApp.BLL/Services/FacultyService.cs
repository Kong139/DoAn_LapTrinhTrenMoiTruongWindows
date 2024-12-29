using System.Collections.Generic;
using StudentManagementApp.DAL.Entities;
using StudentManagementApp.DAL.Repositories;

namespace StudentManagementApp.BLL.Services
{
    public class FacultyService
    {
        private readonly FacultyRepository facultyRepository = new FacultyRepository();

        public List<Faculty> GetAll()
        {
            return facultyRepository.GetAll();
        }
    }
}