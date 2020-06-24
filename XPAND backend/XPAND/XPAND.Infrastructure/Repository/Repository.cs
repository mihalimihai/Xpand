using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPAND.Infrastructure.Entities;

namespace XPAND.Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly XpandDbContext _context;
        public Repository(XpandDbContext context)
        {
            _context = context;
        }
        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
        public async Task Add(TEntity entity)
        {
            await _context.AddAsync(entity);
            _context.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}
