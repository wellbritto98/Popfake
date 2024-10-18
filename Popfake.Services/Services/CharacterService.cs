using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Services.GenericService;
using PopFake.Services.Interfaces;

namespace PopFake.Services
{
    public class CharacterService : GenericService<Character>, ICharacterService
    {
        private readonly ICharacterRepository _Repository;

        public CharacterService(ICharacterRepository Repository) : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
