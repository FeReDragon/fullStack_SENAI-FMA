using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;

public class QuizService : IQuizService
{
    private readonly IQuizRepository _repository;

    public QuizService(IQuizRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<Quiz>> GetAllQuizzes()
    {
        return _repository.GetAllQuizzes();
    }

    public Task<Quiz> GetQuizById(int id)
    {
        return _repository.GetQuizById(id);
    }

    public Task<Quiz> AddQuiz(Quiz quiz)
    {
        return _repository.AddQuiz(quiz);
    }

    public Task<Quiz> UpdateQuiz(Quiz quiz)
    {
        return _repository.UpdateQuiz(quiz);
    }

    public Task<bool> DeleteQuiz(int id)
    {
        return _repository.DeleteQuiz(id);
    }
}
