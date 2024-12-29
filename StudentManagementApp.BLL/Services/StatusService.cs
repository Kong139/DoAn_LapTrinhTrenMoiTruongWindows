using System.Collections.Generic;
using StudentManagementApp.DAL.Entities;
using StudentManagementApp.DAL.Repositories;

namespace StudentManagementApp.BLL.Services
{
    public class StatusService
    {
        private readonly StatusRepository statusRepository = new StatusRepository();

        public List<Status> GetAll()
        {
            return statusRepository.GetAll();
        }
    }
}