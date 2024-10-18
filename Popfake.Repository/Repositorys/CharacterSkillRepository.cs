using PopFake.Data;
using PopFake.Models;
using PopFake.Repository.GenericRepository;
using PopFake.Repository.Interfaces;

namespace PopFake.Repository.Repositorys;

public class CharacterSkillRepository : GenericRepository<CharacterSkill>, ICharacterSkillRepository
{
    public CharacterSkillRepository(DataContext context) : base(context)
    {
    }
}
