using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiniEcommerce.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Data
{
    public static class DbStartup
    {
        public static void ConfigureDbServices(this IServiceCollection services)
        {
            services.AddDbContext<PostgreeContext>();

        }


    }
}
