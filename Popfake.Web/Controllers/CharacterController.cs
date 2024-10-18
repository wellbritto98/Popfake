using AutoMapper;
using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Web.Controllers.GenericController;
using PopFake.Data.Dtos;
using PopFake.Services.Interfaces;

namespace PopFake.Web.Controllers;
public class CharacterQueryParams
{
    public int Id { get; set; }
}
public class CharacterController : GenericController<Character, InsertCharacterDto, ReadCharacterDto, UpdateCharacterDto, CharacterQueryParams>
{
    public CharacterController(ICharacterService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}
