using FluentValidation;
using Smart.CleanArch.Domain.Entities.Endereco;

namespace Smart.CleanArch.Infra.Mappings.Endereco.Validator
{
    public class EnderecosValidator : AbstractValidator<Enderecos>
    {
        public EnderecosValidator()
        {
            RuleFor(p => p.Logradouro)
                .NotEmpty()
                .MaximumLength(250)
                .WithMessage("Logradouro é obrigatório e não pode ser maior que 250 caracteres");

            RuleFor(p => p.Cep)
                .NotEmpty()
                .MaximumLength(10)
                .MinimumLength(8)
                .WithMessage("CEP é obrigatório e não pode ser maior que 8 caracteres");
        }
    }
}
