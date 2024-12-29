using System.Collections.Generic;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.BLL
{
    public class MajorService
    {
        public List<Major> GetAllByFaculty(int facultyID)
        {
            StudentManagementModel context = new StudentManagementModel();
            return context.Majors.Where(m => m.FacultyID == facultyID).ToList();
        }
    }
}
