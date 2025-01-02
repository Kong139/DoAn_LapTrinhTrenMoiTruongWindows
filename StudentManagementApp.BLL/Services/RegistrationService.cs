using System.Collections.Generic;
using StudentManagementApp.DAL.Entities;
using StudentManagementApp.DAL.Repositories;

namespace StudentManagementApp.BLL.Services
{
    public class RegistrationService
    {
        private RegistrationRepository registrationRepository = new RegistrationRepository();

        public List<Registration> GetAllByStudentID(string studentID)
        {
            return registrationRepository.GetAllByStudentID(studentID);
        }

        public void Add(Registration registration)
        {
            registrationRepository.Add(registration);
        }
    }
}
