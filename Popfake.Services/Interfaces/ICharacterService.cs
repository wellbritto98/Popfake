using PopFake.Models;
using PopFake.Services.GenericService;

namespace PopFake.Services.Interfaces
{
    public interface ICharacterService : IGenericService<Character>
    {
        Task<string> SetActiveCharacterAsync(string userId, int characterId);
        Task<IEnumerable<Character>> GetCharactersByUserIdAsync(string userId);
    }
}
