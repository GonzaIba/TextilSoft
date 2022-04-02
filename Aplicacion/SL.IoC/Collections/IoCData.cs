using Microsoft.Extensions.DependencyInjection;
using SL.Contracts;
using SL.Infrastructure;
using SL.Infrastructure.UoW;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.IoC.Collections
{
    internal static class IoCData
    {
        internal static IServiceCollection RegisterUnitOfWork(this IServiceCollection services)
        {
            //services.AddScoped<ServiceLayerDbContext, UnitOfWork>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
