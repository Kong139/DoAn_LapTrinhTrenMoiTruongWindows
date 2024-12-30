using System.Collections.Generic;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.DAL.Repositories
{
    public class SemesterRepository
    {
        public List<Semester> GetAll()
        {
            using (var context = new StudentManagementModel())
            {
                return context.Semesters.ToList();
            }
        }

        public int GetSemesterID(string semesterName)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Semesters.FirstOrDefault(s => s.SemesterName == semesterName).SemesterID;
            }
        }
    }
}
