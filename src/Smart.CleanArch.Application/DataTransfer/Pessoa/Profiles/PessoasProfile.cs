using AutoMapper;
using Smart.CleanArch.Application.DataTransfer.Pessoa.Request;
using Smart.CleanArch.Application.DataTransfer.Pessoa.Response;
using Smart.CleanArch.Domain.Entities.Pessoa;

namespace Smart.CleanArch.Application.DataTransfer.Pessoa.Profiles;

public class PessoasProfile : Profile
{
    public PessoasProfile()
    {
        CreateMap<Pessoas, PessoasResponse>().ReverseMap();
        CreateMap<Pessoas, PessoaPesquisaRequest>().ReverseMap();
    }
}
