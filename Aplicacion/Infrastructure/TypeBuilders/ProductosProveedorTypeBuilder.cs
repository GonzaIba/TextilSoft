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
    public class ProductosProveedorTypeBuilder : IEntityTypeConfiguration<ProductosProveedorModel>
    {
        public void Configure(EntityTypeBuilder<ProductosProveedorModel> builder)
        {
            builder.HasKey(p => p.ID_ProductoProveedor);

            builder.Property(p => p.DNI)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.NombreProducto)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.MarcaTela)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.TipoTela)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Precio)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.CantidadRollos);

            builder.HasOne(p => p.Proveedor)
                .WithMany(x => x.ProductoProveedor)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(p => p.ID_Proveedor);

            builder.ToTable("ProductoProveedor");
        }
    }
}
