using System.Collections.Generic;
using System.Threading.Tasks;

namespace XPAND.BL.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Add(TEntity entity);
        void Delete(int id);
        void Update(TEntity entity);
    }
}
