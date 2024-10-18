using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Services.GenericService;
using PopFake.Services.Interfaces;

namespace PopFake.Services
{
    public class CompanyService : GenericService<Company>, ICompanyService
    {
        private readonly ICompanyRepository _Repository;

        public CompanyService(ICompanyRepository Repository) : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
