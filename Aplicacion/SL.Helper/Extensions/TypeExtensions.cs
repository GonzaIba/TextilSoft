using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Extensions
{
    public static class TypeExtensions
    {
        /// <summary>
        /// Devuelve true si el Type implementa la interfaz
        /// </summary>
        /// <param name="type"></param>
        /// <param name="genericType"></param>
        /// <returns></returns>
        public static bool ImplementsGenericInterface(this Type type, Type genericType)
        {
            if (type == null)
            {
                return false;
            }
            return type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == genericType);
        }
    }
}
