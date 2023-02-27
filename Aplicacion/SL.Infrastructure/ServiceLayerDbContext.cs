using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using SL.Domain.Model;
using SL.Helper.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SL.Infrastructure
{
    public class ServiceLayerDbContext : DbContext
    {
        public ServiceLayerDbContext()
        {

        }

        public ServiceLayerDbContext(DbContextOptions<ServiceLayerDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                var config = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json")
                  .Build();

                options.UseSqlServer(config.GetConnectionString("SqlConnectionServiceLayer"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly)
                        .SetPropertyDefaultSqlValue("CreateDate", "getdate()")
                        .SetPropertyDefaultValue<bool>("Active", true)
                        .SetPropertyQueryFilter("Active", true);
        }

        public override int SaveChanges()
        {
            SetUpdateDateOnModifiedEntries();
            SetDeletePermisoEntries();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetUpdateDateOnModifiedEntries();
            SetDeletePermisoEntries();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetUpdateDateOnModifiedEntries()
        {
            var modifiedEntries = ChangeTracker
                .Entries()
                .Where(e => e.Metadata.FindProperty("UpdateDate") != null &&
                            e.State == EntityState.Modified);

            foreach (var modifiedEntry in modifiedEntries)
                modifiedEntry.Property("UpdateDate").CurrentValue = DateTime.Now;
        }
        private void SetDeletePermisoEntries()
        {
            var modifiedEntries = ChangeTracker
                .Entries()
                .Where(e => e.Metadata.FindProperty("nombre") != null && e.Entity is PermisoModel &&
                            e.State == EntityState.Modified);

            foreach (var modifiedEntry in modifiedEntries)
            {
                if(modifiedEntry.Property("nombre").CurrentValue.ToString() == "Administrador")
                    throw new Exception("No se puede eliminar un permiso base del sistema");
            }
        }
    }
}
