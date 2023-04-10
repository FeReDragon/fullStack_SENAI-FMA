using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;

public class AnswerService : IAnswerService
{
    private readonly IAnswerRepository _repository;

    public AnswerService(IAnswerRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<Answer>> GetAllAnswers()
    {
        return _repository.GetAllAnswers();
    }

    public Task<Answer> GetAnswerById(int id)
    {
        return _repository.GetAnswerById(id);
    }

    public Task<Answer> AddAnswer(Answer answer)
    {
        return _repository.AddAnswer(answer);
    }

    public Task<Answer> UpdateAnswer(Answer answer)
    {
        return _repository.UpdateAnswer(answer);
    }

    public Task<bool> DeleteAnswer(int id)
    {
        return _repository.DeleteAnswer(id);
    }
}
