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
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
        //    : base(dbContextOptions)
        //{

        //}

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

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly)
                        .SetPropertyDefaultSqlValue("CreateDate", "getdate()")
                        .SetPropertyDefaultValue<bool>("Active", true)
                        .SetPropertyQueryFilter("Active", true)
                        .SetAutoIncrementPK();

            //base.OnConfiguring(modelBuilder);//Aca podemos configurar el warning (por ej) de ef



            //A la propiedad Active setearle por defecto el valor true
            //modelBuilder.SetPropertyDefaultValue<bool>("Active", true);




            //Este metodo configura las entidades para cuando se quiere usar una de respaldo ( ej tenemos _date y date para protegerlo/respaldarlo)
            //.UsePropertyAccessMode(PropertyAccessMode.Field);

            //Este metodo no incluye a la clase especificada al contexto. Podria usarse para reglas de negocio en momento de ejecucion?
        }

        public override int SaveChanges()
        {
            //SetUpdateDateOnModifiedEntries();
            SetActiveOnDeleteEmployees();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //SetUpdateDateOnModifiedEntries();
            SetActiveOnDeleteEmployees();
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
        
        //Aca prohibimos que elimine un registro de la tabla empleados... (Solo deberían usar Active)
        private void SetActiveOnDeleteEmployees()
        {
            var modifiedEntries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is EmpleadosModel &&
                            e.State == EntityState.Deleted); //Busco en el contexto la entidad EmpleadosModel y si el estado es Delete

            foreach (var modifiedEntry in modifiedEntries)
            {
                modifiedEntry.State = EntityState.Unchanged;
                throw new Exception("No se puede eliminar un registro de la tabla Empleados");
            }
        }

    }
}
