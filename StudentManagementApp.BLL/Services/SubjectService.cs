using System.Collections.Generic;
using StudentManagementApp.DAL.Entities;
using StudentManagementApp.DAL.Repositories;

namespace StudentManagementApp.BLL.Services
{
    public class SubjectService
    {
        private readonly SujectRepository subjectRepository = new SujectRepository();

        public List<Subject> GetAll()
        {
            return subjectRepository.GetAll();
        }

        public string GetSubjectID(string subjectName)
        {
            return subjectRepository.GetSubjectID(subjectName);
        }
    }
}