using FluentValidation;
using Smart.CleanArch.Domain.Entities.Produto;

namespace Smart.CleanArch.Infra.Mappings.Produto.Validator;

public class ProdutosValidator : AbstractValidator<Produtos>
{
    public ProdutosValidator()
    {
        RuleFor(p => p.Nome)
            .NotEmpty()
            .MaximumLength(150)
            .WithMessage("Nome é obrigatório e não pode ser maior que 150 caracteres");
    }
}
