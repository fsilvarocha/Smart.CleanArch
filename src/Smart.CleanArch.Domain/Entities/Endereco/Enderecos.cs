using Smart.CleanArch.Domain.Common;
using Smart.CleanArch.Domain.Entities.Pessoa;
using System.Text.Json.Serialization;

namespace Smart.CleanArch.Domain.Entities.Endereco;

public class Enderecos : BaseEntity
{
    public string? Logradouro { get; protected set; }
    public string? Cep { get; protected set; }
    public string? Cidade { get; protected set; }
    public int? PessoaId { get; protected set; }

    [JsonIgnore]
    public Pessoas Pessoa { get; protected set; }

    public Enderecos()
    {

    }

    public void SetPessoa(Pessoas pessoas)
    {
        Pessoa = pessoas;
        PessoaId = pessoas.Id;
        Tenante = pessoas.Tenante;
    }
    private void SetLogradouro(string logradouro) => Logradouro = logradouro;
    private void SetCep(string cep) => Cep = cep;
    private void SetCidade(string cidade) => Cidade = cidade;
    private void SetIdPessoa(int pessoaId) => PessoaId = pessoaId;

}
