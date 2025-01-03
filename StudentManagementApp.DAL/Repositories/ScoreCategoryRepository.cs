using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.DAL.Repositories
{
    public class ScoreCategoryRepository
    {
        public List<ScoreCategory> GetAll()
        {
            using (var db = new StudentManagementModel())
            {
                return db.ScoreCategories.ToList();
            }
        }

        public ScoreCategory GetByID(string id)
        {
            using (var db = new StudentManagementModel())
            {
                return db.ScoreCategories.Find(id);
            }
        }

        public string GetIDByName(string name)
        {
            using (var db = new StudentManagementModel())
            {
                var scoreCategory = db.ScoreCategories.SingleOrDefault(x => x.ScoreCategoryName == name);
                return scoreCategory.ScoreCategoryID;
            }
        }
    }
}
