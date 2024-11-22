namespace Smart.CleanArch.Application.DataTransfer.Produto.Response;

public class ProdutosResponse
{
    public int Id { get; set; }
    public Guid Tenante { get; set; }
    public string Nome { get; set; }
    public DateTime DataCriacao { get; set; }
}
