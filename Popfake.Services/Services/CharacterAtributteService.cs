using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Services.GenericService;
using PopFake.Services.Interfaces;

namespace PopFake.Services
{
    public class CharacterAtributteService : GenericService<CharacterAtributte>, ICharacterAtributteService
    {
        private readonly ICharacterAtributteRepository _Repository;

        public CharacterAtributteService(ICharacterAtributteRepository Repository) : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
