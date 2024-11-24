using Smart.CleanArch.Application.DataTransfer.Pessoa.Request;
using Smart.CleanArch.Application.DataTransfer.Pessoa.Response;
using Smart.CleanArch.Application.DataTransfer.Produto.Request;

namespace Smart.CleanArch.Application.Services.Interfaces.Pessoa;

public interface IPessoasService
{
    Task<PessoasResponse> GetByIdAsync(PessoaPesquisaRequest entity);
    Task<PessoasResponse> GetByIdTenanteAsync(PessoaPesquisaRequest entity);
    Task<IEnumerable<PessoasResponse>> GetAllAsync();
    Task<PessoasResponse> AddAsync(PessoaInserirRequest entity);
    Task UpdateAsync(ProdutosAtualizarRequest entity);
    Task DeleteAsync(int id, Guid tenante);
}
