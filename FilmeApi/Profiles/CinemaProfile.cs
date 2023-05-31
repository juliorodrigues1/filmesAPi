using AutoMapper;
using FilmeApi.Data.Dtos;
using FilmeApi.Models;

namespace FilmeApi.Profiles;

public class CinemaProfile : Profile
{
    protected CinemaProfile()
    {
        CreateMap<CreateCinemaDto, CinemaModel>();
        CreateMap<CinemaModel, ReadCinemaDto>();
        CreateMap<UpdateCinemaDto, CinemaModel>();
        
    }
}