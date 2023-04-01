using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BercarioAPI.Models;

namespace BercarioAPI.Configurations
{
    public class BebeConfiguration : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.HasKey(b => b.ID);

            builder.Property(b => b.Data_Nasc)
                .IsRequired();

            builder.Property(b => b.Peso_nasc)
                .IsRequired();

            builder.Property(b => b.Altura)
                .IsRequired();

            builder.HasOne(b => b.Mae)
                .WithMany(m => m.Bebes)
                .HasForeignKey(b => b.ID_mae);

            builder.HasOne(b => b.Parto)
                .WithMany(p => p.Bebes)
                .HasForeignKey(b => b.ID_Parto);
        }
    }
}