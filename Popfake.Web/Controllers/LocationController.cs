using AutoMapper;
using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Web.Controllers.GenericController;
using PopFake.Data.Dtos;
using PopFake.Services.Interfaces;

namespace PopFake.Web.Controllers;
public class LocationQueryParams
{
    public int Id { get; set; }
}
public class LocationController : GenericController<Location, InsertLocationDto, ReadLocationDto, UpdateLocationDto, LocationQueryParams>
{
    public LocationController(ILocationService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}
