using AutoMapper;
using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Web.Controllers.GenericController;
using PopFake.Data.Dtos;
using PopFake.Services.Interfaces;

namespace PopFake.Web.Controllers;
public class CharacterAtributteQueryParams
{
    public int Id { get; set; }
}
public class CharacterAtributteController : GenericController<CharacterAtributte, InsertCharacterAtributteDto, ReadCharacterAtributteDto, UpdateCharacterAtributteDto, CharacterAtributteQueryParams>
{
    public CharacterAtributteController(ICharacterAtributteService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}
