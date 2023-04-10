using FluentValidation;
using Escola_Bd_Api.Models;

public class AnswerValidator : AbstractValidator<Answer>
{
    public AnswerValidator()
    {
        RuleFor(a => a.AnswerText).NotEmpty().WithMessage("Texto da resposta é obrigatório.")
                                   .Length(1, 1000).WithMessage("Texto da resposta deve ter entre 1 e 1000 caracteres.");
        RuleFor(a => a.Score).InclusiveBetween(0, 100).WithMessage("A pontuação deve ser entre 0 e 100.");
        RuleFor(a => a.Observation).Length(0, 500).WithMessage("Observação deve ter no máximo 500 caracteres.");
    }
}
