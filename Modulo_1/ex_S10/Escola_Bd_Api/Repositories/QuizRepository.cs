using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;
using Microsoft.EntityFrameworkCore;

public class QuizRepository : IQuizRepository
{
    private readonly EscolaDbContext _context;

    public QuizRepository(EscolaDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Quiz>> GetAllQuizzes()
    {
        return await _context.Quizzes.ToListAsync();
    }

    public async Task<Quiz> GetQuizById(int id)
    {
        return await _context.Quizzes.FindAsync(id);
    }

    public async Task<Quiz> AddQuiz(Quiz quiz)
    {
        await _context.Quizzes.AddAsync(quiz);
        await _context.SaveChangesAsync();
        return quiz;
    }

    public async Task<Quiz> UpdateQuiz(Quiz quiz)
    {
        _context.Entry(quiz).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return quiz;
    }

    public async Task<bool> DeleteQuiz(int id)
    {
        var quiz = await _context.Quizzes.FindAsync(id);
        if (quiz == null)
        {
            return false;
        }

        _context.Quizzes.Remove(quiz);
        await _context.SaveChangesAsync();
        return true;
    }
}
