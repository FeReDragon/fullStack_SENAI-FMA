using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;
using Microsoft.EntityFrameworkCore;

public class TeacherRepository : ITeacherRepository
{
    private readonly EscolaDbContext _context;

    public TeacherRepository(EscolaDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Teacher>> GetAllTeachers()
    {
        return await _context.Teachers.ToListAsync();
    }

    public async Task<Teacher> GetTeacherById(int id)
    {
        return await _context.Teachers.FindAsync(id);
    }

    public async Task<Teacher> AddTeacher(Teacher teacher)
    {
        await _context.Teachers.AddAsync(teacher);
        await _context.SaveChangesAsync();
        return teacher;
    }

    public async Task<Teacher> UpdateTeacher(Teacher teacher)
    {
        _context.Entry(teacher).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return teacher;
    }

    public async Task<bool> DeleteTeacher(int id)
    {
        var teacher = await _context.Teachers.FindAsync(id);
        if (teacher == null)
        {
            return false;
        }

        _context.Teachers.Remove(teacher);
        await _context.SaveChangesAsync();
        return true;
    }
}
