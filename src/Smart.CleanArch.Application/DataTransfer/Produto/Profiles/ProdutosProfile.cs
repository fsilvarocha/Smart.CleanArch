using AutoMapper;
using Smart.CleanArch.Application.DataTransfer.Produto.Request;
using Smart.CleanArch.Application.DataTransfer.Produto.Response;
using Smart.CleanArch.Domain.Entities.Produto;

namespace Smart.CleanArch.Application.DataTransfer.Produto.Profiles;

public class ProdutosProfile : Profile
{
    public ProdutosProfile()
    {
        CreateMap<Produtos, ProdutosInserirRequest>()
            .ForMember(dest => dest.Tenante, opt => opt.MapFrom(src => src.Tenante))
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome));

        CreateMap<ProdutosInserirRequest, Produtos>()
            .ForMember(dest => dest.Tenante, opt => opt.MapFrom(src => src.Tenante))
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome));

        CreateMap<Produtos, ProdutosResponse>();
        CreateMap<Produtos, ProdutosPesquisaRequest>().ReverseMap();
        CreateMap<ProdutosResponse, ProdutosInserirRequest>().ReverseMap();
        CreateMap<ProdutosAtualizarRequest, Produtos>().ReverseMap();



    }
}
