using AutoMapper;
using Infrastructure;
using IoCRegister;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SL.Helper.Services.Mapper;
using SL.Infrastructure;
using SL.IoC;
using System;
using System.IO;
using System.Windows.Forms;
using UI.TextilSoft.MainForm;
using UI.TextilSoft.SubForms.Configuracion.Composite;

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
            var mainForm = services.GetRequiredService<FmPatenteFamilia>();
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
            services.AddSingleton<FmPatenteFamilia>();

            
            services.AddDbContext<ServiceLayerDbContext>(options => options.UseSqlServer(GetServiceLayerConnectionString())); //Usamos dos contextos para dos bases de datos distintas

            services.AddAutoMapper(typeof(FmPatenteFamilia));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Mapping());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper); // Singleton al Mapper para los controllers (ahi se haria el traspaso de clases)
            services.ConfigureIoC(Configuration); //LLamo a la clase de IoCRegister que contiene IServiceCollection 
            services.ConfigureIoCSL(Configuration); //LLamo a la clase de IoCRegister que contiene IServiceCollection de la capa de servicios
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

        /// <summary>
        /// Levanta el appsettings y obtiene el string a la conexion de la base de datos
        /// </summary>
        /// <returns>Devuelve la conexion</returns>
        private static string GetConnectionString()
        {
            var connectionString = Configuration.GetConnectionString("SqlConnection");
            return connectionString;
        }

        private static string GetServiceLayerConnectionString()
        {
            var connectionString = Configuration.GetConnectionString("SqlConnectionServiceLayer");
            return connectionString;
        }
    }
}