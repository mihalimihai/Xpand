using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XPAND.Infrastructure.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Add(TEntity entity);
        void Delete(int id);
        void Update(TEntity entity);
    }
}
