using PopFake.Data;
using PopFake.Models;
using PopFake.Repository.GenericRepository;
using PopFake.Repository.Interfaces;

namespace PopFake.Repository.Repositorys;

public class CompanyShareholderRepository : GenericRepository<CompanyShareholder>, ICompanyShareholderRepository
{
    public CompanyShareholderRepository(DataContext context) : base(context)
    {
    }
}
