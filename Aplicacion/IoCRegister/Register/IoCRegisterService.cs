using Business.Services;
using Contracts.Services;
using Microsoft.Extensions.DependencyInjection;
using SL.Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IoCRegister.Register
{
    internal static class IoCRegisterService
    {
        internal static IServiceCollection RegisterBusinessLayer(this IServiceCollection services)
        {
            var genericType = typeof(IGenericService<>).GetGenericTypeDefinition();
            var iServicesTypes = typeof(IGenericService<>).Assembly.GetTypes(t => t.IsInterface && t.ImplementsGenericInterface(genericType));

            services = iServicesTypes.Aggregate(services, (service, iServiceType) =>
            {
                var serviceType = typeof(GenericService<>).Assembly.FindType(t => t.IsClass && iServiceType.IsAssignableFrom(t));
                if (serviceType != null)
                {
                    service.AddTransient(iServiceType, serviceType);
                }
                return service;
            });

            return services;
        }
    }
}
