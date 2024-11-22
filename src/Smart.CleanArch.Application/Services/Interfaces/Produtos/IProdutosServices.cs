using Smart.CleanArch.Application.DataTransfer.Produto.Request;
using Smart.CleanArch.Application.DataTransfer.Produto.Response;

namespace Smart.CleanArch.Application.Services.Interfaces.Produtos;

public interface IProdutosServices
{
    Task<ProdutosResponse> GetByIdAsync(ProdutosPesquisaRequest entity);
    Task<IEnumerable<ProdutosResponse>> GetAllAsync();
    Task<ProdutosResponse> AddAsync(ProdutosInserirRequest entity);
    Task UpdateAsync(ProdutosAtualizarRequest entity);
    Task DeleteAsync(int id, Guid tenante);
}
