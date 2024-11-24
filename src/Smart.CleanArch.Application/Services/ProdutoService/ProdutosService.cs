using AutoMapper;
using Smart.CleanArch.Application.DataTransfer.Produto.Request;
using Smart.CleanArch.Application.DataTransfer.Produto.Response;
using Smart.CleanArch.Application.Services.Interfaces.Produtos;
using Smart.CleanArch.Domain.Entities.Produto;
using Smart.CleanArch.Domain.Interfaces.Produto;

namespace Smart.CleanArch.Application.Services.ProdutoService;

public class ProdutosService : IProdutosServices
{
    private readonly IProdutosRepository _produtosRepository;
    private readonly IMapper _mapper;

    public ProdutosService(IProdutosRepository produtosRepository, IMapper mapper)
    {
        _produtosRepository = produtosRepository;
        _mapper = mapper;
    }

    public async Task<ProdutosResponse> AddAsync(ProdutosInserirRequest entity)
    {
        Produtos produtos = _mapper.Map<Produtos>(entity);
        await _produtosRepository.AddAsync(produtos);
        ProdutosResponse response = _mapper.Map<ProdutosResponse>(produtos);
        return response;
    }

    public async Task DeleteAsync(int id, Guid tenante)
    {
        Produtos comando = new();
        comando.SetId(id);
        comando.SetTenante(tenante);

        Produtos existingProdutos = await _produtosRepository.GetByIdAsync(comando);

        if (existingProdutos == null)
            return;

        await _produtosRepository.DeleteAsync(existingProdutos);
    }


    public async Task<IEnumerable<ProdutosResponse>> GetAllAsync()
    {
        IEnumerable<Produtos> retorno = await _produtosRepository.GetAllAsync();
        IEnumerable<ProdutosResponse> response = _mapper.Map<IEnumerable<ProdutosResponse>>(retorno);
        return response;

    }

    public async Task<ProdutosResponse> GetByIdAsync(ProdutosPesquisaRequest entity)
    {
        Produtos comando = _mapper.Map<Produtos>(entity);
        Produtos produtos = await _produtosRepository.GetByIdAsync(comando);
        ProdutosResponse retorno = _mapper.Map<ProdutosResponse>(produtos);
        return retorno;
    }

    public async Task<ProdutosResponse> GetByIdTenanteAsync(ProdutosPesquisaRequest entity)
    {
        Produtos comando = _mapper.Map<Produtos>(entity);
        Produtos produtos = await _produtosRepository.GetByIdTenanteAsync(comando);
        ProdutosResponse retorno = _mapper.Map<ProdutosResponse>(produtos);
        return retorno;
    }

    public async Task UpdateAsync(ProdutosAtualizarRequest entity)
    {

        Produtos comando = _mapper.Map<Produtos>(entity);

        Produtos existingProdutos = await _produtosRepository.GetByIdAsync(comando);

        if (existingProdutos == null)
            return;


        existingProdutos.setDataAtualizado();
        existingProdutos.SetNome(entity.Nome);

        await _produtosRepository.UpdateAsync(existingProdutos);
    }
}
