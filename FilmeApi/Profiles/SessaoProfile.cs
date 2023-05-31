using AutoMapper;
using FilmeApi.Data.Dtos;
using FilmeApi.Models;

namespace FilmeApi.Profiles;

public class SessaoProfile : Profile
{
    public SessaoProfile()
    {
        CreateMap<CreateSessaoDto, SessaoModel>();
        CreateMap<SessaoModel, ReadSessaoDto>();
    }
}