using System.Collections.Generic;
using System.Threading.Tasks;
using XPAND.Infrastructure.Repository;

namespace XPAND.BL.Services
{
    public class Service<TEntity> : IService<TEntity>
        where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;
        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public async Task Add(TEntity entity)
        {
            await _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        public async Task<List<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
