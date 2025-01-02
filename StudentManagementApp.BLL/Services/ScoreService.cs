using System.Collections.Generic;
using StudentManagementApp.DAL.Entities;
using StudentManagementApp.DAL.Repositories;

namespace StudentManagementApp.BLL.Services
{
    public class ScoreService
    {
        private readonly ScoreRepository scoreRepository = new ScoreRepository();

        public List<Score> GetAllByStudentID(string studentID)
        {
            return scoreRepository.GetAllByStudentID(studentID);
        }

        public Score GetScore(string studentID, string subjectID, string scoreCategoryID)
        {
            return scoreRepository.GetScore(studentID, subjectID, scoreCategoryID);
        }

        public void Add(Score score)
        {
            scoreRepository.Add(score);
        }

        public void Update(Score score)
        {
            scoreRepository.Update(score);
        }

        public List<Score> FilterBySubjectID(List<Score> scores, string subjectID)
        {
            return scoreRepository.FilterBySubjectID(scores, subjectID);
        }
    }
}
