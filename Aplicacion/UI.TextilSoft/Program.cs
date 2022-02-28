using AutoMapper;
using Infrastructure;
using IoCRegister;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServiceLayer.Services.Mapper;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
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
            var mainForm = services.GetRequiredService<FmLogin>();
            Application.Run(mainForm);
        }

        /// <summary>
        /// Configuracion de Inyeccion de dependencia
        /// </summary>
        /// <param name="services"></param>
        private static void ConfigureServices(IServiceCollection services) // Aca configuramos la inyeccion de dependencia
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(GetConnectionString())); //Al contexto le agrego la conexion de la base de datos
            services.AddSingleton<FmLogin>();

            services.AddIdentityCore<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddAutoMapper(typeof(FmLogin));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperHelper());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper); // Singleton al Mapper para los controllers (ahi se haria el traspaso de clases)
            services.ConfigureIoC(Configuration); //LLamo a la clase de IoCRegister que contiene IServiceCollection 
        }

        /// <summary>
        /// Levanta el appsettings y obtiene el string a la conexion de la base de datos
        /// </summary>
        /// <returns>Devuelve la conexion</returns>
        private static string GetConnectionString() // Levanto el json y agarro la connstring
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
            var connectionString = Configuration.GetConnectionString("SqlConnection");
            //var connectionString2 = Configuration.GetConnectionString("SqlConnectionServiceLayer");
            //DateTime prueba = DateTime.Now;
            //DateTime fromdateStr = Convert.ToDateTime(string.Format("{0:dd-MM-yyyy HH:mm:ss}", prueba));
            //var settings = Configuration.GetSection("Testing").AsEnumerable().ToList();
            //var settings2 = Configuration.GetSection("Testing").GetSection("test1").Value;
            return connectionString;
        }

        private static dynamic GetSection(string Section, string Section2 = "", bool getchildren = false) // Levanto el json y agarro la connstring
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            if (Section != null && Section2 != null)
            {
                if (getchildren)
                    return Configuration.GetSection(Section).GetSection(Section2).GetChildren().ToList();
                else
                    return Configuration.GetSection(Section).GetSection(Section2).Value;
            }
            //var connectionString2 = Configuration.GetConnectionString("SqlConnectionServiceLayer");
            //DateTime prueba = DateTime.Now;
            //DateTime fromdateStr = Convert.ToDateTime(string.Format("{0:dd-MM-yyyy HH:mm:ss}", prueba));
            //var settings = Configuration.GetSection("AppConfig").GetSection("DatePattern").GetChildren().ToList();
            //var settings2 = Configuration.GetSection("Testing").GetSection("test1").Value;
            return "";
        }


    }

}