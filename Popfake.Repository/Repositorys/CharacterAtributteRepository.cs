using PopFake.Data;
using PopFake.Models;
using PopFake.Repository.GenericRepository;
using PopFake.Repository.Interfaces;

namespace PopFake.Repository.Repositorys;

public class CharacterAtributteRepository : GenericRepository<CharacterAtributte>, ICharacterAtributteRepository
{
    public CharacterAtributteRepository(DataContext context) : base(context)
    {
    }
}
