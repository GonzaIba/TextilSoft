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
    public class PedidosTypeBuilder : IEntityTypeConfiguration<PedidosModel>
    {
        public void Configure(EntityTypeBuilder<PedidosModel> builder)
        {
            builder.HasKey(p => p.ID_Pedido);

            builder.Property(p => p.NumeroPedido);

            builder.Property(p => p.EstadoPedido)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.TotalPago)
                .IsRequired(false)
                .HasColumnType("decimal(18,0)");

            builder.Property(p => p.Fecha)
                .IsRequired(false);

            builder.Property(p => p.Seña)
                .IsRequired(false)
                .HasColumnType("decimal(18,0)");

            builder.HasMany(p => p.OrdenDeTrabajo)
                .WithOne(x=>x.Pedidos)
                .HasForeignKey(d=>d.ID_OrdenDeTrabajo);

            builder.HasMany(p => p.DetallePedido)
                .WithOne(x => x.Pedidos)
                .HasForeignKey(d => d.ID_DetallePedido);

            builder.HasMany(p => p.Factura)
                .WithOne(x => x.Pedidos)
                .HasForeignKey(d => d.ID_Factura);
            
            builder.ToTable("Pedidos");
        }
    }
}
