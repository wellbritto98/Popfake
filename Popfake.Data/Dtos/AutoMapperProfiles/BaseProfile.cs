using AutoMapper;
using PopFake.Data.Dtos;

namespace PopFake.Data.Dtos.AutoMapperProfiles;

public class BaseProfile : Profile
{

    public BaseProfile()
    {
        CreateMap<Models.Base.BaseEntity, BaseDto>().ReverseMap();
    }

}