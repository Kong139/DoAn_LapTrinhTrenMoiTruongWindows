using System.Collections.Generic;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.DAL.Repositories
{
    public class MajorRepository
    {
        public List<Major> GetAllByFaculty(int facultyID)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Majors.Where(m => m.FacultyID == facultyID).ToList();
            }
        }
    }
}