using AutoMapper;
using Infrastructure;
using IoCRegister;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SL.Business.Services;
using SL.Contracts.Repositories;
using SL.Contracts.Services;
using SL.EmailHelper.Configurations;
using SL.Helper.Configurations;
using SL.Helper.Extensions;
using SL.Helper.Services.Mapper;
using SL.Infrastructure;
using SL.IoC;
using System;
using System.IO;
using System.Windows.Forms;
using UI.TextilSoft.Configurations;
using UI.TextilSoft.MainForm;
using UI.TextilSoft.Mapeo;
using UI.TextilSoft.SubForms.Configuracion.Composite;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace UI.TextilSoft
{
    static class Program
    {
        public static IConfiguration Configuration;
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

            //High DPI
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((services) =>
                {
                    ConfigureServices(services);
                })
                .Build();

            var services = host.Services;

            Configuration = services.GetRequiredService<IConfiguration>();
            //bool UseLoginAndRegister = Convert.ToBoolean(Configuration.GetSection("Application:Security:UseLoginAndRegister").Value);
            int CompanyId = Convert.ToInt32(Configuration.GetSection("CompanyConfiguration:CompanyId").Value);
            string CompanyApiKey = Configuration.GetSection("CompanyConfiguration:CompanyApiKey")?.Value?.ToString() ?? "";
            var CompanyService = services.GetRequiredService<ICompanyService>();
            Form mainForm = null;
            if (CompanyService.ExistCompany(CompanyId, CompanyApiKey))
            {
                if (/*UseLoginAndRegister &&*/ CompanyService.CanUseLoginAndRegister(CompanyId))
                    mainForm = services.GetRequiredService<FmLogin>();
                else
                    mainForm = services.GetRequiredService<FmTextilSoft>();

                Application.Run(mainForm);
            }
            else
                Application.Exit();
        }
        
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

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
                .UseSqlServer(GetConnectionString(), builder =>
                    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null)) //Al contexto le agrego la conexion de la base de datos

                //En esta parte configuramos el entity framework para ver los querys en consola (IMPORTANTE: desactivarlo en produccion)
                .EnableSensitiveDataLogging()
                .UseLoggerFactory(_loggerFactory)
            );
            //Hacemos un singleton a ambas aplicaciones por si desea usar login o no.
            services.AddSingleton<FmLogin>();
            services.AddSingleton<FmTextilSoft>();

            services.AddConfig<CompanyConfiguration>(Configuration, nameof(CompanyConfiguration));

            services.AddDbContext<ServiceLayerDbContext>(options => options.UseSqlServer(GetServiceLayerConnectionString())); //Usamos dos contextos para dos bases de datos distintas
            services.AddAutoMapper(typeof(FmLogin));
            services.AddAutoMapper(typeof(FmTextilSoft));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Mapping()); //Para la SL
                mc.AddProfile(new BusinessMapping()); // Para la APP
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper); // Singleton al Mapper para los controllers (ahi se haria el traspaso de clases)
            services.ConfigureIoC(Configuration); //LLamo a la clase de IoCRegister que contiene IServiceCollection 
            services.ConfigureIoCSL(Configuration); //LLamo a la clase de IoCRegister que contiene IServiceCollection de la capa de servicios

            string result = services.GetType().Assembly.Location;
            FileInfo file = new FileInfo(result);
            var Infraestructura = file.Directory.Parent.Parent.Parent.Parent.FullName + @"\SL.Infrastructure";
            
            AppDomain.CurrentDomain.SetData("InfraestructuraRootPath", Infraestructura);

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