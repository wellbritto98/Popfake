using AutoMapper;
using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Web.Controllers.GenericController;
using PopFake.Data.Dtos;
using PopFake.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.AspNetCore.Authorization;

namespace PopFake.Web.Controllers;
public class CharacterQueryParams
{
    public int Id { get; set; }
}
[Authorize]
public class CharacterController : GenericController<Character, InsertCharacterDto, ReadCharacterDto, UpdateCharacterDto, CharacterQueryParams>
{
    public CharacterController(ICharacterService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(service, mapper, httpContextAccessor)
    {

    }

    [HttpGet("SetActiveCharacter")]
    public async Task<IActionResult> SetActiveCharacter([FromQuery] int characterId)
    {
        try
        {


            if (_httpContextAccessor.HttpContext == null || _httpContextAccessor.HttpContext.User == null)
            {
                return Unauthorized("Usuário não autenticado.");
            }

            var userIdClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim == null)
            {
                return Unauthorized("Claim de UserId não encontrada.");
            }

            var userId = userIdClaim.Value;

            string newJwt = await ((ICharacterService)_service).SetActiveCharacterAsync(userId, characterId);
            return Ok(newJwt);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


}
