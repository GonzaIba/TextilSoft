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
using Contracts.Services;
using Business.Services;
using Domain.Enum;

namespace UI.TextilSoft
{
    static class Program
    {
        public static IConfiguration Configuration;
        public static IServiceCollection _services;
        private static readonly Microsoft.Extensions.Logging.ILoggerFactory _loggerFactory = LoggerFactory.Create(builder => builder.AddConsole().AddDebug());
        private static Random _rnd = new Random();
        
        /// <summary>v
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            // Aquí va el código para iniciar tu aplicación


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
            services.AddSingleton<IArmadoProductoService, ArmadoProductoService>();
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

            if (!string.IsNullOrEmpty(Configuration.GetSection("TemplatesConfig:TemphLog")?.Value?.ToString()))
                AppDomain.CurrentDomain.SetData("TemphLog", Configuration.GetSection("TemplatesConfig:TemphLog").Value.ToString());
            else
                AppDomain.CurrentDomain.SetData("TemphLog", AppDomain.CurrentDomain.BaseDirectory + "/Logs");

            if (!string.IsNullOrEmpty(Configuration.GetSection("TemplatesConfig:TempPath-ODT")?.Value?.ToString()))
                AppDomain.CurrentDomain.SetData("TempPath-ODT", Configuration.GetSection("TemplatesConfig:TempPath-ODT").Value.ToString());
            else
                AppDomain.CurrentDomain.SetData("TempPath-ODT", AppDomain.CurrentDomain.BaseDirectory + "/Temp");

            if (!string.IsNullOrEmpty(Configuration.GetSection("TemplatesConfig:TemplatePath-ODT")?.Value?.ToString()))
                AppDomain.CurrentDomain.SetData("TemplatePath-ODT", Configuration.GetSection("TemplatesConfig:TemplatePath-ODT").Value.ToString());
            else
                AppDomain.CurrentDomain.SetData("TemplatePath-ODT", AppDomain.CurrentDomain.BaseDirectory + "/Templates/Orden-De-Pago1.pdf");

            if (!string.IsNullOrEmpty(Configuration.GetSection("TemplatesConfig:TempPathName-ODT")?.Value?.ToString()))
                AppDomain.CurrentDomain.SetData("TempPathName-ODT", Configuration.GetSection("TemplatesConfig:TempPathName-ODT").Value.ToString());
            else
                AppDomain.CurrentDomain.SetData("TempPathName-ODT", "OrdenDeTrabajo-");


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

        private static void ConfigureSendGridEmail(IServiceProvider services, IServiceCollection serviceCollection, int companyID)
        {
            var SendgridRepository = services.GetRequiredService<ICompanySendGridConfigRepository>();
            var SendGridModel = SendgridRepository.Get(x => x.CompanyId == companyID).FirstOrDefault();
            if (SendGridModel != null)
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


        #region GenerateData
        private static void VerifyBusinessTables(IServiceProvider services, int companyId)
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
                usuario.Contraseña = "admin";
                usuario.Email = "diploma@alumnos.UAI.edu.ar";
                usuario.EmailConfirmado = true;
                usuario.CompanyId = companyId;
                usuario.Active = true;
                usuario.IsOwner = true;
                usuario.DNI = 12345678;
                usuario.EnableVolume = false;
                usuario.EnableSlicePanel = false;
                usuario.EnableAnimators = false;
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
                    new EstadoPedidoModel { Estado = "EnProducción", Active = true },
                    new EstadoPedidoModel { Estado = "EnDepósito", Active = true },
                    new EstadoPedidoModel { Estado = "Entregado", Active = true },
                    new EstadoPedidoModel { Estado = "Cancelado", Active = true },
                };

                dbContext.AddRange(estadosPedido);
                dbContext.SaveChanges();
            }

            var clientesRepository = services.GetRequiredService<IClientesRepository>();
            if (!clientesRepository.TableNoTracking.Any())
            {
                // Si no hay registros, insertar los valores por defecto
                var estadosPedido = new List<ClientesModel>
                {
                    new ClientesModel { DNI = "42886278", Nombre="Gonzalo", Apellido="Ibañez", EstadoCliente="Activo", FechaNac=DateTime.Now, Mail="gonza_28.00@hotmail.com", Telefono=1566178382, Residencia="Calle falsa 123", Active = true }
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
                    new EstadoPedidoFabricaModel { Estado = "EnProducción", Active = true },
                    new EstadoPedidoFabricaModel { Estado = "Terminado", Active = true },
                    new EstadoPedidoFabricaModel { Estado = "EnDepósito", Active = true },
                };

                dbContext.AddRange(estadosPedido);
                dbContext.SaveChanges();
            }

            var proveedoresRepository = services.GetRequiredService<IProveedoresRepository>();
            if (!proveedoresRepository.TableNoTracking.Any())
            {
                // Si no hay registros, insertar los valores por defecto
                var proveedor = new List<ProveedoresModel>
                {
                    new ProveedoresModel { Nombre = "Gonzalo",Mail="Gonza_28.00@hotmail.com", DNI="428862989", LugarEmpresa="Olivos", FechaNac=DateTime.Now, EstadoProveedor="Al dia", Active = true }
                };

                dbContext.AddRange(proveedor);
                dbContext.SaveChanges();
            }

            GenerateProductDetail(services, companyId);
        }

        private static void GenerateProductDetail(IServiceProvider services, int companyId)
        {
            var dbContext = services.GetRequiredService<ApplicationDbContext>();
            
            var tipoPrendaRepository = services.GetRequiredService<ITipoPrendaRepository>();
            if (!tipoPrendaRepository.TableNoTracking.Any())
            {
                var tipoPrendas = new List<TipoPrendaModel>();

                // Obtén todos los valores del enum TipoPrendaEnum
                var tipoPrendaValues = Enum.GetValues(typeof(TipoPrendaEnum));
                // Itera sobre los valores del enum y agrega instancias a la lista estadosPedido
                foreach (TipoPrendaEnum tipoPrenda in tipoPrendaValues)
                {
                    tipoPrendas.Add(new TipoPrendaModel { TipoPrenda = tipoPrenda.ToString(), Active = true });
                }

                dbContext.AddRange(tipoPrendas);
                dbContext.SaveChanges();
            }

            var telaBaseRepository = services.GetRequiredService<ITelaBaseRepository>();
            if (!telaBaseRepository.TableNoTracking.Any())
            {
                var estadosPedido = new List<TelaBaseModel>
                {
                    new TelaBaseModel { Nombre = "No Lleva",Codigo = "0", Active = true },
                    new TelaBaseModel { Nombre = "EDEN ESTAMPADO",Codigo = GenerateRandomCodes(), Active = true },
                    new TelaBaseModel { Nombre = "MIC MINI FANTASIA",Codigo = GenerateRandomCodes(), Active = true },
                    new TelaBaseModel { Nombre = "J MOVIE",Codigo = GenerateRandomCodes(), Active = true },
                    new TelaBaseModel { Nombre = "JERSEY TECH FIT 140",Codigo = GenerateRandomCodes(), Active = true },
                    new TelaBaseModel { Nombre = "MICROFIBRA EST",Codigo = GenerateRandomCodes(), Active = true }
                };

                dbContext.AddRange(estadosPedido);
                dbContext.SaveChanges();
            }


            var telaCombinacionRepository = services.GetRequiredService<ITelaCombinacionRepository>();
            if (!telaCombinacionRepository.TableNoTracking.Any())
            {
                var estadosPedido = new List<TelaCombinacionModel>
                {
                    new TelaCombinacionModel { Nombre = "No Lleva",Codigo = "0", Active = true },
                    new TelaCombinacionModel { Nombre = "COURO ECOLÓGICO0",Codigo = GenerateRandomCodes(), Active = true },
                    new TelaCombinacionModel { Nombre = "POWERNET LIVIANO",Codigo = GenerateRandomCodes(), Active = true },
                    new TelaCombinacionModel { Nombre = "MICROFIBRA TEXT LIVIANO",Codigo = GenerateRandomCodes(), Active = true },
                    new TelaCombinacionModel { Nombre = "ELASTICA ROBUSTA",Codigo = GenerateRandomCodes(), Active = true },
                    new TelaCombinacionModel { Nombre = "LINO LIVIANO",Codigo = GenerateRandomCodes(), Active = true }
                };

                dbContext.AddRange(estadosPedido);
                dbContext.SaveChanges();
            }


            var bolsilloInteriorRepository = services.GetRequiredService<IBolsilloInteriorRepository>();
            if (!bolsilloInteriorRepository.TableNoTracking.Any())
            {
                var estadosPedido = new List<BolsilloInteriorModel>
                {
                    new BolsilloInteriorModel { Nombre = "No Lleva",Codigo = "0", Active = true },
                    new BolsilloInteriorModel { Nombre = "Dobladillo",Codigo = GenerateRandomCodes(), Active = true },
                    new BolsilloInteriorModel { Nombre = "Ojal",Codigo = GenerateRandomCodes(), Active = true },
                    new BolsilloInteriorModel { Nombre = "Canguro",Codigo = GenerateRandomCodes(), Active = true },
                    new BolsilloInteriorModel { Nombre = "Cremallera",Codigo = GenerateRandomCodes(), Active = true },
                    new BolsilloInteriorModel { Nombre = "Plano",Codigo = GenerateRandomCodes(), Active = true }
                };

                dbContext.AddRange(estadosPedido);
                dbContext.SaveChanges();
            }


            var collaretaRepository = services.GetRequiredService<ICollaretaRepository>();
            if (!collaretaRepository.TableNoTracking.Any())
            {
                var estadosPedido = new List<CollaretaModel>
                {
                    new CollaretaModel { Nombre = "No Lleva",Codigo = "0", Active = true },
                    new CollaretaModel { Nombre = "JACARD MINI PANAL",Codigo = GenerateRandomCodes(), Active = true },
                    new CollaretaModel { Nombre = "POWERNET LIVIANO",Codigo = GenerateRandomCodes(), Active = true },
                    new CollaretaModel { Nombre = "MIC MINI FANTASIA",Codigo = GenerateRandomCodes(), Active = true },
                    new CollaretaModel { Nombre = "MORLEY",Codigo = GenerateRandomCodes(), Active = true },
                    new CollaretaModel { Nombre = "COROLO",Codigo = GenerateRandomCodes(), Active = true }
                };

                dbContext.AddRange(estadosPedido);
                dbContext.SaveChanges();
            }
            

            var cinturaInteriorRepository = services.GetRequiredService<ICinturaInteriorRepository>();
            if (!cinturaInteriorRepository.TableNoTracking.Any())
            {
                var estadosPedido = new List<CinturaInteriorModel>
                {
                    new CinturaInteriorModel { Nombre = "No Lleva",Codigo = "0", Active = true },
                    new CinturaInteriorModel { Nombre = "MICROFIBRA",Codigo = GenerateRandomCodes(), Active = true },
                    new CinturaInteriorModel { Nombre = "Ojal",Codigo = GenerateRandomCodes(), Active = true },
                    new CinturaInteriorModel { Nombre = "Canguro",Codigo = GenerateRandomCodes(), Active = true },
                    new CinturaInteriorModel { Nombre = "Cremallera",Codigo = GenerateRandomCodes(), Active = true },
                    new CinturaInteriorModel { Nombre = "Plano",Codigo = GenerateRandomCodes(), Active = true }
                };

                dbContext.AddRange(estadosPedido);
                dbContext.SaveChanges();
            }


            var forreriaRepository = services.GetRequiredService<IForreriaRepository>();
            if (!forreriaRepository.TableNoTracking.Any())
            {
                var estadosPedido = new List<ForreriaModel>
                {
                    new ForreriaModel { Nombre = "No Lleva",Codigo = "0", Active = true },
                    new ForreriaModel { Nombre = "JACARD MINI PANAL",Codigo = GenerateRandomCodes(), Active = true },
                    new ForreriaModel { Nombre = "POWERNET LIVIANO",Codigo = GenerateRandomCodes(), Active = true },
                    new ForreriaModel { Nombre = "MIC MINI FANTASIA",Codigo = GenerateRandomCodes(), Active = true },
                    new ForreriaModel { Nombre = "MORLEY",Codigo = GenerateRandomCodes(), Active = true },
                    new ForreriaModel { Nombre = "COROLO",Codigo = GenerateRandomCodes(), Active = true }
                };

                dbContext.AddRange(estadosPedido);
                dbContext.SaveChanges();
            }

            var lazoRepository = services.GetRequiredService<ILazoRepository>();
            if (!lazoRepository.TableNoTracking.Any())
            {
                var estadosPedido = new List<LazoModel>
                {
                    new LazoModel { Nombre = "No Lleva",Codigo = "0", Active = true },
                    new LazoModel { Nombre = "Satén",Codigo = GenerateRandomCodes(), Active = true },
                    new LazoModel { Nombre = "Rosa",Codigo = GenerateRandomCodes(), Active = true },
                    new LazoModel { Nombre = "Terciopelo",Codigo = GenerateRandomCodes(), Active = true },
                    new LazoModel { Nombre = "Algodón",Codigo = GenerateRandomCodes(), Active = true },
                    new LazoModel { Nombre = "Encaje",Codigo = GenerateRandomCodes(), Active = true }
                };

                dbContext.AddRange(estadosPedido);
                dbContext.SaveChanges();
            }


            var vivoRepository = services.GetRequiredService<IVivoRepository>();
            if (!vivoRepository.TableNoTracking.Any())
            {
                var estadosPedido = new List<VivoModel>
                {
                    new VivoModel { Nombre = "No Lleva",Codigo = "0", Active = true },
                    new VivoModel { Nombre = "Tafetán",Codigo = GenerateRandomCodes(), Active = true },
                    new VivoModel { Nombre = "Satén",Codigo = GenerateRandomCodes(), Active = true },
                    new VivoModel { Nombre = "Cuero",Codigo = GenerateRandomCodes(), Active = true },
                    new VivoModel { Nombre = "Algodón",Codigo = GenerateRandomCodes(), Active = true },
                    new VivoModel { Nombre = "Piel sintética",Codigo = GenerateRandomCodes(), Active = true }
                };

                dbContext.AddRange(estadosPedido);
                dbContext.SaveChanges();
            }


            var transferRepository = services.GetRequiredService<ITransferRepository>();
            if (!transferRepository.TableNoTracking.Any())
            {
                var transfer = new TransferModel {Codigo = "Vinilo", Imagen= "https://www.google.com/imgres?imgurl=https%3A%2F%2Flookaside.fbsbx.com%2Flookaside%2Fcrawler%2Fmedia%2F%3Fmedia_id%3D1623412831034706&tbnid=RvHYN8I3ACxd3M&vet=12ahUKEwiR-Jndx62AAxWUObkGHSveAz4QMygCegUIARDBAQ..i&imgrefurl=https%3A%2F%2Fwww.facebook.com%2Fadmitoneoficial%2Fphotos%2Fa.193149390727731%2F1623412831034706%2F%3Ftype%3D3&docid=yewQGcPwkjOJNM&w=800&h=800&q=logo%20admit%20one&ved=2ahUKEwiR-Jndx62AAxWUObkGHSveAz4QMygCegUIARDBAQ", Active = true };

                dbContext.Add(transfer);
                dbContext.SaveChanges();

                transfer.Codigo = transfer.ID_Transfer + transfer.Codigo + _rnd.Next(1, 101);

                dbContext.Update(transfer);
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
        #endregion

        #region Helper
        public static string GenerateRandomCodes() => _rnd.Next().ToString("x").ToUpper();

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

        #endregion

        #region ConfigureExceptions
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Crea una copia de la colección OpenForms
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
            // Crea una copia de la colección OpenForms
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();

            // Cierra todos los formularios abiertos
            foreach (Form form in forms)
            {
                form.Close();
            }

            // Comprueba si la excepción es de SQL Server
            if (e.ExceptionObject is SqlException)
            {
                SqlException sqlEx = e.ExceptionObject as SqlException;
                // Aquí manejas la excepción de SQL Server
                FmError fmError = new(Tools.TypeErrorEnum.SqlConnect);
                fmError.ShowDialog();
            }
            else
            {
                FmError fmError = new(Tools.TypeErrorEnum.Generic);
                fmError.ShowDialog();
            }
        }
        #endregion

    }
}