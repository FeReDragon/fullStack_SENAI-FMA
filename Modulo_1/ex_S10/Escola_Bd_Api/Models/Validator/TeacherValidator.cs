using FluentValidation;
using Escola_Bd_Api.Models;

public class TeacherValidator : AbstractValidator<Teacher>
{
    public TeacherValidator()
    {
        RuleFor(t => t.Name).NotEmpty().WithMessage("Nome é obrigatório.")
                            .Length(2, 100).WithMessage("Nome deve ter entre 2 e 100 caracteres.");
        RuleFor(t => t.Email).NotEmpty().WithMessage("Email é obrigatório.")
                              .EmailAddress().WithMessage("Email inválido.");
        RuleFor(t => t.Department).NotEmpty().WithMessage("Departamento é obrigatório.")
                                   .Length(2, 100).WithMessage("Departamento deve ter entre 2 e 100 caracteres.");
        RuleFor(t => t.Registration).NotEmpty().WithMessage("Matrícula é obrigatória.")
                                     .Length(2, 20).WithMessage("Matrícula deve ter entre 2 e 20 caracteres.");
    }
}
