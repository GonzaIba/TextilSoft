using Contracts.Repositories;
using Domain.Models;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml;
using Infrastructure.UoW;
using Contracts.Services;
using Contracts.Controllers;
using UI.TextilSoft.Factory;

namespace UI.TextilSoft.Background
{
    public class TaskResolver : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IControllerFactory _factory;
        public TaskResolver(IServiceProvider serviceProvider,IControllerFactory factory)
        {
            _serviceProvider = serviceProvider;
            _factory = factory;
        }
        private DateTime _lastExecution;
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                //while (!stoppingToken.IsCancellationRequested)
                //{
                //    //await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken); //Agregamos un delay para que no trabe todo el programa
                //    //if (DateTime.Now.Minute % 10 == 0 && _lastExecution.Minute != DateTime.Now.Minute)
                //    //{
                //    //    //Cada 5 minutos ejecutamos las tareas
                //    //    _lastExecution = DateTime.Now;
                //    //    UpdateContext();
                //    //}
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        private void UpdateContext()
        {
            _factory.UpdateServices();
        }
    }
}


/*            
 *            var ctx = _serviceProvider.GetRequiredService<ApplicationDbContext>();

            //var repository = _serviceProvider.GetRequiredService<Contracts.Repositories.IGenericRepository<PedidosModel>>();
            //var entitiesList = ctx.ChangeTracker.Entries().ToList();
            //foreach (var entity in entitiesList)
            //{
            //    entity.Reload();
            //}
            ctx.Dispose();
            //ctx.Dispose();
            //get configuration
            var configuration = _serviceProvider.GetRequiredService<IConfiguration>();

            // Crear un objeto DbContextOptionsBuilder
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            
            // Especificar las opciones para el nuevo objeto DbContext
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlConnection"));

            ctx = new ApplicationDbContext(optionsBuilder.Options);
            using (var context = new ApplicationDbContext(optionsBuilder.Options))
            {
                //get the first item from pedidosmodel
                var pedidos = context.Pedidos.FirstOrDefault();


            }
            var host = Host.CreateDefaultBuilder()
            .ConfigureServices((services) =>
            {
                Program._services.ConfigureIoC(configuration);
                Program._services.AddDbContext<ApplicationDbContext>
                (
                    options => options
                    .UseSqlServer(configuration.GetConnectionString("SqlConnection"), builder =>
                             builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null)));
            })
            .Build();
            //repository.UpdateContext(applicationDbContext);*/