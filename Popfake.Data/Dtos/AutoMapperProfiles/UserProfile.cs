using AutoMapper;
using PopFake.Data.Dtos.Auth;
using PopFake.Models;

namespace PopFake.Data.Dtos.AutoMapperProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterUserDto, User>();
        CreateMap<LoginUserDto, User>();

    }

}