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

            builder.Property(p => p.SubTotal)
                .IsRequired(true)
                .HasColumnType("decimal(18,0)");

            builder.Property(p => p.Fecha)
                .IsRequired(true);

            builder.Property(p => p.Seña)
                .IsRequired(false)
                .HasColumnType("decimal(18,0)");

            builder.HasMany(p => p.OrdenDeTrabajo)
                .WithOne(x=>x.Pedidos)
                .HasForeignKey(d=>d.ID_OrdenDeTrabajo);

            builder.HasMany(p => p.DetallePedido)
                .WithOne(x => x.Pedidos)
                .HasForeignKey(d => d.ID_Pedido);

            builder.HasMany(p => p.Factura) //No tiene sentido la relacion de muchos a uno
                .WithOne(x => x.Pedidos)    //Pero por algún motivo me generaba una columna rara... revisar
                .HasForeignKey(d => d.ID_Factura);
            //Edit: estaba bien esta relación.

            builder.HasMany(p => p.HistorialPedidos)
                .WithOne(hp => hp.Pedidos)
                .HasForeignKey(hp => hp.ID_Pedido);

            builder.HasOne(p => p.EstadoPedido)
                .WithMany(x => x.Pedidos)
                .HasForeignKey(d => d.ID_EstadoPedido);

            builder.HasOne(p => p.Clientes)
                .WithMany(x => x.Pedidos)
                .HasForeignKey(d => d.ID_Cliente);

            builder.HasOne(p => p.Empleados)
                .WithMany(x => x.Pedidos)
                .HasForeignKey(d => d.ID_Empleados);

            builder.ToTable("Pedidos");
        }
    }
}
