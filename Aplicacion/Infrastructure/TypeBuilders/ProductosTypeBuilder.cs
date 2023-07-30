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

            builder.Property(p => p.CodigoProducto)
                .IsRequired(true)
                .HasDefaultValueSql("NEWID()");

            builder.Property(p => p.Composicion)
                .IsRequired(true)
                .HasColumnType("varchar(100)");
            
            builder.HasOne(p => p.TipoPrenda)
                .WithMany()
                .HasForeignKey(p => p.ID_TipoPrenda)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(p => p.TelaBase)
                .WithMany()
                .HasForeignKey(p => p.ID_TelaBase)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.TelaCombinacion)
                .WithMany()
                .HasForeignKey(p => p.ID_TelaCombinacion)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.BolsilloInterior)
                .WithMany()
                .HasForeignKey(p => p.ID_BolsilloInterior)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.CinturaInterior)
                .WithMany()
                .HasForeignKey(p => p.ID_CinturaInterior)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Collareta)
                .WithMany()
                .HasForeignKey(p => p.ID_Collareta)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Lazo)
                .WithMany()
                .HasForeignKey(p => p.ID_Lazo)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Vivo)
                .WithMany()
                .HasForeignKey(p => p.ID_Vivo)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Forreria)
                .WithMany()
                .HasForeignKey(p => p.ID_Forreria)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.Descripcion)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Precio)
                .IsRequired(true)
                .HasColumnType("decimal(18,0)");

            builder.Property(p => p.TallePrenda)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.ImagenPrenda)
                .IsRequired(true)
                .HasColumnType("varchar(MAX)");

            builder.Property(p => p.Stock)
                .IsRequired(true)
                .HasDefaultValue(0);

            builder.ToTable("Producto");
        }

    }
}
