using Smart.CleanArch.Domain.Common;

namespace Smart.CleanArch.Domain.Entities.Produto
{
    public class Produtos : BaseEntity
    {
        public string Nome { get; private set; }

        public Produtos() { }

        public Produtos(string nome)
        {
            SetNome(nome);
        }

        public void SetNome(string nome) => Nome = nome;

        public void SetId(int id) => Id = id;
        public void SetTenante(Guid tenante) => Tenante = tenante;

        public void setDataAtualizado() => DataAtualizado = DateTime.Now;
    }

}
