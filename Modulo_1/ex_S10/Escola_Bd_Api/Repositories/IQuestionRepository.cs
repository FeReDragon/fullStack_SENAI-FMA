using System.Collections.Generic;
using Escola_Bd_Api.Models;

public interface IQuestionRepository
{
    Task<IEnumerable<Question>> GetAllQuestions();
    Task<Question> GetQuestionById(int id);
    Task<Question> AddQuestion(Question question);
    Task<Question> UpdateQuestion(Question question);
    Task<bool> DeleteQuestion(int id);
}
