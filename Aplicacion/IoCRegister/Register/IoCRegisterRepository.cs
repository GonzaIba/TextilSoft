using Contracts.Repositories;
using Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SL.Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCRegister.Register
{
    internal static class IoCRegisterRepository
    {
        internal static IServiceCollection RegisterDataLayer(this IServiceCollection services, IConfiguration configuration)
        {
            var genericType = typeof(IGenericRepository<>).GetGenericTypeDefinition();
            var iRepositories = typeof(IGenericRepository<>).Assembly.GetTypes(t => t.IsInterface && t.ImplementsGenericInterface(genericType));

            services = iRepositories?.Aggregate(services, (service, iRepository) =>
            {
                var repository = typeof(ApplicationDbContext).Assembly.FindType(t => t.IsClass && iRepository.IsAssignableFrom(t));
                if (repository != null)
                {
                    service.AddTransient(iRepository, repository);
                }
                return service;
            });
            //services.AddTransient<IDataRepository>(s => new DataRepository(configuration.GetConnectionString("SqlConnection")));

            return services;
        }
    }
}
