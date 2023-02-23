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

namespace UI.TextilSoft.Background
{
    public class TaskResolver : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        public TaskResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        private DateTime _lastExecution;
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken); //Agregamos un delay para que no trabe todo el programa
                    //if (DateTime.Now.Minute % 1 == 0 && _lastExecution.Minute != DateTime.Now.Minute)
                    //{
                    //    //Cada 5 minutos ejecutamos las tareas
                        _lastExecution = DateTime.Now;
                        UpdateContext();
                    //}
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        private void UpdateContext()
        {
            var ctx = _serviceProvider.GetRequiredService<ApplicationDbContext>();

            var repository = _serviceProvider.GetRequiredService<IGenericRepository<PedidosModel>>();
            var configuration = _serviceProvider.GetRequiredService<IConfiguration>();
            //var entitiesList = ctx.ChangeTracker.Entries().ToList();
            //foreach (var entity in entitiesList)
            //{
            //    entity.Reload();
            //}
            ctx.Dispose();
            //ctx.Dispose();

            // Crear un objeto DbContextOptionsBuilder
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Especificar las opciones para el nuevo objeto DbContext
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlConnection"));

            var applicationDbContext = new ApplicationDbContext(optionsBuilder.Options);
            repository.UpdateContext();
            var UnitOfWork = _serviceProvider.GetRequiredService<IUnitOfWork>();
            var repositorio = UnitOfWork.GetRepository<IPedidosRepository>();
            repositorio = new PedidosRepository(applicationDbContext);

            var repo = _serviceProvider.GetRequiredService<IPedidosRepository>();
            repo = repositorio;
            var r = repo.Get().FirstOrDefault();
            //repository = new GenericRepository<PedidosModel>(applicationDbContext);
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