using AutoMapper;
using PopFake.Models;

namespace PopFake.Data.Dtos.AutoMapperProfiles;

public class CharacterProfile : Profile
{
    public CharacterProfile()
    {
        CreateMap<Character, InsertCharacterDto>().ReverseMap();
        CreateMap<Character, ReadCharacterDto>().ReverseMap();
        CreateMap<Character, UpdateCharacterDto>().ReverseMap();
    }

}
