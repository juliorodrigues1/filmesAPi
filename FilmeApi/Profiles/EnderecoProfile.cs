using AutoMapper;
using FilmeApi.Data.Dtos;
using FilmeApi.Models;

namespace FilmeApi.Profiles;

public class EnderecoProfile : Profile
{
    protected EnderecoProfile()
    {
        CreateMap<CreateEnderecoDto, EnderecoModel>();
        CreateMap<UpdateEnderecoDto, EnderecoModel>();
        CreateMap<EnderecoModel, ReadEnderecoDto>();
    }
}