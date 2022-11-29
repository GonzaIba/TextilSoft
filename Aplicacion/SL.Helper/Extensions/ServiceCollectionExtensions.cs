using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static TSettings AddConfig<TSettings>(this IServiceCollection services, IConfiguration configuration, Action<BinderOptions> configureOptions = null)
            where TSettings : class, new()
        {
            if (services == null) { throw new ArgumentNullException(nameof(services)); }
            if (configuration == null) { throw new ArgumentNullException(nameof(configuration)); }

            var settings = configuration.Get<TSettings>(configureOptions);
            services.TryAddSingleton(settings);
            return settings;
        }

        public static TSettings AddConfig<TSettings>(this IServiceCollection services, IConfiguration configuration, string sectionKey, Action<BinderOptions> configureOptions = null)
            where TSettings : class, new()
        {
            IConfigurationSection section = null;
            if (!string.IsNullOrEmpty(sectionKey))
            {
                var TotalSections = sectionKey.Split('.');
                section = (TotalSections.Count() <= 1) ? configuration.GetSection(sectionKey) : TotalSections.GetSection(configuration);
            }
            return services.AddConfig<TSettings>(section ?? configuration, configureOptions);
        }

        public static TSettings AddConfig<ISettings, TSettings>(this IServiceCollection services, IConfiguration configuration, Action<BinderOptions> configureOptions)
            where ISettings : class
            where TSettings : class, ISettings, new()
        {
            if (services == null) { throw new ArgumentNullException(nameof(services)); }
            if (configuration == null) { throw new ArgumentNullException(nameof(configuration)); }

            var settings = Get<TSettings>(configuration, configureOptions);
            services.TryAddSingleton<ISettings>(settings);
            return settings;
        }

        public static TSettings AddConfig<TSettings>(this IServiceCollection services, IConfiguration configuration, Type baseClass, Action<BinderOptions> configureOptions = null)
            where TSettings : Type, new()
        {
            IConfigurationSection section = null;
            object Class = Activator.CreateInstance(baseClass);
            //baseClass.GetFullNameSections<baseClass>(configuration,services);
            //string FullConfig = String.Empty;
            //FullConfig = FullConfig.Remove(FullConfig.Length - 1);

            //if (!string.IsNullOrEmpty(FullConfig))
            //{
            //    var TotalSections = FullConfig.Split('.');
            //    section = (TotalSections.Count() <= 1) ? configuration.GetSection(FullConfig) : TotalSections.GetSection(configuration);
            //}
            return null;
        }

        private static TSettings Get<TSettings>(IConfiguration configuration, Action<BinderOptions> configureOptions)
        {
            if (configureOptions == null)
                configureOptions = options => { };

            return configuration.Get<TSettings>(configureOptions);
        }
        









        


        private static IConfigurationSection GetSection(this string[] Elements, IConfiguration configuration)
        {
            IConfigurationSection section = null;
            //recorremos los elementos...
            Elements.ToList().ForEach(element =>
            {
                //Si es null obtenemos la primera sección
                section = section == null ? configuration.GetSection(element) : section.GetSection(element);
            });
            return section;
        }
        
        public static void GetFullNameSections<TSettings>(this Type Tipo ,IConfiguration configuration, IServiceCollection services , string fullname = "")
            where TSettings : Type, new()
        {
            IConfigurationSection section = null;
            string FullName = fullname == "" ? Tipo.Name+"." : fullname; //Si viene string vacio es porque es la primer llamada, por ende es la clase padre...

            if (string.IsNullOrEmpty(fullname))
            {
                section = configuration.GetSection(Tipo.Name);
                var settings = configuration.Get<TSettings>();
                services.TryAddSingleton(settings);
            }

            //Recorremos con foreach de linq. La idea es que obtengamos las propiedades utilizando yield para optimizacíón
            Tipo.GetPropertiesBaseClass().Where(x =>x.PropertyType.IsClass).ToList().ForEach(property =>
            {
                section = section.GetSection(property.PropertyType.Name);
                var settings = section.Get<TSettings>();
                services.TryAddSingleton(settings);
                
                property.PropertyType.GetFullNameSections<TSettings>(configuration, services, FullName += property.PropertyType.Name + ".");
                //Si la propiedad es clase, obtenemos todas las propiedades hija, si la hija es clase recorremos sus propiedades y asi sucesivamente...
            });
        }
        
        private static IEnumerable<PropertyInfo> GetPropertiesBaseClass(this Type Tipo)
        {
            foreach (var property in Tipo.GetProperties().ToList())
            {
                yield return property;
            }
        }
    }
}
