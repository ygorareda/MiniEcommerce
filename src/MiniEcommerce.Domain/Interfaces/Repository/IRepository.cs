using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Domain.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        public Task<T> GetByIdAsync(int id);
        public Task<IList<T>> GetAllAsync();
        public Task InsertAsync(T item);
        public Task UpdateAsync(T item);
        public Task DeleteAsync(int id);
    }
}
