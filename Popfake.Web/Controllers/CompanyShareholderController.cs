using AutoMapper;
using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Web.Controllers.GenericController;
using PopFake.Data.Dtos;
using PopFake.Services.Interfaces;

namespace PopFake.Web.Controllers;
public class CompanyShareholderQueryParams
{
    public int CharacterId { get; set; }
    public int CompanyId { get; set; }
}
public class CompanyShareholderController : GenericController<CompanyShareholder, InsertCompanyShareholderDto, ReadCompanyShareholderDto, UpdateCompanyShareholderDto, CompanyShareholderQueryParams>
{
    public CompanyShareholderController(ICompanyShareholderService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}
