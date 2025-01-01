using System.Collections.Generic;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.DAL.Repositories
{
    public class FacultyRepository
    {
        public List<Faculty> GetAll()
        {
            using (var context = new StudentManagementModel())
            {
                return context.Faculties.ToList();
            }
        }

        public int FindIDByName(string facultyName)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Faculties.FirstOrDefault(f => f.FacultyName == facultyName).FacultyID;
            }
        }
    }
}