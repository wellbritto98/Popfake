using AutoMapper;
using PopFake.Models;

namespace PopFake.Data.Dtos.AutoMapperProfiles;

public class LocationProfile : Profile
{
    public LocationProfile()
    {
        CreateMap<Location, InsertLocationDto>().ReverseMap();
        CreateMap<Location, ReadLocationDto>().ReverseMap();
        CreateMap<Location, UpdateLocationDto>().ReverseMap();
    }

}
