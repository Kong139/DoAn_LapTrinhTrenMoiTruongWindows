using System.Collections.Generic;
using StudentManagementApp.DAL.Entities;
using StudentManagementApp.DAL.Repositories;

namespace StudentManagementApp.BLL.Services
{
    public class ScoreCategoryService
    {
        private readonly ScoreCategoryRepository scoreCategoryRepository = new ScoreCategoryRepository();
        public List<ScoreCategory> GetAll()
        {
            return scoreCategoryRepository.GetAll();
        }

        public ScoreCategory GetByID(string id)
        {
            return scoreCategoryRepository.GetByID(id);
        }

        public string GetIDByName(string name)
        {
            return scoreCategoryRepository.GetIDByName(name);
        }
    }
}
