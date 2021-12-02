using Microsoft.Extensions.DependencyInjection;
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
            Type[] IControllers = GetTypesInNamespace(Assembly.Load("Contracts"), "Contracts.Controllers");


            foreach (Type icontrolador in IControllers)//interfaces icontrolador...
            {
                var controller = Controllers.Where(x => x.IsAssignableTo(icontrolador) && icontrolador.IsInterface).FirstOrDefault();
                if(controller!=null)
                {
                    services.AddTransient(icontrolador, controller);
                }
            }

            return services;
        }
    }
}
