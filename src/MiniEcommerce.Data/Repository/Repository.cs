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


        public async Task<T> GetByIdAsync(int id)
        {
            return await dbSet.SingleOrDefaultAsync(it => it.Id.Equals(id));
        }

        public async Task<IList<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task InsertAsync(T item)
        {
            item.CreatedAt = DateTime.UtcNow;
            item.UpdatedAt = DateTime.UtcNow;

            await dbSet.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T item)
        {
            item.CreatedAt = DateTime.UtcNow;
            item.UpdatedAt = DateTime.UtcNow;
            dbSet.Update(item);

            await _context.SaveChangesAsync();

        }
        public async Task DeleteAsync(int id)
        {
            T item = await dbSet.SingleOrDefaultAsync(query => query.Id.Equals(id));
            dbSet.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}
