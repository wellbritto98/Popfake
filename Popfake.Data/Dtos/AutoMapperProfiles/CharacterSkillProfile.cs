using AutoMapper;
using PopFake.Models;

namespace PopFake.Data.Dtos.AutoMapperProfiles;

public class CharacterSkillProfile : Profile
{
    public CharacterSkillProfile()
    {
        CreateMap<CharacterSkill, InsertCharacterSkillDto>().ReverseMap();
        CreateMap<CharacterSkill, ReadCharacterSkillDto>().ReverseMap();
        CreateMap<CharacterSkill, UpdateCharacterSkillDto>().ReverseMap();
    }

}
