using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;

public class QuestionService : IQuestionService
{
    private readonly IQuestionRepository _repository;

    public QuestionService(IQuestionRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<Question>> GetAllQuestions()
    {
        return _repository.GetAllQuestions();
    }

    public Task<Question> GetQuestionById(int id)
    {
        return _repository.GetQuestionById(id);
    }

    public Task<Question> AddQuestion(Question question)
    {
        return _repository.AddQuestion(question);
    }

    public Task<Question> UpdateQuestion(Question question)
    {
        return _repository.UpdateQuestion(question);
    }

    public Task<bool> DeleteQuestion(int id)
    {
        return _repository.DeleteQuestion(id);
    }
}
