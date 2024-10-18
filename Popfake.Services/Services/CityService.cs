using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Services.GenericService;
using PopFake.Services.Interfaces;

namespace PopFake.Services
{
    public class CityService : GenericService<City>, ICityService
    {
        private readonly ICityRepository _Repository;

        public CityService(ICityRepository Repository) : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
