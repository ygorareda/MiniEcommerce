using Microsoft.Extensions.DependencyInjection;
using MiniEcommerce.Data.Context;
using MiniEcommerce.Data.Repository;
using MiniEcommerce.Domain.Interfaces.Repository;
using MiniEcommerce.Domain.Interfaces.Service;
using MiniEcommerce.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.CrossCutting.DepedencyInjection
{
    public static class DepedencyInjection
    {

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddDbContext<PostgreeContext>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
