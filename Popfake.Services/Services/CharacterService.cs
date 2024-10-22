using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Services.GenericService;
using PopFake.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PopFake.Data.Dtos.Auth;

namespace PopFake.Services
{
    public class CharacterService : GenericService<Character>, ICharacterService
    {
        private readonly ICharacterRepository _Repository;
        private readonly ICharacterAtributteRepository _characterAtributteRepository;
        private readonly IAtributteRepository _atributteRepository;
        private readonly ILocationRepository _locationRepository;
        private IJwtService _jwtService;
        private readonly IUserService _userService;

        public CharacterService(
            ICharacterRepository Repository,
            ICharacterAtributteRepository characterAtributteRepository,
            IAtributteRepository atributteRepository,
            ILocationRepository locationRepository,
            IJwtService jwtService,
            IUserService userService
            )
            : base(Repository)
        {
            _Repository = Repository;
            _characterAtributteRepository = characterAtributteRepository;
            _atributteRepository = atributteRepository;
            _locationRepository = locationRepository;
            _jwtService = jwtService;
            _userService = userService;
        }

        public override async Task<Character> AddAsync(Character entity)
        {
            var characterBirthCityId = entity.BirthCityId;
            if (string.IsNullOrEmpty(entity.AvatarUrl))
            {
                entity.AvatarUrl = entity.Gender == "M"
                    ? "https://img.freepik.com/premium-photo/graphic-designer-digital-avatar-generative-ai_934475-9292.jpg"
                    : "https://t3.ftcdn.net/jpg/06/17/13/26/360_F_617132669_YptvM7fIuczaUbYYpMe3VTLimwZwzlWf.jpg";
            }

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

        //get user characters by userId
        public async Task<IEnumerable<Character>> GetCharactersByUserIdAsync(string userId)
        {
            return await _Repository.FindAsync(query =>
                query.Where(c => c.UserId == userId)
            );
        }

        //set active character
        public async Task<string> SetActiveCharacterAsync(string userId, int characterId)
        {
            var characters = await ((ICharacterRepository)_Repository).FindAsync(query =>
                query.Where(c => c.Id == characterId)
            );

            if (characters == null)
            {
                throw new Exception("Personagem não encontrado");
            }

            var character = characters.FirstOrDefault();

            if (character.UserId != userId)
            {
                throw new Exception("Personagem não pertence ao usuário");
            }

            JwtDto newJwtDto = await _userService.GetUserLogged();
            //add character.Id to newToken.activeCharacterId
            newJwtDto.activeCharacterId = character.Id;

            var newToken = _jwtService.GenerateToken(newJwtDto);

            _jwtService.SetNewJwtCookies(newToken);

            return newToken;


        }

    }
}
