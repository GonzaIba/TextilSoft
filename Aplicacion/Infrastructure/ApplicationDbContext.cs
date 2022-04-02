using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SL.Helper.Extensions;
using Domain.Models;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        //Este constructor se utiliza para hacer una migracion a la base de datos
        //Se utiliza code first
        //public ApplicationDbContext()
        //{

        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContextOptions"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    if (!options.IsConfigured)
        //    {
        //        options.UseSqlServer("Data Source=localhost;Initial Catalog=DBProyectoTextil;User ID=testUser2;Password=1234;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<GenericEntity>(); //Ignoramos la entidad generica para que no se guarde en la bdd


            base.OnModelCreating(modelBuilder);


            // Set Decimal Precision
            //var decimals = modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(p => p.ClrType == typeof(decimal));
            //const string DecimalConfig = "decimal(28, 15)";
            //foreach (var property in decimals)
            //    property.SetColumnType(DecimalConfig);


            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly)
                .SetPropertyDefaultSqlValue("CreateDate", "getdate()")
                .SetPropertyDefaultValue<bool>("Active", true)
                .SetPropertyQueryFilter("Active", true);

            //Este metodo configura las entidades para cuando se quiere usar una de respaldo ( ej tenemos _date y date para protegerlo/respaldarlo)
            //.UsePropertyAccessMode(PropertyAccessMode.Field);

            //Este metodo no incluye a la clase especificada al contexto. Podria usarse para reglas de negocio en momento de ejecucion?
            //.Ignore<ProveedoresModel>();
        }
        
        public override int SaveChanges()
        {
            //SetUpdateDateOnModifiedEntries();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //SetUpdateDateOnModifiedEntries();
            return base.SaveChangesAsync(cancellationToken);
        }

        //private void SetUpdateDateOnModifiedEntries()
        //{
        //    var modifiedEntries = ChangeTracker
        //        .Entries()
        //        .Where(e => e.Metadata.FindProperty("UpdateDate") != null &&
        //                    e.State == EntityState.Modified); //Obtengo la propiedad UpdateDate con el estado modificado (Update) y le seteo la fecha y hora actual

        //    foreach (var modifiedEntry in modifiedEntries)
        //    {
        //        modifiedEntry.Property("UpdateDate").CurrentValue = DateTime.Now;
        //    }
        //}

    }
}
