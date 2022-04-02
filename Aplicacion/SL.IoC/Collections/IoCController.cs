using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using SL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SL.IoC.Collections
{
    internal static class IoCController
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
            //Type[] Controllers = GetTypesInNamespace(Assembly.Load("SL.Helper"), "SL.Helper.Controllers");
            //Type[] IControllers = GetTypesInNamespace(Assembly.Load("SL.Contracts"), "SL.Contracts");
            //foreach (Type icontrolador in IControllers)//interfaces icontrolador...
            //{
            //    var controller = Controllers.Where(x => x.IsAssignableTo(icontrolador) && icontrolador.IsInterface).FirstOrDefault();
            //    if (controller != null)
            //    {
            //        services.AddTransient(icontrolador, controller);
            //    }
            //}

            return services;
        }
    }
}
