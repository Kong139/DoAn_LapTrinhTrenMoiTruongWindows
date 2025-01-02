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

        public string GetSubjectIDByName(string subjectName)
        {
            using (var context = new StudentManagementModel())
            {
                return context.Subjects.FirstOrDefault(s => s.SubjectName == subjectName).SubjectID;
            }
        }

        public string GetSubjectNameByID(string subjectID)
        {
            using ( var context = new StudentManagementModel())
            {
                return context.Subjects.FirstOrDefault(s => s.SubjectID == subjectID)?.SubjectName;
            }
        }

        public List<Teacher> GetAllTeachers(string subjectID)
        {
            using (var db = new StudentManagementModel())
            {
                return db.Subjects
                         .Where(s => s.SubjectID == subjectID)
                         .SelectMany(s => s.Teachers)
                         .ToList();
            }
        }
    }
}
