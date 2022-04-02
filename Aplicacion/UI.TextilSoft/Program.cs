using AutoMapper;
using Infrastructure;
using IoCRegister;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using SL.Business;
using SL.Contracts;
using SL.Helper.Controllers;
using SL.Helper.Services.Mapper;
using SL.Infrastructure;
using SL.IoC;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UI.TextilSoft.MainForm;

namespace UI.TextilSoft
{
    static class Program
    {
        private static IConfiguration Configuration;
        private static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder => builder.AddConsole().AddDebug());

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((services) =>
                {
                    ConfigureServices(services);
                })
                .Build();

            var services = host.Services;
            var mainForm = services.GetRequiredService<FmLogin>();
            Application.Run(mainForm);
        }

        /// <summary>
        /// Configuracion de Inyeccion de dependencia
        /// </summary>
        /// <param name="services"></param>
        private static void ConfigureServices(IServiceCollection services) // Aca configuramos la inyeccion de dependencia
        {
            ConfigurationBuild();
            services.AddDbContext<ApplicationDbContext>
            (
                options => options
                .UseSqlServer(GetConnectionString()) //Al contexto le agrego la conexion de la base de datos


                //En esta parte configuramos el entity framework para ver los querys en consola (IMPORTANTE: desactivarlo en produccion)
                .EnableSensitiveDataLogging()
                .UseLoggerFactory(_loggerFactory)
            );
            services.AddSingleton<FmTextilSoft>();
            services.AddScoped<FmLogin>();
            //services.AddEntityFrameworkSqlServer().AddDbContext<ServiceLayerDbContext>();
            //services.AddIdentity<IdentityUser, IdentityRole>(options =>
            // {
            //     options.SignIn.RequireConfirmedAccount = Convert.ToBoolean(Configuration["AuthenticationConfig:SignInRequireConfirmedAccount"]);
            //     options.User.RequireUniqueEmail = Convert.ToBoolean(Configuration["AuthenticationConfig:UserRequireUniqueEmail"]);
            //     options.Password.RequireDigit = Convert.ToBoolean(Configuration["AuthenticationConfig:PasswordConfig:RequireDigit"]);
            //     options.Password.RequireLowercase = Convert.ToBoolean(Configuration["AuthenticationConfig:PasswordConfig:RequireLowercase"]);
            //     options.Password.RequireUppercase = Convert.ToBoolean(Configuration["AuthenticationConfig:PasswordConfig:RequireUppercase"]);
            //     options.Password.RequireNonAlphanumeric = Convert.ToBoolean(Configuration["AuthenticationConfig:PasswordConfig:RequireNonAlphanumeric"]);
            //     options.Password.RequiredLength = Convert.ToInt32(Configuration["AuthenticationConfig:PasswordConfig:CountLength"]);
            //     options.Lockout.MaxFailedAccessAttempts = Convert.ToInt32(Configuration["AuthenticationConfig:MaxFailedAccessAttempts"]);
            // });
            //services.AddEntityFrameworkSqlServer().AddDbContext<ApplicationDbContext>();

            services.AddAutoMapper(typeof(FmTextilSoft));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Mapping());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper); // Singleton al Mapper para los controllers (ahi se haria el traspaso de clases)
            services.ConfigureIoC(Configuration); //LLamo a la clase de IoCRegister que contiene IServiceCollection 
            //services.ConfigureIoCSL(Configuration); //LLamo a la clase de IoCRegister que contiene IServiceCollection de la capa de servicios
        }

        /// <summary>
        /// Levanta el appsettings y obtiene el string a la conexion de la base de datos
        /// </summary>
        /// <returns>Devuelve la conexion</returns>
        private static string GetConnectionString()
        {
            var connectionString = Configuration.GetConnectionString("SqlConnection");
            return connectionString;
        }

        /// <summary>
        /// Instance Configuration
        /// </summary>
        public static void ConfigurationBuild()
        {
            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

    }

}