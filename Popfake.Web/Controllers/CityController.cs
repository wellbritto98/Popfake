using AutoMapper;
using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Web.Controllers.GenericController;
using PopFake.Data.Dtos;
using PopFake.Services.Interfaces;

namespace PopFake.Web.Controllers;
public class CityQueryParams
{
    public int Id { get; set; }
}
public class CityController : GenericController<City, InsertCityDto, ReadCityDto, UpdateCityDto, CityQueryParams>
{
    public CityController(ICityService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}
