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
    public class DetallePedidosTypeBuilder : IEntityTypeConfiguration<DetallePedidosModel>
    {
        public void Configure(EntityTypeBuilder<DetallePedidosModel> builder)
        {
            builder.HasKey(p => p.ID_DetallePedido);

            builder.Property(p => p.Detalle)
                .HasColumnType("varchar(500)")
                .IsRequired(false);

            builder.Property(p => p.Color)
                .HasColumnType("varchar(500)")
                .IsRequired(true);

            builder.Property(p => p.Cantidad)
                .IsRequired(true);

            builder.HasOne(p => p.Pedidos)//si yo selecciono una propiedad de otra clase, el siguiente metodo apunta a la otra clase
                .WithMany(c => c.DetallePedido)
                .HasForeignKey(p => p.ID_Pedido);

            builder.HasOne(p => p.Producto)
                .WithMany(c => c.DetallePedido)
                .HasForeignKey(p => p.ID_Producto);

            builder.HasOne(p => p.Transfer)
                .WithMany(c=>c.DetallePedido)
                .HasForeignKey(p => p.ID_Transfer);

            builder.Ignore(p => p.CreateDate);

            builder.Ignore(p => p.UpdateDate);

            builder.Ignore(p => p.Active);

            builder.ToTable("DetallePedido");
        }
    }
}
