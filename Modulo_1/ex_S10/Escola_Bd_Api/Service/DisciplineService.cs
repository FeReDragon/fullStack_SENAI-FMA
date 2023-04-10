using Escola_Bd_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Escola_Bd_Api.Services
{
    public class DisciplineService : IDisciplineService
    {
        private readonly EscolaDbContext _context;

        public DisciplineService(EscolaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Discipline>> GetDisciplines()
        {
            return await _context.Disciplines.ToListAsync();
        }

        public async Task<Discipline> GetDisciplineById(int id)
        {
            return await _context.Disciplines.FindAsync(id);
        }

        public async Task<Discipline> CreateDiscipline(Discipline discipline)
        {
            _context.Disciplines.Add(discipline);
            await _context.SaveChangesAsync();
            return discipline;
        }

        public async Task<Discipline> UpdateDiscipline(int id, Discipline discipline)
        {
            var existingDiscipline = await _context.Disciplines.FindAsync(id);
            if (existingDiscipline == null) return null;

            existingDiscipline.Name = discipline.Name;
            // Atualize outros campos conforme necessário

            await _context.SaveChangesAsync();
            return existingDiscipline;
        }

        public async Task DeleteDiscipline(int id)
        {
            var discipline = await _context.Disciplines.FindAsync(id);
            if (discipline != null)
            {
                _context.Disciplines.Remove(discipline);
                await _context.SaveChangesAsync();
            }
        }
    }
}
