using PopFake.Data;
using PopFake.Models;
using PopFake.Repository.GenericRepository;
using PopFake.Repository.Interfaces;

namespace PopFake.Repository.Repositorys;

public class ExampleRepository : GenericRepository<ExampleEntity>, IExampleRepository
{
    public ExampleRepository(DataContext context) : base(context)
    {
    }
}