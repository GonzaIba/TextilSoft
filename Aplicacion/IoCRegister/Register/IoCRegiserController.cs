using Contracts.Controllers;
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
    internal static class IoCRegisterController
    {
        internal static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return
              assembly.GetTypes()
                      .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                      .ToArray();
        }

        internal static IServiceCollection RegisterControllers(this IServiceCollection services)
        {
            Type[] Controllers = GetTypesInNamespace(Assembly.Load("UI.TextilSoft"), "UI.TextilSoft.Controllers");
            //Type[] IControllers = GetTypesInNamespace(Assembly.Load("Contracts"), "Contracts.Controllers");

            //var Controllers = typeof(ProveedoresController).GetGenericTypeDefinition();
            var IControllers = typeof(IProveedoresController).Assembly.GetTypes(t => t.IsInterface);

            services = IControllers?.Aggregate(services, (service, iRepository) =>
            {
                var repository = Controllers[0].Assembly.FindType(t => t.IsClass && iRepository.IsAssignableFrom(t));
                if (repository != null)
                {
                    service.AddTransient(iRepository, repository);
                }
                return service;
            });
            return services;
        }
    }
}
