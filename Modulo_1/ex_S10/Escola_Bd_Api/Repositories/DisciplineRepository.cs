using Escola_Bd_Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola_Bd_Api.Repositories
{
    public class DisciplineRepository : IRepository<Discipline>
    {
        private readonly EscolaDbContext _context;

        public DisciplineRepository(EscolaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Discipline>> GetAll()
        {
            return await _context.Disciplines.ToListAsync();
        }

        public async Task<Discipline> GetById(int id)
        {
            return await _context.Disciplines.FindAsync(id);
        }

        public async Task Create(Discipline discipline)
        {
            await _context.Disciplines.AddAsync(discipline);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Discipline discipline)
        {
            _context.Entry(discipline).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Discipline discipline)
        {
            _context.Disciplines.Remove(discipline);
            await _context.SaveChangesAsync();
        }
    }
}
