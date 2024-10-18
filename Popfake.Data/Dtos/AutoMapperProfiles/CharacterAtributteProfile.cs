using AutoMapper;
using PopFake.Models;

namespace PopFake.Data.Dtos.AutoMapperProfiles;

public class CharacterAtributteProfile : Profile
{
    public CharacterAtributteProfile()
    {
        CreateMap<CharacterAtributte, InsertCharacterAtributteDto>().ReverseMap();
        CreateMap<CharacterAtributte, ReadCharacterAtributteDto>().ReverseMap();
        CreateMap<CharacterAtributte, UpdateCharacterAtributteDto>().ReverseMap();
    }

}
