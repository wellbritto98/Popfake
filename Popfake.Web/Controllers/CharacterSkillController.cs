using AutoMapper;
using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Web.Controllers.GenericController;
using PopFake.Data.Dtos;
using PopFake.Services.Interfaces;

namespace PopFake.Web.Controllers;
public class CharacterSkillQueryParams
{
    public int Id { get; set; }
}
public class CharacterSkillController : GenericController<CharacterSkill, InsertCharacterSkillDto, ReadCharacterSkillDto, UpdateCharacterSkillDto, CharacterSkillQueryParams>
{
    public CharacterSkillController(ICharacterSkillService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}
