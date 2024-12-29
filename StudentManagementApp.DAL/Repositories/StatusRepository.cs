using System.Collections.Generic;
using System.Linq;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.DAL.Repositories
{
    public class StatusRepository
    {
        public List<Status> GetAll()
        {
            using (var context = new StudentManagementModel())
            {
                return context.Status.ToList();
            }
        }
    }
}