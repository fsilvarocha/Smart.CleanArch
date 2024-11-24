using Smart.CleanArch.Application.DataTransfer.Endereco.Response;
using Smart.CleanArch.Domain.Entities.Endereco;

namespace Smart.CleanArch.Application.DataTransfer.Pessoa.Response;

public class PessoasResponse
{
    public int Id { get; set; }
    public Guid Tenante { get; set; }
    public string Nome { get; set; }

    public ICollection<EnderecosResponse>? Enderecos { get; set; } = [];
}
