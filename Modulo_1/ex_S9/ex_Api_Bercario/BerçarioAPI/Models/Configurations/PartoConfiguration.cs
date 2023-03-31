using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BerçarioAPI.Models;

namespace BerçarioAPI.Configurations
{
    public class PartoConfiguration : IEntityTypeConfiguration<Parto>
    {
        public void Configure(EntityTypeBuilder<Parto> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.Data_Parto)
                .IsRequired();

            builder.Property(p => p.Horario_Parto)
                .IsRequired();

            builder.HasOne(p => p.Medico)
                .WithMany(m => m.Partos)
                .HasForeignKey(p => p.ID_Medico);
        }
    }
}