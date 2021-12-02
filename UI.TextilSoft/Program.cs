using AutoMapper;
using Contracts.Controllers;
using Infrastructure;
using IoCRegister;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServiceLayer.Services.Mapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Controllers;
using UI.TextilSoft.MainForm;

namespace UI.TextilSoft
{
    static class Program
    {
        public static IConfiguration Configuration;
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
            var mainForm = services.GetRequiredService<FmTextilSoft>();
            Application.Run(mainForm);
        }

        /// <summary>
        /// Configuracion de Inyeccion de dependencia
        /// </summary>
        /// <param name="services"></param>
        private static void ConfigureServices(IServiceCollection services) // Aca configuramos la inyeccion de dependencia
        {
            services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(GetConnectionString())); //Al contexto le agrego la conexion de la base de datos
            services.AddSingleton<FmTextilSoft>();

            services.AddAutoMapper(typeof(FmTextilSoft));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperHelper());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper); // Singleton al Mapper para los controllers (ahi se haria el traspaso de clases

            services.ConfigureIoC(Configuration); //LLamo a la clase de IoCRegister que contiene IServiceCollection 

        }

        /// <summary>
        /// Levanta el appsettings y obtiene el string a la conexion de la base de datos
        /// </summary>
        /// <returns>Devuelve la conexion</returns>
        public static string GetConnectionString() // Levanto el json y agarro la connstring
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
            var connectionString = Configuration.GetConnectionString("SqlConnection");
            return connectionString;
        }
    }
}