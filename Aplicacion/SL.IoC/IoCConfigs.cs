using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SL.IoC.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.IoC
{
    public static class IoCConfigs
    {
        public static IServiceCollection ConfigureIoCSL(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterDataLayer(configuration);
            services.RegisterUnitOfWork();
            services.RegisterBusinessLayer();
            services.RegisterControllers();
            return services;
        }
    }
}
