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
    public class HistorialPedidosTypeBuilder : IEntityTypeConfiguration<HistorialPedidosModel>
    {
        public void Configure(EntityTypeBuilder<HistorialPedidosModel> builder)
        {
            builder.HasKey(p => p.ID_HistorialPedidos);

            builder.Property(p => p.Fecha)
                .IsRequired(true)
                .HasDefaultValueSql("GETDATE()");

            builder.HasOne(hp => hp.Pedidos)
                .WithMany(p => p.HistorialPedidos)
                .HasForeignKey(hp => hp.ID_Pedido)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(hp => hp.EstadoPedido)
                .WithMany(ep => ep.HistorialPedidos)
                .HasForeignKey(hp => hp.ID_EstadoPedido)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Ignore(hp => hp.UpdateDate);
            builder.Ignore(hp => hp.CreateDate);
            builder.Ignore(hp => hp.Active);

            builder.ToTable("HistorialPedidos");
        }
    }
}
