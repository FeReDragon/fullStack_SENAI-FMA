using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Escola_Bd_Api.Models;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Department)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasOne<User>()
            .WithOne()
            .HasForeignKey<Teacher>(t => t.Id);
    }
}