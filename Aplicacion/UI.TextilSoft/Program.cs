using AutoMapper;
using Contracts.Repositories;
using Domain.Models;
using Infrastructure;
using Infrastructure.Repositories;
using IoCRegister;
using LiveCharts.Wpf;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net;
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
using log4net.Repository.Hierarchy;
using Logger = SL.Helper.Services.Log4net.Logger;
using Microsoft.Data.SqlClient;
using NAudio.Gui;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using SL.EmailHelper;
using System.Windows.Media.Media3D;
using UI.TextilSoft.SubForms.Pedidos.CargarPedido;
using Contracts.Controllers;
using Domain.Entities;
using UI.TextilSoft.Controllers;
using System.ComponentModel.Design;

namespace UI.TextilSoft
{
    static class Program
    {
        public static IConfiguration Configuration;
        public static IServiceCollection _services;
        private static readonly Microsoft.Extensions.Logging.ILoggerFactory _loggerFactory = LoggerFactory.Create(builder => builder.AddConsole().AddDebug());

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            // Aqu� va el c�digo para iniciar tu aplicaci�n


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
            int CompanyId = Convert.ToInt32(Configuration.GetSection("CompanyConfiguration:CompanyId").Value);
            Configuration = services.GetRequiredService<IConfiguration>();
            var factory = services.GetRequiredService<IControllerFactory>();
            var taskresolver = new TaskResolver(services, factory);
            InitTaskResolver(taskresolver);
            bool IsDevelopment = Configuration.GetSection("Environment").Value.ToString() == "DEVELOPMENT" ? true : false;
            string CompanyApiKey = Configuration.GetSection("CompanyConfiguration:CompanyApiKey")?.Value?.ToString() ?? "";
            var CompanyService = services.GetRequiredService<ICompanyService>();
            UpdateDatabases(services);
            Form mainForm = null;
            if (CompanyService.ExistCompany(CompanyId, CompanyApiKey))
            {
                if (CompanyService.CanUseLoginAndRegister(CompanyId))
                    mainForm = services.GetRequiredService<Inicio>();
                else
                    mainForm = services.GetRequiredService<Inicio>();

                VerifyBusinessTables(services,CompanyId);
                Application.Run(mainForm);
            }
            else
            {
                if (IsDevelopment)
                {
                    GenerateCompany(services, ref CompanyId, CompanyApiKey);
                    VerifyBusinessTables(services, CompanyId);
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
                    builder.EnableRetryOnFailure(2, TimeSpan.FromSeconds(2), null)) //Al contexto le agrego la conexion de la base de datos
                //En esta parte configuramos el entity framework para ver los querys en consola (IMPORTANTE: desactivarlo en produccion)
                .EnableSensitiveDataLogging()
                .UseLoggerFactory(_loggerFactory), ServiceLifetime.Transient
            ); ;
            
            //Hacemos un singleton a ambas aplicaciones por si desea usar login o no.
            services.AddSingleton<FmLobby>();
            services.AddSingleton<FmTextilSoft>();
            services.AddSingleton<FmCrearPedido>();
            services.AddSingleton<Inicio>();
            services.AddSingleton<IControllerFactory,ControllerFactory>();
            services.AddSingleton<ILogger, Logger>();

            services.AddSingleton<IPedidosController<ListarPedidosEntity>, PedidosController<ListarPedidosEntity>>();
            services.AddSingleton<IPedidosController<ListarPedidosFabricaEntity>, PedidosController<ListarPedidosFabricaEntity>>();
            services.AddSingleton<IPedidosController<SeguimientoPedidosEntity>, PedidosController<SeguimientoPedidosEntity>>();

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
            AppDomain.CurrentDomain.SetData("InfraestructuraRootPath", Infraestructura);

            if (!string.IsNullOrEmpty(Configuration.GetSection("TemphLog").Value.ToString()))
                AppDomain.CurrentDomain.SetData("TemphLog", Configuration.GetSection("TemphLog").Value.ToString());
            else
                AppDomain.CurrentDomain.SetData("TemphLog", AppDomain.CurrentDomain.BaseDirectory + "/Logs");
            
            services.AddHostedService<TaskResolver>();

            
            var serviceProvider = services.BuildServiceProvider();
            int CompanyId = Convert.ToInt32(Configuration.GetSection("CompanyConfiguration:CompanyId").Value);
            ConfigureSendGridEmail(serviceProvider,services , CompanyId);
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
            var SldbContext = services.GetRequiredService<ServiceLayerDbContext>();
            var usuarioRepository = services.GetRequiredService<IUsuarioRepository>();
            var permisoRepository = services.GetRequiredService<IPermisoRepository>();
            var usuario_PermisoRepository = services.GetRequiredService<IUsuario_PermisoRepository>();

            var empleadosRepository = services.GetRequiredService<IEmpleadosRepository>();

            UsuarioModel usuario = new();
            PermisoModel permisoModel = new();
            EmpleadosModel empleadosModel = new();
            if (!usuarioRepository.Get(x => x.Nombre.ToLower() == "admin").Any())
            {
                usuario.Nombre = "admin";
                usuario.Contrase�a = "admin";
                usuario.Email = "diploma@alumnos.UAI.edu.ar";
                usuario.EmailConfirmado = true;
                usuario.CompanyId = companyId;
                usuario.Active = true;
                usuario.IsOwner = true;
                usuario.DNI = 12345678;
                usuarioRepository.Insert(usuario);
                SldbContext.SaveChanges();

            }
            else
                usuario = usuarioRepository.Get(x => x.Nombre == "admin").FirstOrDefault();

            if (!empleadosRepository.Get(x => x.Nombre.ToLower() == "PRUEBA").Any())
            {
                empleadosModel.DNI = usuario.DNI;
                empleadosModel.Nombre = "PRUEBA";
                empleadosModel.Legajo = "ASDR-JPT";
                empleadosModel.Apellido = "PRUEBA";
                empleadosModel.Residencia = "Calle falsa 123";
                //empleadosRepository.Insert(empleadosModel);
                dbContext.Add(empleadosModel);
                dbContext.SaveChanges();
            }

            if (!permisoRepository.Get(x => x.Permiso.ToLower() == "EsAdmin").Any())
            {
                permisoModel.Nombre = "admin";
                permisoModel.Permiso = "EsAdmin";
                permisoModel.CompanyId = companyId;
                permisoRepository.Insert(permisoModel);
                SldbContext.SaveChanges();
            }
            else
                permisoModel = permisoRepository.Get(x => x.Permiso.ToLower() == "EsAdmin").FirstOrDefault();

            if (!usuario_PermisoRepository.Get(x => x.Id_Permiso == permisoModel.Id_Permiso && x.Id_Usuario == usuario.Id_Usuario).Any())
            {
                Usuario_PermisoModel usuario_PermisoModel = new();
                usuario_PermisoModel.Id_Usuario = usuario.Id_Usuario;
                usuario_PermisoModel.Id_Permiso = permisoModel.Id_Permiso;
                usuario_PermisoRepository.Insert(usuario_PermisoModel);
            }
            
            SldbContext.SaveChanges();

            //Negocio
            var estadoPedidoRepository = services.GetRequiredService<IEstadoPedidoRepository>();
            if (!estadoPedidoRepository.TableNoTracking.Any())
            {
                // Si no hay registros, insertar los valores por defecto
                var estadosPedido = new List<EstadoPedidoModel>
                {
                    new EstadoPedidoModel { Estado = "SinAsignar", Active = true },
                    new EstadoPedidoModel { Estado = "EnProducci�n", Active = true },
                    new EstadoPedidoModel { Estado = "EnDep�sito", Active = true },
                    new EstadoPedidoModel { Estado = "Entregado", Active = true },
                    new EstadoPedidoModel { Estado = "Cancelado", Active = true },
                };

                dbContext.AddRange(estadosPedido);
                dbContext.SaveChanges();
            }
            
            var estadoPedidoFabricaRepository = services.GetRequiredService<IEstadoPedidoFabricaRepository>();
            if (!estadoPedidoFabricaRepository.TableNoTracking.Any())
            {
                // Si no hay registros, insertar los valores por defecto
                var estadosPedido = new List<EstadoPedidoFabricaModel>
                {
                    new EstadoPedidoFabricaModel { Estado = "SinAsignar", Active = true },
                    new EstadoPedidoFabricaModel { Estado = "EnProducci�n", Active = true },
                    new EstadoPedidoFabricaModel { Estado = "Terminado", Active = true },
                    new EstadoPedidoFabricaModel { Estado = "EnDep�sito", Active = true },
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
            try
            {
                var dbContext = services.GetRequiredService<ApplicationDbContext>();
                var SldbContext = services.GetRequiredService<ServiceLayerDbContext>();
                if (!dbContext.Database.CanConnect())
                    dbContext.Database.Migrate();

                if (!SldbContext.Database.CanConnect())
                    SldbContext.Database.Migrate();
            }
            catch (Exception ex)
            {

                throw;
            }

        }


        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Crea una copia de la colecci�n OpenForms
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();

            // Cierra todos los formularios abiertos
            foreach (Form form in forms)
            {
                if(form is not FmError)
                    form.Hide();
            }
            FmError fmError = new(Tools.TypeErrorEnum.Generic);
            fmError.ShowDialog();
            Application.Exit();
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // Crea una copia de la colecci�n OpenForms
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();

            // Cierra todos los formularios abiertos
            foreach (Form form in forms)
            {
                form.Close();
            }

            // Comprueba si la excepci�n es de SQL Server
            if (e.ExceptionObject is SqlException)
            {
                SqlException sqlEx = e.ExceptionObject as SqlException;
                // Aqu� manejas la excepci�n de SQL Server
                FmError fmError = new(Tools.TypeErrorEnum.SqlConnect);
                fmError.ShowDialog();
            }
            else
            {
                FmError fmError = new(Tools.TypeErrorEnum.Generic);
                fmError.ShowDialog();
            }
        }

        private static void ConfigureSendGridEmail(IServiceProvider services,IServiceCollection serviceCollection, int companyID)
        {
            var SendgridRepository = services.GetRequiredService<ICompanySendGridConfigRepository>();
            var SendGridModel = SendgridRepository.Get(x => x.CompanyId == companyID).FirstOrDefault();
            if(SendGridModel != null)
            {
                serviceCollection.AddTransient<EmailSendGridConfiguration>(x => new EmailSendGridConfiguration
                {
                    ApiKey = SendGridModel.ApiKey,
                    From = SendGridModel.From,
                    DisplayName = SendGridModel.DisplayName,
                    ApiKeyId = SendGridModel.ApiKeyId
                });
            }
        }
    }
}