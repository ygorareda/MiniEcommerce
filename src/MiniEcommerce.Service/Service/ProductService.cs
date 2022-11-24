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


        public async Task DeleteByIdAsync(int id)
        {

            await _repository.DeleteAsync(id);
        }

        public async Task<IList<Product>> GetAllAsync()
        {
            return await _repository.GetAllAsync();

        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task InsertAsync(Product item)
        {
            await _repository.InsertAsync(item);
        }

        public async Task UpdateAsync(Product item)
        {
           await _repository.UpdateAsync(item);
        }
    }
}
