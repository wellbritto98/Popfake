using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Services.GenericService;
using PopFake.Services.Interfaces;

namespace PopFake.Services
{
    public class LocationService : GenericService<Location>, ILocationService
    {
        private readonly ILocationRepository _Repository;

        public LocationService(ILocationRepository Repository) : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
