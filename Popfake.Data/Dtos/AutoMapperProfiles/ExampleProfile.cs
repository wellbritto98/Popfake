using AutoMapper;
using PopFake.Models;

namespace PopFake.Data.Dtos.AutoMapperProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        CreateMap<ExampleEntity, InsertExampleDto>().ReverseMap();
        CreateMap<ExampleEntity, ReadExampleDto>().ReverseMap();
        CreateMap<ExampleEntity, UpdateExampleDto>().ReverseMap();
    }

}