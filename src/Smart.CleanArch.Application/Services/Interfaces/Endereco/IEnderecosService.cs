using Smart.CleanArch.Application.DataTransfer.Pessoa.Response;
using Smart.CleanArch.Application.DataTransfer.Produto.Request;
using Smart.CleanArch.Application.DataTransfer.Produto.Response;

namespace Smart.CleanArch.Application.Services.Interfaces.Endereco;

public interface IEnderecosService
{
    Task<ProdutosResponse> GetByIdAsync(ProdutosPesquisaRequest entity);
    Task<IEnumerable<PessoasResponse>> GetAllAsync();
    Task<ProdutosResponse> AddAsync(ProdutosInserirRequest entity);
    Task UpdateAsync(ProdutosAtualizarRequest entity);
    Task DeleteAsync(int id, Guid tenante);
}
