using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Services.GenericService;
using PopFake.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PopFake.Services
{
    public class CharacterService : GenericService<Character>, ICharacterService
    {
        private readonly ICharacterRepository _Repository;
        private readonly ICharacterAtributteRepository _characterAtributteRepository;
        private readonly IAtributteRepository _atributteRepository;
        private readonly ILocationRepository _locationRepository;

        public CharacterService(ICharacterRepository Repository, ICharacterAtributteRepository characterAtributteRepository, IAtributteRepository atributteRepository, ILocationRepository locationRepository)
            : base(Repository)
        {
            _Repository = Repository;
            _characterAtributteRepository = characterAtributteRepository;
            _atributteRepository = atributteRepository;
            _locationRepository = locationRepository;
        }

        public override async Task<Character> AddAsync(Character entity)
        {
            var characterBirthCityId = entity.BirthCityId;

            // Consulta LINQ para encontrar a localização com base no CityId
            var locations = await _locationRepository.FindAsync(query =>
                query.Where(l => l.CityId == characterBirthCityId));

            var location = locations.FirstOrDefault();

            // Define a localização atual do personagem na cidade de nascimento, se encontrada
            if (location != null)
            {
                entity.CurrentLocationId = location.Id;
            }

            // Adiciona o personagem ao repositório
            var character = await _Repository.AddAsync(entity);

            // Obtém todos os atributos disponíveis
            var atributtes = await _atributteRepository.GetAllAsync();

            // Adiciona os atributos iniciais ao personagem
            foreach (var atributte in atributtes)
            {
                var characterAtributte = new CharacterAtributte
                {
                    CharacterId = character.Id,
                    AtributteId = atributte.Id,
                    Level = 1 // Define o nível inicial do atributo
                };
                await _characterAtributteRepository.AddAsync(characterAtributte);
            }

            return character;
        }

    }
}
