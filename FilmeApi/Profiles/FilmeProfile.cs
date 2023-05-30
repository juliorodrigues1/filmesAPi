using AutoMapper;
using FilmeApi.Data.Dtos;
using FilmeApi.Models;

namespace FilmeApi.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, FilmeModel>();
    }
}