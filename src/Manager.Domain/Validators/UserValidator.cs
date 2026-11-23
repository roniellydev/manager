using FluentValidation;
using Manager.Domain.Entities;

namespace Manager.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x)
            .NotEmpty().WithMessage("A entidade não pode ser vazia")
            .NotNull().WithMessage("A entidade não pode ser nula");

            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("O nome não pode ser vazio")
            .NotNull().WithMessage("O nome não pode ser nulo")
            .MinimumLength(3).WithMessage("O nome deve ter no mínimo 3 caracteres")
            .MaximumLength(80).WithMessage("O nome deve ter no máximo 80 caracteres");

            RuleFor(x => x.Email)
            .NotEmpty().WithMessage("O email não pode ser vazio")
            .NotNull().WithMessage("O email não pode ser nulo")
            .MinimumLength(10).WithMessage("O email deve ter no mínimo 10 caracteres")
            .MaximumLength(180).WithMessage("O nome deve ter no máximo 180 caracteres")
            .Matches(@"").WithMessage("O email informado não é valido");

            RuleFor(x => x.Password)
            .NotEmpty().WithMessage("A senha não pode ser vazio")
            .NotNull().WithMessage("A senha não pode ser nulo")
            .MinimumLength(6).WithMessage("A senha deve ter no mínimo 6 caracteres")
            .MaximumLength(8).WithMessage("A senha deve ter no máximo 8 caracteres");
        }
    }
}