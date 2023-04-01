using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BercarioAPI.Models;

namespace BercarioAPI.Configurations
{
    public class MaeConfiguration : IEntityTypeConfiguration<Mae>
    {
        public void Configure(EntityTypeBuilder<Mae> builder)
        {
            builder.HasKey(m => m.ID);

            builder.Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(m => m.Endereco)
                .HasMaxLength(300);

            builder.Property(m => m.Telefone)
                .HasMaxLength(20);

            builder.Property(m => m.Data_Nasc)
                .IsRequired();
        }
    }
}