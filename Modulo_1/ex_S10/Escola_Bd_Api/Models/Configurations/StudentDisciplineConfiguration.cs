using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Escola_Bd_Api.Models;

public class StudentDisciplineConfiguration : IEntityTypeConfiguration<StudentDiscipline>
{
    public void Configure(EntityTypeBuilder<StudentDiscipline> builder)
    {
        builder.HasKey(sd => new { sd.StudentId, sd.DisciplineId });

        builder.HasOne(sd => sd.Student)
            .WithMany(s => s.StudentDisciplines)
            .HasForeignKey(sd => sd.StudentId);

        builder.HasOne(sd => sd.Discipline)
            .WithMany(d => d.StudentDisciplines)
            .HasForeignKey(sd => sd.DisciplineId);
    }
}