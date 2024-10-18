using PopFake.Data;
using PopFake.Models;
using PopFake.Repository.GenericRepository;
using PopFake.Repository.Interfaces;

namespace PopFake.Repository.Repositorys;

public class AtributteRepository : GenericRepository<Atributte>, IAtributteRepository
{
    public AtributteRepository(DataContext context) : base(context)
    {
    }
}
