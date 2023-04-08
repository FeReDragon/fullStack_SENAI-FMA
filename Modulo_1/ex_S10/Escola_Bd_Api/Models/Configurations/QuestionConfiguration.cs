using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Escola_Bd_Api.Models;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasKey(q => q.Id);

        builder.Property(q => q.Enunciation)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(q => q.Weight)
            .IsRequired()
            .HasColumnType("decimal(5, 2)");

        builder.HasOne<Quiz>()
            .WithMany()
            .HasForeignKey(q => q.QuizId);
    }
}