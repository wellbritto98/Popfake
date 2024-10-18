using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Services.GenericService;
using PopFake.Services.Interfaces;

namespace PopFake.Services
{
    public class AtributteService : GenericService<Atributte>, IAtributteService
    {
        private readonly IAtributteRepository _Repository;

        public AtributteService(IAtributteRepository Repository) : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
