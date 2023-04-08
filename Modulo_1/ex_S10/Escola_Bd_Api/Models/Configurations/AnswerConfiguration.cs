using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Escola_Bd_Api.Models;

public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
{
    public void Configure(EntityTypeBuilder<Answer> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.AnswerText)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(a => a.Score)
            .IsRequired()
            .HasColumnType("float");

        builder.Property(a => a.Observation)
            .HasMaxLength(1000);

        builder.HasOne<Question>()
            .WithMany()
            .HasForeignKey(a => a.QuestionId);

        builder.HasOne<Student>()
            .WithMany()
            .HasForeignKey(a => a.StudentId);
    }
}