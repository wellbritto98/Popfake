using PopFake.Models.Base;
using System.Threading.Tasks;
using System.Collections.Generic;
using PopFake.Repository.GenericRepository;

namespace PopFake.Services.GenericService
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public virtual async Task<T> GetByIdAsync(params object[] keyValues)
        {
            return await _repository.GetByIdAsync(keyValues);
        }


        public virtual async Task<T> AddAsync(T entity)
        {
            return await _repository.AddAsync(entity);
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public virtual async Task DeleteAsync(params object[] keyValues)
        {
            await _repository.DeleteAsync(keyValues);
        }
    }
}
