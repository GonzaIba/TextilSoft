using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.TypeBuilders
{
    public class ProductosTypeBuilder : IEntityTypeConfiguration<ProductosModel>
    {
        public void Configure(EntityTypeBuilder<ProductosModel> builder)
        {
            builder.HasKey(p => p.ID_Producto);

            builder.Property(p => p.Color)
                .IsRequired(true)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Composicion)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.CodigoProducto)
                .IsRequired(true)
                .HasDefaultValueSql("NEWID()");

            builder.Property(p => p.Estampa)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.NombreProducto)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Precio)
                .IsRequired(true)
                .HasColumnType("decimal(18,0)");

            builder.Property(p => p.Tejido)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.TallePrenda)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.TipoProducto)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Stock)
                .IsRequired(true)
                .HasDefaultValue(0);

            builder.ToTable("Producto");
        }

    }
}
