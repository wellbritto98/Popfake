using AutoMapper;
using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Web.Controllers.GenericController;
using PopFake.Data.Dtos;
using PopFake.Services.Interfaces;

namespace PopFake.Web.Controllers;
public class CompanyQueryParams
{
    public int Id { get; set; }
}
public class CompanyController : GenericController<Company, InsertCompanyDto, ReadCompanyDto, UpdateCompanyDto, CompanyQueryParams>
{
    public CompanyController(ICompanyService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}
