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
        public Task<IList<Product>> GetAllAsync();
        public Task InsertAsync(Product item);
        public Task UpdateAsync(Product item);
        public Task DeleteByIdAsync(int id);
    }
}
