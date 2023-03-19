using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SL.Business.Services;
using SL.Contracts.Services;
using SL.EmailHelper.Configurations;
using SL.EmailHelper.Contracts;
using SL.EmailHelper.Factory;
using SL.EmailHelper.Services;
using SL.Helper.Extensions;
using SL.IoC.Collections;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.IoC
{
    public static class IoCConfigs
    {
        public static IServiceCollection ConfigureIoCSL(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterEmails(configuration);
            services.RegisterDataLayer(configuration);
            services.RegisterUnitOfWork();
            services.RegisterBusinessLayer();
            services.RegisterControllers();
            return services;
        }

        private static IServiceCollection RegisterEmails(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IEmailService, EmailService>();

            //services.AddTransient(typeof(IGenericEmailService), typeof(GenericEmailService));
            services.AddTransient<IEmailSendGridService, EmailSendgridService>();
            services.AddTransient<IEmailSmtpService, EmailSmtpService>();
            services.AddTransient<IGenericEmailFactory, GenericEmailFactory>();
            services.AddConfig<EmailConfiguration>(configuration, nameof(EmailConfiguration));
            //services.AddConfig<EmailSendGridConfiguration>(configuration, nameof(EmailConfiguration) + "." + nameof(EmailSendGridConfiguration));
            services.AddConfig<EmailSMTPConfiguration>(configuration, nameof(EmailConfiguration) + "." + nameof(EmailSMTPConfiguration));

            return services;
        }
    }
}
