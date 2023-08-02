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
    public class DetallePedidosFabricaTypeBuilder : IEntityTypeConfiguration<DetallePedidosFabricaModel>
    {
        public void Configure(EntityTypeBuilder<DetallePedidosFabricaModel> builder)
        {
            builder.HasKey(p => p.ID_DetallePedidosFabrica);

            builder.Property(p => p.Detalle)
                .HasColumnType("varchar(500)")
                .IsRequired(false);

            builder.Property(p => p.Color)
                .HasColumnType("varchar(500)")
                .IsRequired(true);

            builder.Property(p => p.Cantidad)
                .IsRequired(true);

            builder.HasOne(p => p.PedidosFabrica)
                .WithMany(c => c.DetallePedidosFabrica)
                .HasForeignKey(p => p.ID_PedidosFabrica);

            builder.HasOne(p => p.Producto)
                .WithMany(c => c.DetallePedidosFabrica)
                .HasForeignKey(p => p.ID_Producto);

            builder.HasOne(p => p.Transfer)
                .WithMany(c => c.DetallePedidoFabrica)
                .HasForeignKey(p => p.ID_Transfer);

            builder.Ignore(p => p.CreateDate);

            builder.Ignore(p => p.UpdateDate);

            builder.Ignore(p => p.Active);

            builder.ToTable("DetallePedidoFabricas");
        }
    }
}
