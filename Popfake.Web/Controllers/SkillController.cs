using AutoMapper;
using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Web.Controllers.GenericController;
using PopFake.Data.Dtos;
using PopFake.Services.Interfaces;

namespace PopFake.Web.Controllers;
public class SkillQueryParams
{
    public int Id { get; set; }
}
public class SkillController : GenericController<Skill, InsertSkillDto, ReadSkillDto, UpdateSkillDto, SkillQueryParams>
{
    public SkillController(ISkillService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

}
