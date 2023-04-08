using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Escola_Bd_Api.Models;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        // Remova a configuração da chave primária
        // builder.HasKey(t => t.Id);

        builder.Property(t => t.Registration)
            .IsRequired();

        builder.HasOne<User>()
            .WithOne()
            .HasForeignKey<Teacher>(t => t.Id);
    }
}
