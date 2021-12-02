using Contracts.Repositories;
using Contracts.Services;
using Infrastructure.UoW;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCRegister.Register
{
    internal static class IoCRegisterData
    {
        internal static IServiceCollection RegisterUnitOfWork(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();


            return services;
        }
    }
}
