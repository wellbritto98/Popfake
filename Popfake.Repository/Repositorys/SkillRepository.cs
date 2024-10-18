using PopFake.Data;
using PopFake.Models;
using PopFake.Repository.GenericRepository;
using PopFake.Repository.Interfaces;

namespace PopFake.Repository.Repositorys;

public class SkillRepository : GenericRepository<Skill>, ISkillRepository
{
    public SkillRepository(DataContext context) : base(context)
    {
    }
}
