using MiniEcommerce.Domain.Entities;
using MiniEcommerce.Domain.Interfaces.Repository;
using MiniEcommerce.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Service.Service
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }


        public Task DeleteAsync(Product item)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public IList<Task<Product>> GetByIdsAsync(IList<int> ids)
        {
            throw new NotImplementedException();
        }

        public Task<Product> InsertAsync(Product item)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
