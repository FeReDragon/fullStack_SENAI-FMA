using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;
using Microsoft.EntityFrameworkCore;

public class StudentRepository : IStudentRepository
{
    private readonly EscolaDbContext _context;

    public StudentRepository(EscolaDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Student>> GetAllStudents()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task<Student> GetStudentById(int id)
    {
        return await _context.Students.FindAsync(id);
    }

    public async Task<Student> AddStudent(Student student)
    {
        await _context.Students.AddAsync(student);
        await _context.SaveChangesAsync();
        return student;
    }

    public async Task<Student> UpdateStudent(Student student)
    {
        _context.Entry(student).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return student;
    }

    public async Task<bool> DeleteStudent(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null)
        {
            return false;
        }

        _context.Students.Remove(student);
        await _context.SaveChangesAsync();
        return true;
    }
}
