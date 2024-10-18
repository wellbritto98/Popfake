using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Services.GenericService;
using PopFake.Services.Interfaces;

namespace PopFake.Services
{
    public class CharacterSkillService : GenericService<CharacterSkill>, ICharacterSkillService
    {
        private readonly ICharacterSkillRepository _Repository;

        public CharacterSkillService(ICharacterSkillRepository Repository) : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
