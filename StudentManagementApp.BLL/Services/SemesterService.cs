using System.Collections.Generic;
using StudentManagementApp.DAL.Entities;
using StudentManagementApp.DAL.Repositories;

namespace StudentManagementApp.BLL.Services
{
    public class SemesterService
    {
        private readonly SemesterRepository semesterRepository = new SemesterRepository();

        public List<Semester> GetAll()
        {
            return semesterRepository.GetAll();
        }

        public int GetSemesterID(string semesterName)
        {
            return semesterRepository.GetSemesterID(semesterName);
        }
    }
}
