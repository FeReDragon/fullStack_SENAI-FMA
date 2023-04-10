using FluentValidation;
using Escola_Bd_Api.Models;

public class StudentValidator : AbstractValidator<Student>
{
    public StudentValidator()
    {
        RuleFor(s => s.Name).NotEmpty().WithMessage("Nome é obrigatório.")
                            .Length(2, 100).WithMessage("Nome deve ter entre 2 e 100 caracteres.");
        RuleFor(s => s.Email).NotEmpty().WithMessage("Email é obrigatório.")
                              .EmailAddress().WithMessage("Email inválido.");
        RuleFor(s => s.Period).InclusiveBetween(1, 10).WithMessage("Período deve ser entre 1 e 10.");
        RuleFor(s => s.RA).GreaterThan(0).WithMessage("RA deve ser um número maior que 0.");
    }
}