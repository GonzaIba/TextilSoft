using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.TypeBuilders
{
    public class ProductoDefectoTypeBuilder : IEntityTypeConfiguration<ProductoDefectoModel>
    {
        public void Configure(EntityTypeBuilder<ProductoDefectoModel> builder)
        {
            builder.HasKey(p => p.ID_ProductoDefecto);

            builder.Property(p => p.Cantidad)
                .IsRequired(true)
                .HasColumnType("int");

            builder.Property(p => p.Motivo)
                .IsRequired(true)
                .HasColumnType("varchar(500)");

            builder.HasOne(p => p.Producto)
                .WithMany(c => c.ProductoDefectos)
                .HasForeignKey(p => p.ID_Producto);

            builder.Ignore(p => p.UpdateDate);

            builder.ToTable("ProductoDefecto");
        }
    }
}
