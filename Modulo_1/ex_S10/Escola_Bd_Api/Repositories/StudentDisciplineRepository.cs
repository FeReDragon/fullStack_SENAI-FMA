using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;
using Microsoft.EntityFrameworkCore;

public class StudentDisciplineRepository : IStudentDisciplineRepository
{
    private readonly EscolaDbContext _context;

    public StudentDisciplineRepository(EscolaDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<StudentDiscipline>> GetAllStudentDisciplines()
    {
        return await _context.StudentDisciplines.Include(sd => sd.Student)
                                                .Include(sd => sd.Discipline)
                                                .ToListAsync();
    }

    public async Task<StudentDiscipline> GetStudentDisciplineById(int studentId, int disciplineId)
    {
        return await _context.StudentDisciplines
            .Where(sd => sd.StudentId == studentId && sd.DisciplineId == disciplineId)
            .Include(sd => sd.Student)
            .Include(sd => sd.Discipline)
            .FirstOrDefaultAsync();
    }

    public async Task<StudentDiscipline> AddStudentDiscipline(StudentDiscipline studentDiscipline)
    {
        await _context.StudentDisciplines.AddAsync(studentDiscipline);
        await _context.SaveChangesAsync();
        return studentDiscipline;
    }

    public async Task<StudentDiscipline> UpdateStudentDiscipline(StudentDiscipline studentDiscipline)
    {
        _context.Entry(studentDiscipline).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return studentDiscipline;
    }

    public async Task<bool> DeleteStudentDiscipline(int studentId, int disciplineId)
    {
        var studentDiscipline = await _context.StudentDisciplines
            .Where(sd => sd.StudentId == studentId && sd.DisciplineId == disciplineId)
            .FirstOrDefaultAsync();

        if (studentDiscipline == null)
        {
            return false;
        }

        _context.StudentDisciplines.Remove(studentDiscipline);
        await _context.SaveChangesAsync();
        return true;
    }
}
