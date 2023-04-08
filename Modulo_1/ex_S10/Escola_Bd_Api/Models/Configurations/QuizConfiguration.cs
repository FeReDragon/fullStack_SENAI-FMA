using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Escola_Bd_Api.Models;

public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder)
    {
        builder.HasKey(q => q.Id);

        builder.Property(q => q.Title)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(q => q.DateOpen)
            .IsRequired();

        builder.Property(q => q.DateClose)
            .IsRequired();

        builder.HasOne<Discipline>()
            .WithMany()
            .HasForeignKey(q => q.DisciplineId);
    }
}