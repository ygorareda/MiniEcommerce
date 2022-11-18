using MiniEcommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Domain.Interfaces.Service
{
    public interface IProductService
    {
        public Task<Product> GetByIdAsync(int id);
        public IList<Task<Product>> GetByIdsAsync(IList<int> ids);
        public Task<Product> InsertAsync(Product item);
        public Task<Product> UpdateAsync(Product item);
        public Task DeleteAsync(Product item);
    }
}
