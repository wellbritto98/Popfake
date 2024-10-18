using PopFake.Data;
using PopFake.Models;
using PopFake.Repository.GenericRepository;
using PopFake.Repository.Interfaces;

namespace PopFake.Repository.Repositorys;

public class LocationRepository : GenericRepository<Location>, ILocationRepository
{
    public LocationRepository(DataContext context) : base(context)
    {
    }
}
