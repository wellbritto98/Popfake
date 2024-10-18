using AutoMapper;
using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Web.Controllers.GenericController;
using PopFake.Data.Dtos;
using PopFake.Services.Interfaces;

namespace PopFake.Web.Controllers;
public class AtributteQueryParams
{
    public int Id { get; set; }
}
public class AtributteController : GenericController<Atributte, InsertAtributteDto, ReadAtributteDto, UpdateAtributteDto, AtributteQueryParams>
{
    public AtributteController(IAtributteService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}
