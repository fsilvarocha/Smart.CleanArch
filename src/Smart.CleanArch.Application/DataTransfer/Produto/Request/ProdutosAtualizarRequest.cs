namespace Smart.CleanArch.Application.DataTransfer.Produto.Request;

public class ProdutosAtualizarRequest
{
    public int Id { get; set; }
    public Guid Tenante { get; set; }
    public string Nome { get; set; }
}
