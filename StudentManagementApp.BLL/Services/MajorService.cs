using System.Collections.Generic;
using StudentManagementApp.DAL.Entities;
using StudentManagementApp.DAL.Repositories;

namespace StudentManagementApp.BLL.Services
{
    public class MajorService
    {
        private readonly MajorRepository majorRepository = new MajorRepository();

        public List<Major> GetAllByFaculty(int facultyID)
        {
            return majorRepository.GetAllByFaculty(facultyID);
        }

        public int FindIDByName(string majorName)
        {
            return majorRepository.FindIDByName(majorName);
        }
    }
}