using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BerçarioAPI.Configurations;

namespace BerçarioAPI.Models
{
    public class BerçarioContext : DbContext
    {
        public BerçarioContext(DbContextOptions<BerçarioContext> options) : base(options)
        {
        }

        public DbSet<Mae> Maes { get; set; }
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Parto> Partos { get; set; }
        public DbSet<Medico> Medicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=BerçarioApi;User=root;Password=****;",
                new MySqlServerVersion(new Version(8, 0, 23)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MaeConfiguration());
            modelBuilder.ApplyConfiguration(new BebeConfiguration());
            modelBuilder.ApplyConfiguration(new PartoConfiguration());
            modelBuilder.ApplyConfiguration(new MedicoConfiguration());
        }
    }
}