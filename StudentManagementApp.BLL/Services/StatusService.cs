using System.Collections.Generic;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.BLL
{
    public class StatusService
    {
        public List<Status> GetAll()
        {
            StudentManagementModel context = new StudentManagementModel();
            return context.Status.ToList();
        }
    }
}
