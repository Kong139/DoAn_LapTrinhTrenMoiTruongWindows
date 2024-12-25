using System.Collections.Generic;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.BLL
{
    public class FacultyService
    {
        public List<Faculty> GetAll()
        {
            StudentManagementModel context = new StudentManagementModel();
            return context.Faculties.ToList();
        }
    }
}
