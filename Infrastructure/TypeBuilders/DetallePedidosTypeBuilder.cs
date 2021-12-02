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

            builder.Property(p => p.Cantidad)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.HasOne(p => p.Pedidos)//si yo selecciono una propiedad de otra clase, el siguiente metodo apunta a la otra clase
                .WithMany(c=>c.DetallePedido)
                .HasForeignKey(p => p.ID_Pedido);

            builder.HasOne(p => p.Producto)
                .WithMany(c => c.DetallePedido)
                .HasForeignKey(p => p.ID_Producto);

            builder.ToTable("DetallePedido");
        }
    }
}
