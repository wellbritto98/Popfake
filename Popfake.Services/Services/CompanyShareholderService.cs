using PopFake.Models;
using PopFake.Repository.Interfaces;
using PopFake.Services.GenericService;
using PopFake.Services.Interfaces;

namespace PopFake.Services
{
    public class CompanyShareholderService : GenericService<CompanyShareholder>, ICompanyShareholderService
    {
        private readonly ICompanyShareholderRepository _Repository;

        public CompanyShareholderService(ICompanyShareholderRepository Repository) : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
