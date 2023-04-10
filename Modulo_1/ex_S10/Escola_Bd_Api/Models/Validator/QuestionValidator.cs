using FluentValidation;
using Escola_Bd_Api.Models;

public class QuestionValidator : AbstractValidator<Question>
{
    public QuestionValidator()
    {
        RuleFor(q => q.Enunciation).NotEmpty().WithMessage("Enunciação é obrigatória.")
                                    .Length(10, 500).WithMessage("Enunciação deve ter entre 10 e 500 caracteres.");
        RuleFor(q => q.Weight).NotEmpty().WithMessage("Peso é obrigatório.")
                              .InclusiveBetween(1, 100).WithMessage("Peso deve ser entre 1 e 100.");
    }
}
