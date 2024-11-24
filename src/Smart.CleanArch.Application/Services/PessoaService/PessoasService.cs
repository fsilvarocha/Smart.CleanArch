using AutoMapper;
using Smart.CleanArch.Application.DataTransfer.Pessoa.Request;
using Smart.CleanArch.Application.DataTransfer.Pessoa.Response;
using Smart.CleanArch.Application.DataTransfer.Produto.Request;
using Smart.CleanArch.Application.Services.Interfaces.Pessoa;
using Smart.CleanArch.Domain.Entities.Pessoa;
using Smart.CleanArch.Domain.Interfaces.Pessoa;

namespace Smart.CleanArch.Application.Services.PessoaService;

public class PessoasService : IPessoasService
{
    private readonly IPessoasRepository _pessoaRepository;
    private readonly IMapper _mapper;

    public PessoasService(IPessoasRepository pessoaRepository, IMapper mapper)
    {
        _pessoaRepository = pessoaRepository;
        _mapper = mapper;
    }

    public Task<PessoasResponse> AddAsync(PessoaInserirRequest entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id, Guid tenante)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<PessoasResponse>> GetAllAsync()
    {
        try
        {
            IEnumerable<Pessoas> listaPessoas = await _pessoaRepository.GetAllAsync();
            IEnumerable<PessoasResponse> responses = _mapper.Map<IEnumerable<PessoasResponse>>(listaPessoas);
            return responses;
        }
        catch (Exception ex)
        {

            throw;
        }

    }

    public async Task<PessoasResponse> GetByIdAsync(PessoaPesquisaRequest entity)
    {
        Pessoas comando = _mapper.Map<Pessoas>(entity);
        Pessoas produtos = await _pessoaRepository.GetByIdAsync(comando);
        PessoasResponse retorno = _mapper.Map<PessoasResponse>(produtos);
        return retorno;
    }

    public async Task<PessoasResponse> GetByIdTenanteAsync(PessoaPesquisaRequest entity)
    {
        Pessoas comando = _mapper.Map<Pessoas>(entity);
        Pessoas produtos = await _pessoaRepository.GetByIdTenanteAsync(comando);
        PessoasResponse retorno = _mapper.Map<PessoasResponse>(produtos);
        return retorno;
    }

    public Task UpdateAsync(ProdutosAtualizarRequest entity)
    {
        throw new NotImplementedException();
    }
}
