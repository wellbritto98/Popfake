using AutoMapper;
using PopFake.Models;

namespace PopFake.Data.Dtos.AutoMapperProfiles;

public class SkillProfile : Profile
{
    public SkillProfile()
    {
        CreateMap<Skill, InsertSkillDto>().ReverseMap();
        CreateMap<Skill, ReadSkillDto>().ReverseMap();
        CreateMap<Skill, UpdateSkillDto>().ReverseMap();
    }

}
