using System.Collections.Generic;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.DAL.Repositories
{
    public class SujectRepository
    {
        public List<Subject> GetAll()
        {
            using (var context = new StudentManagementModel())
            {
                return context.Subjects.ToList();
            }
        }

        public string GetSubjectID(string subjectName)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Subjects.FirstOrDefault(s => s.SubjectName == subjectName).SubjectID;
            }
        }
    }
}
