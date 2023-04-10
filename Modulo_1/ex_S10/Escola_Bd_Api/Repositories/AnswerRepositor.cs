using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;
using Microsoft.EntityFrameworkCore;

public class AnswerRepository : IAnswerRepository
{
    private readonly EscolaDbContext _context;

    public AnswerRepository(EscolaDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Answer>> GetAllAnswers()
    {
        return await _context.Answers.ToListAsync();
    }

    public async Task<Answer> GetAnswerById(int id)
    {
        return await _context.Answers.FindAsync(id);
    }

    public async Task<Answer> AddAnswer(Answer answer)
    {
        await _context.Answers.AddAsync(answer);
        await _context.SaveChangesAsync();
        return answer;
    }

    public async Task<Answer> UpdateAnswer(Answer answer)
    {
        _context.Entry(answer).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return answer;
    }

    public async Task<bool> DeleteAnswer(int id)
    {
        var answer = await _context.Answers.FindAsync(id);
        if (answer == null)
        {
            return false;
        }

        _context.Answers.Remove(answer);
        await _context.SaveChangesAsync();
        return true;
    }
}
