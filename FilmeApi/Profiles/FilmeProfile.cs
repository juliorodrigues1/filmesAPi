using AutoMapper;
using FilmeApi.Data.Dtos;
using FilmeApi.Models;

namespace FilmeApi.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, FilmeModel>();
        CreateMap<UpdateFilmeDto, FilmeModel>();
        CreateMap<FilmeModel, ReadFilmeDto>()
            .ForMember(filmeDto => filmeDto.sessoes, 
            opt =>opt.MapFrom(filme => filme.Sessoes));
    }
}