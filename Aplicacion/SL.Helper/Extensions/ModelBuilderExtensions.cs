using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder SetPropertyDefaultSqlValue(this ModelBuilder builder, string propertyName, string value)
        {
            foreach (var entityType in builder.Model.GetEntityTypes().Where(e => e.FindProperty(propertyName) != null))
            {
                builder.Entity(entityType.ClrType).Property(propertyName).HasDefaultValueSql(value);
            }
            return builder;
        }

        public static ModelBuilder SetPropertyDefaultValue<TProperty>(this ModelBuilder builder, string propertyName, object value)
        {
            foreach (var entityType in builder.Model.GetEntityTypes().Where(
                                                    e => e.FindProperty(propertyName) != null
                                                    && e.FindProperty(propertyName).ClrType == typeof(TProperty)))
            {
                builder.Entity(entityType.ClrType).Property(propertyName).HasDefaultValue(value);
            }
            return builder;
        }

        public static ModelBuilder SetPropertyQueryFilter<TProperty>(this ModelBuilder builder, string propertyName, TProperty value)
        {
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var property = entityType.FindProperty(propertyName);
                if (property != null && property.ClrType == typeof(TProperty) && entityType.BaseType == null)
                {
                    var parameter = Expression.Parameter(entityType.ClrType, entityType.ClrType.Name);
                    var body = Expression.Property(parameter, property.PropertyInfo);
                    var constant = Expression.Constant(value, typeof(TProperty));
                    var filter = Expression.Lambda(Expression.Equal(body, constant), parameter);
                    entityType.SetQueryFilter(filter);
                }
            }
            return builder;
        }

        public static ModelBuilder ConfigureGenericProperties(this ModelBuilder builder)
        {
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                builder.Entity(entityType.ClrType).Property("Active").HasColumnType("bit").IsRequired(true);
                builder.Entity(entityType.ClrType).Property("CreateDate").HasColumnType("datetime").IsRequired(true);
                builder.Entity(entityType.ClrType).Property("UpdateDate").HasColumnType("datetime").IsRequired(false);
            }
            return builder;
        }



        public static ModelBuilder SetQueryFilter<TEntity>(this ModelBuilder builder, Expression<Func<TEntity, bool>> filter) where TEntity : class
        {
            builder.Model.FindEntityType(typeof(TEntity))?.SetQueryFilter(filter);
            return builder;
        }

        public static ModelBuilder RemoveQueryFilter<TEntity>(this ModelBuilder builder)
        {
            builder.Model.FindEntityType(typeof(TEntity))?.SetQueryFilter(null);
            return builder;
        }

        public static ModelBuilder RemoveQueryFilter(this ModelBuilder builder, params Type[] types)
        {
            foreach (var type in types)
            {
                builder.Model.FindEntityType(type)?.SetQueryFilter(null);
            }
            return builder;
        }

        /// <summary>
        /// Convierte las claves primarias en identity column autoincremental
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static ModelBuilder SetAutoIncrementPK(this ModelBuilder builder)
        {
            foreach (var entityType in builder.Model.GetEntityTypes().Where(e => e.FindPrimaryKey() != null)) //Primero obtenemos la clase que tenga una PK
            {
                var PK = entityType.FindPrimaryKey(); //Obtenemos la PK de la clase

                //Si PK no es int continuar el foreach (Por ejemplo, ID_Empleados no pasa este if...)
                if (PK.Properties.First().ClrType != typeof(int)) continue;

                builder.Model.FindEntityType(entityType.ClrType)
                             .FindProperty(PK.Properties.First().Name)
                             .SetAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            }

            return builder;

            //if (PK.Properties.First().ClrType != typeof(int)) continue;
        }


    }
}
