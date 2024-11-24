using AutoMapper;
using Smart.CleanArch.Application.DataTransfer.Endereco.Response;
using Smart.CleanArch.Domain.Entities.Endereco;

namespace Smart.CleanArch.Application.DataTransfer.Endereco.Profiles;

public class EnderecosProfile : Profile
{
    public EnderecosProfile()
    {
        CreateMap<EnderecosResponse, Enderecos>().ReverseMap();
    }
}
