using AutoMapper;
using PopFake.Models;

namespace PopFake.Data.Dtos.AutoMapperProfiles;

public class CompanyShareholderProfile : Profile
{
    public CompanyShareholderProfile()
    {
        CreateMap<CompanyShareholder, InsertCompanyShareholderDto>().ReverseMap();
        CreateMap<CompanyShareholder, ReadCompanyShareholderDto>().ReverseMap();
        CreateMap<CompanyShareholder, UpdateCompanyShareholderDto>().ReverseMap();
    }

}
