using AutoMapper;
using FilmeApi.Data.Dtos;
using FilmeApi.Models;

namespace FilmeApi.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, CinemaModel>();
        CreateMap<CinemaModel, ReadCinemaDto>().ForMember(cinemaDto => cinemaDto.endereco, 
            opt =>opt.MapFrom(cinema => cinema.Endereco))
            .ForMember(cinemaDto => cinemaDto.sessoes, 
                opt =>opt.MapFrom(cinema => cinema.Sessoes));
        CreateMap<UpdateCinemaDto, CinemaModel>();
        
    }
}