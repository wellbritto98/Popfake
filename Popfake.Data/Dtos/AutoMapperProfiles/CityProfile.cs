using AutoMapper;
using PopFake.Models;

namespace PopFake.Data.Dtos.AutoMapperProfiles;

public class CityProfile : Profile
{
    public CityProfile()
    {
        CreateMap<City, InsertCityDto>().ReverseMap();
        CreateMap<City, ReadCityDto>().ReverseMap();
        CreateMap<City, UpdateCityDto>().ReverseMap();
    }

}
