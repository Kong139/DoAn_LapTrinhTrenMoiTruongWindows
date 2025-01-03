using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementApp.DAL.Entities;

namespace StudentManagementApp.DAL.Repositories
{
    public class ScoreRepository
    {
        public List<Score> GetAllByStudentID(string studentID)
        {
            using (var db = new StudentManagementModel())
            {
                return db.Scores
                       .Where(s => s.StudentID == studentID)
                       .Include(s => s.Subject)
                       .Include(s => s.ScoreCategory)
                       .ToList();
            }
        }

        public Score GetScore(string studentID, string subjectID, string scoreCategoryID)
        {
            using (var db = new StudentManagementModel())
            {
                return db.Scores
                       .Where(s => s.StudentID == studentID && s.SubjectID == subjectID && s.ScoreCategoryID == scoreCategoryID)
                       .Include(s => s.Subject)
                       .Include(s => s.ScoreCategory)
                       .FirstOrDefault();
            }
        }

        public List<Score> FilterBySubjectID(List<Score> scores, string subjectID)
        {
            using (var db = new StudentManagementModel())
            {
                return scores.Where(s => s.SubjectID.Contains(subjectID)).ToList();
            }
        }

        public void Add(Score score)
        {
            using (var db = new StudentManagementModel())
            {
                db.Scores.Add(score);
                db.SaveChanges();
            }
        }

        public void Update(Score score)
        {
            using (var db = new StudentManagementModel())
            {
                db.Entry(score).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteByStudentID(string studentID)
        {
            using (var db = new StudentManagementModel())
            {
                var scores = db.Scores.Where(s => s.StudentID == studentID);
                db.Scores.RemoveRange(scores);
                db.SaveChanges();
            }
        }
    }
}
