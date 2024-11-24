using AutoMapper;
using Smart.CleanArch.Application.DataTransfer.Pessoa.Response;
using Smart.CleanArch.Application.DataTransfer.Produto.Request;
using Smart.CleanArch.Application.DataTransfer.Produto.Response;
using Smart.CleanArch.Application.Services.Interfaces.Endereco;
using Smart.CleanArch.Domain.Interfaces.Endereco;

namespace Smart.CleanArch.Application.Services.EnderecoService;

public class EnderecosService : IEnderecosService
{
    private readonly IEnderecosRepository _enderecosRepository;
    private readonly IMapper _mapper;

    public EnderecosService(IEnderecosRepository enderecosRepository, IMapper mapper)
    {
        _enderecosRepository = enderecosRepository;
        _mapper = mapper;
    }

    public Task<ProdutosResponse> AddAsync(ProdutosInserirRequest entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id, Guid tenante)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PessoasResponse>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProdutosResponse> GetByIdAsync(ProdutosPesquisaRequest entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ProdutosAtualizarRequest entity)
    {
        throw new NotImplementedException();
    }
}
