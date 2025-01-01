using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementApp.DAL.Entities;
using StudentManagementApp.DAL.Services;

namespace StudentManagementApp.BLL
{
    public class Utilities
    {
        private readonly StudentRepository studentRepository = new StudentRepository();

        public List<string> GetAllClasses()
        {
            // Sử dụng HashSet để loại bỏ các lớp trùng lặp
            HashSet<string> classes = new HashSet<string>();

            var students = studentRepository.GetAll();
            foreach (var student in students)
            {
                if (!string.IsNullOrEmpty(student.Class))
                {
                    classes.Add(student.Class);
                }
            }

            return classes.ToList();
        }
    }
}
