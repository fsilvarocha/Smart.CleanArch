using Smart.CleanArch.Domain.Common;
using Smart.CleanArch.Domain.Entities.Endereco;

namespace Smart.CleanArch.Domain.Entities.Pessoa;

public class Pessoas : BaseEntity
{
    public string Nome { get; protected set; }
    public ICollection<Enderecos> Enderecos { get; protected set; } = [];

    public Pessoas(string nome)
    {
        SetNome(nome);
    }
    public Pessoas()
    {        
    }

    private void SetNome(string nome) => Nome = nome;
    private void SetEndereco(Enderecos endereco)
    {
        endereco.SetPessoa(this);
        Enderecos.Add(endereco);
    }
}
