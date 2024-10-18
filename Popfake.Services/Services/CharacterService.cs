using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Services.GenericService;
using PopFake.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace PopFake.Services
{
    public class CharacterService : GenericService<Character>, ICharacterService
    {
        private readonly ICharacterRepository _Repository;
        private readonly ICharacterAtributteRepository _characterAtributteRepository;
        private readonly IAtributteRepository _atributteRepository;

        public CharacterService(ICharacterRepository Repository, ICharacterAtributteRepository characterAtributteRepository, IAtributteRepository atributteRepository) 
            : base(Repository)
        {
            _Repository = Repository;
            _characterAtributteRepository = characterAtributteRepository;
            _atributteRepository = atributteRepository;
        }

        public override async Task<Character> AddAsync(Character entity)
        {
            var character = await _Repository.AddAsync(entity);

            var atributtes = await _atributteRepository.GetAllAsync();


            foreach (var atributte in atributtes)
            {
                var characterAtributte = new CharacterAtributte
                {
                    CharacterId = character.Id,
                    AtributteId = atributte.Id,
                    Level = 1 
                };
                await _characterAtributteRepository.AddAsync(characterAtributte);
            }

            return character;
        }
    }
}
