using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BerçarioAPI.Models;

namespace BerçarioAPI.Configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(m => m.ID);

            builder.Property(m => m.CRM)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(m => m.Celular)
                .HasMaxLength(20);

            builder.Property(m => m.Especialidade)
                .HasMaxLength(100);
        }
    }
}