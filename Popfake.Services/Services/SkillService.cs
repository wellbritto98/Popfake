using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Services.GenericService;
using PopFake.Services.Interfaces;

namespace PopFake.Services
{
    public class SkillService : GenericService<Skill>, ISkillService
    {
        private readonly ISkillRepository _Repository;

        public SkillService(ISkillRepository Repository) : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
