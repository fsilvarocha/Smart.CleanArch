using FluentValidation;
using Smart.CleanArch.Domain.Entities.Pessoa;

namespace Smart.CleanArch.Infra.Mappings.Pessoa.Validator
{
    public class PessoasValidator : AbstractValidator<Pessoas>
    {
        public PessoasValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .MaximumLength(150)
                .WithMessage("Nome é obrigatório e não pode ser maior que 150 caracteres");
        }
    }
}
