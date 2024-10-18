using AutoMapper;
using PopFake.Models;

namespace PopFake.Data.Dtos.AutoMapperProfiles;

public class AtributteProfile : Profile
{
    public AtributteProfile()
    {
        CreateMap<Atributte, InsertAtributteDto>().ReverseMap();
        CreateMap<Atributte, ReadAtributteDto>().ReverseMap();
        CreateMap<Atributte, UpdateAtributteDto>().ReverseMap();
    }

}
