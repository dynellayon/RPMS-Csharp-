using Microsoft.EntityFrameworkCore;
using RPMS.Application.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly RpmsDbContext _dbContext;

        public GenericRepository(RpmsDbContext DbContext)
        {
            _dbContext = DbContext;
        }
        public async Task<T> Add(T entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> Exists(object id)
        {
            var entity = await Get(id);
            return entity != null;

        }

        public async Task<T> Get(object UserId)
        {
            return await _dbContext.Set<T>().FindAsync(UserId);
        }

        public async Task<List<T>> GetAll(T entity)
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
