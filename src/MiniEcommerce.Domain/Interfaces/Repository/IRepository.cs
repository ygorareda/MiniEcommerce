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
        public IList<Task<T>> GetByIdsAsync(IList<int> ids);
        public Task<T> InsertAsync(T item);
        public Task<T> UpdateAsync(T item);
        public Task DeleteAsync(T item);
    }
}
