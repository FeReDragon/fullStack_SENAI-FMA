using FluentValidation;
using Escola_Bd_Api.Models;

public class QuizValidator : AbstractValidator<Quiz>
{
    public QuizValidator()
    {
        RuleFor(q => q.Title).NotEmpty().WithMessage("Título é obrigatório.")
                              .Length(2, 100).WithMessage("Título deve ter entre 2 e 100 caracteres.");
        RuleFor(q => q.DateOpen).NotEmpty().WithMessage("Data de abertura é obrigatória.");
        RuleFor(q => q.DateClose).NotEmpty().WithMessage("Data de encerramento é obrigatória.")
                                 .GreaterThan(q => q.DateOpen).WithMessage("Data de encerramento deve ser maior que a data de abertura.");
    }
}
