using AutoMapper;
using Contracts.Repositories;
using Domain.Models;
using Infrastructure;
using Infrastructure.Repositories;
using IoCRegister;
using LiveCharts.Wpf;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SL.Business.Services;
using SL.Contracts;
using SL.Contracts.Repositories;
using SL.Contracts.Services;
using SL.Domain.Entities;
using SL.Domain.Model;
using SL.EmailHelper.Configurations;
using SL.Helper.Configurations;
using SL.Helper.Extensions;
using SL.Helper.Services.Log4net;
using SL.Helper.Services.Mapper;
using SL.Infrastructure;
using SL.IoC;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using UI.TextilSoft.Background;
using UI.TextilSoft.Factory;
using UI.TextilSoft.MainForm;
using UI.TextilSoft.Mapeo;
using UI.TextilSoft.SubForms.Configuracion;
using ILogger = SL.Helper.Services.Log4net.ILogger;

namespace UI.TextilSoft
{
    static class Program
    {
        public static IConfiguration Configuration;
        public static IServiceCollection _services;
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
            var factory = services.GetRequiredService<IControllerFactory>();
            var taskresolver = new TaskResolver(services, factory);
            InitTaskResolver(taskresolver);
            bool IsDevelopment = Configuration.GetSection("Environment").Value.ToString() == "DEVELOPMENT" ? true : false;
            int CompanyId = Convert.ToInt32(Configuration.GetSection("CompanyConfiguration:CompanyId").Value);
            string CompanyApiKey = Configuration.GetSection("CompanyConfiguration:CompanyApiKey")?.Value?.ToString() ?? "";
            var CompanyService = services.GetRequiredService<ICompanyService>();
            UpdateDatabases(services);
            Form mainForm = null;
            if (CompanyService.ExistCompany(CompanyId, CompanyApiKey))
            {
                if (CompanyService.CanUseLoginAndRegister(CompanyId))
                    mainForm = services.GetRequiredService<Inicio>();
                else
                    mainForm = services.GetRequiredService<FmTextilSoft>();

                Application.Run(mainForm);
            }
            else
            {
                if (IsDevelopment)
                {
                    GenerateCompany(services, ref CompanyId, CompanyApiKey);
                    mainForm = services.GetRequiredService<Inicio>();
                    Application.Run(mainForm);
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private static async void InitTaskResolver(TaskResolver taskResolver)
        {
            await Task.Run(async () =>
            {
                //Not priority
                await taskResolver.StartAsync(new CancellationToken());

            });
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// Configuracion de Inyeccion de dependencia
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureServices(IServiceCollection services) // Aca configuramos la inyeccion de dependencia
        {
            _services = services;
            ConfigurationBuild();
            services.AddDbContext<ApplicationDbContext>
            (
                options => options
                .UseSqlServer(GetConnectionString(), builder =>
                    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null)) //Al contexto le agrego la conexion de la base de datos
                //En esta parte configuramos el entity framework para ver los querys en consola (IMPORTANTE: desactivarlo en produccion)
                .EnableSensitiveDataLogging()
                .UseLoggerFactory(_loggerFactory), ServiceLifetime.Transient
            ); ;
            
            //Hacemos un singleton a ambas aplicaciones por si desea usar login o no.
            services.AddSingleton<FmLobby>();
            services.AddSingleton<FmTextilSoft>();
            services.AddSingleton<Inicio>();
            services.AddSingleton<IControllerFactory,ControllerFactory>();
            services.AddSingleton<ILogger, Logger>();

            services.AddConfig<CompanyConfiguration>(Configuration, nameof(CompanyConfiguration));

            services.AddDbContext<ServiceLayerDbContext>(options => options.UseSqlServer(GetServiceLayerConnectionString())); //Usamos dos contextos para dos bases de datos distintas
            services.AddSingleton(typeof(Contracts.Repositories.IGenericRepository<>), typeof(GenericRepository<>));
            services.AddAutoMapper(typeof(FmLobby));
            services.AddAutoMapper(typeof(FmTextilSoft));
            services.AddAutoMapper(typeof(Inicio));
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
            if(!string.IsNullOrEmpty(Configuration.GetSection("TemphLog").Value.ToString()))
                AppDomain.CurrentDomain.SetData("TemphLog", Configuration.GetSection("TemphLog").Value.ToString());
            else
                AppDomain.CurrentDomain.SetData("TemphLog", AppDomain.CurrentDomain.BaseDirectory + "/Logs");

            services.AddHostedService<TaskResolver>();
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

        private static void VerifyBusinessTables(IServiceProvider services,int companyId)
        {
            var dbContext = services.GetRequiredService<ApplicationDbContext>();
            var SLdbContext = services.GetRequiredService<ServiceLayerDbContext>();
            //Service Layer
            //Primero creamos un usuario admin por default
            var UsuarioRepository = services.GetRequiredService<IUsuarioRepository>();
            var PermisoRepository = services.GetRequiredService<IPermisoRepository>();

            if (!PermisoRepository.Get(x => x.CompanyId == companyId).Where(x => x.Permiso.ToUpper() == "ADMINISTRADOR").Any())
            {
                //Si no hay un permiso Administrador en la tabla permiso lo crea
                PermisoModel permisoModel = new PermisoModel
                {
                    CompanyId = companyId,
                    Permiso = "ADMINISTRADOR",
                    Nombre = "admin"
                };
                SLdbContext.Add(permisoModel);
                try
                {
                    SLdbContext.SaveChanges();
                }
                catch (Exception)
                {
                }

            }



            //Negocio
            var estadoPedidoRepository = services.GetRequiredService<IEstadoPedidoRepository>();
            if (!estadoPedidoRepository.TableNoTracking.Any())
            {
                // Si no hay registros, insertar los valores por defecto
                var estadosPedido = new List<EstadoPedidoModel>
                {
                    new EstadoPedidoModel { Estado = "Sin Asignar", Active = true },
                    new EstadoPedidoModel { Estado = "En Producción", Active = true },
                    new EstadoPedidoModel { Estado = "En Depósito", Active = true },
                    new EstadoPedidoModel { Estado = "Entregado", Active = true },
                    new EstadoPedidoModel { Estado = "Cancelado", Active = true },
                };

                dbContext.AddRange(estadosPedido);
                dbContext.SaveChanges();
            }
        }

        private static void GenerateCompany(IServiceProvider services, ref int companyId, string companyApiKey)
        {
            var SLdbContext = services.GetRequiredService<ServiceLayerDbContext>();
            CompanyModel companyModel = new CompanyModel();
            companyModel.CompanyApiKey = companyApiKey;
            companyModel.CompanyLocation = "Sarasa";
            companyModel.CompanyName = "UAI-Diploma";
            companyModel.CompanyCuil = "20428862784";
            companyModel.CompanyMail = "Diploma@alumnos.UAI.edu.ar";
            companyModel.CompanyPhone = "9999-9999";
            SLdbContext.Add(companyModel);
            SLdbContext.SaveChanges();
            companyId = companyModel.CompanyId;
        }

        private static void UpdateDatabases(IServiceProvider services)
        {
            var dbContext = services.GetRequiredService<ApplicationDbContext>();
            var SLdbContext = services.GetRequiredService<ServiceLayerDbContext>();

            dbContext.Database.Migrate();
            SLdbContext.Database.Migrate();
        }
    }
}