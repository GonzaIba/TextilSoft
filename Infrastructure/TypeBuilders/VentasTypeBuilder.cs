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
    public class VentasTypeBuilder : IEntityTypeConfiguration<VentasModel>
    {
        public void Configure(EntityTypeBuilder<VentasModel> builder)
        {
            builder.HasKey(p => p.ID_Venta);

            builder.Property(p => p.CapitalRecibido)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.Property(p => p.FechaVenta)
                .IsRequired(false);

            builder.Property(p => p.Descripcion)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.HasOne(p => p.Producto)
                .WithMany(x=>x.Venta)
                .HasForeignKey(p=>p.ID_Producto);

            builder.ToTable("Venta");
        }
    }
}
