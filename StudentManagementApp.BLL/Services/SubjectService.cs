using System.Collections.Generic;
using System.Net.NetworkInformation;
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

        public string GetSubjectIDByName(string subjectName)
        {
            return subjectRepository.GetSubjectIDByName(subjectName);
        }

        public string GetSubjectNameByID(string subjectID)
        {
            return subjectRepository.GetSubjectNameByID(subjectID);
        }

        public List<Teacher> GetAllTeachers(string subjectID)
        {
            return subjectRepository.GetAllTeachers(subjectID);
        }

        public bool IsSubjectExist(string subjectID)
        {
            return subjectRepository.IsSubjectExist(subjectID);
        }
    }
}