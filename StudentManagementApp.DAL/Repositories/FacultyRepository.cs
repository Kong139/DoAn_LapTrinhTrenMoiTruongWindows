using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    }
}