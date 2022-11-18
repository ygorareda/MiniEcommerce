using Microsoft.EntityFrameworkCore;
using MiniEcommerce.Data.Context;
using MiniEcommerce.Domain.Entities;
using MiniEcommerce.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly PostgreeContext _context = null;
        private DbSet<T> dbSet = null;

        public Repository(PostgreeContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public Task DeleteAsync(T item)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await dbSet.SingleOrDefaultAsync(it => it.Id.Equals(id));
        }

        public IList<Task<T>> GetByIdsAsync(IList<int> ids)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}
