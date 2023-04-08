using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Escola_Bd_Api.Models;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(s => s.Period)
            .IsRequired();

        builder.Property(s => s.RA)
            .IsRequired();

        builder.HasOne<User>()
            .WithOne()
            .HasForeignKey<Student>(s => s.Id);
    }
}