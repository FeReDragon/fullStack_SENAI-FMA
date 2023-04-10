using System.Collections.Generic;
using Escola_Bd_Api.Models;

public interface IQuizRepository
{
    Task<IEnumerable<Quiz>> GetAllQuizzes();
    Task<Quiz> GetQuizById(int id);
    Task<Quiz> AddQuiz(Quiz quiz);
    Task<Quiz> UpdateQuiz(Quiz quiz);
    Task<bool> DeleteQuiz(int id);
}
