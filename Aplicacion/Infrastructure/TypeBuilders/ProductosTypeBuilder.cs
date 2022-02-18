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
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Composicion)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.CodigoProducto)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Estampa)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.NombreProducto)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Precio)
                .IsRequired(false)
                .HasColumnType("decimal(18,0)");

            builder.Property(p => p.Tejido)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.TallePrenda)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.TipoProducto)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.ToTable("Producto");
        }

    }
}
