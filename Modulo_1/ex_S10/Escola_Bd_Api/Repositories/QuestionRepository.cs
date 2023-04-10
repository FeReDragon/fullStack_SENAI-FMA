using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;
using Microsoft.EntityFrameworkCore;

public class QuestionRepository : IQuestionRepository
{
    private readonly EscolaDbContext _context;

    public QuestionRepository(EscolaDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Question>> GetAllQuestions()
    {
        return await _context.Questions.ToListAsync();
    }

    public async Task<Question> GetQuestionById(int id)
    {
        return await _context.Questions.FindAsync(id);
    }

    public async Task<Question> AddQuestion(Question question)
    {
        await _context.Questions.AddAsync(question);
        await _context.SaveChangesAsync();
        return question;
    }

    public async Task<Question> UpdateQuestion(Question question)
    {
        _context.Entry(question).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return question;
    }

    public async Task<bool> DeleteQuestion(int id)
    {
        var question = await _context.Questions.FindAsync(id);
        if (question == null)
        {
            return false;
        }

        _context.Questions.Remove(question);
        await _context.SaveChangesAsync();
        return true;
    }
}