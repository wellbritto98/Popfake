using PopFake.Data;
using PopFake.Models;
using PopFake.Repository.GenericRepository;
using PopFake.Repository.Interfaces;

namespace PopFake.Repository.Repositorys;

public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
{
    public CompanyRepository(DataContext context) : base(context)
    {
    }
}
