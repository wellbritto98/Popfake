using PopFake.Data;
using PopFake.Models;
using PopFake.Repository.GenericRepository;
using PopFake.Repository.Interfaces;

namespace PopFake.Repository.Repositorys;

public class CityRepository : GenericRepository<City>, ICityRepository
{
    public CityRepository(DataContext context) : base(context)
    {
    }
}
