using System.Collections.Generic;
using Escola_Bd_Api.Models;

public interface IAnswerService
{
    Task<IEnumerable<Answer>> GetAllAnswers();
    Task<Answer> GetAnswerById(int id);
    Task<Answer> AddAnswer(Answer answer);
    Task<Answer> UpdateAnswer(Answer answer);
    Task<bool> DeleteAnswer(int id);
}
