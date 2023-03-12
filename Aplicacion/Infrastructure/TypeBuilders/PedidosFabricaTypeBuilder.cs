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
    public class PedidosFabricaTypeBuilder : IEntityTypeConfiguration<PedidosFabricaModel>
    {
        public void Configure(EntityTypeBuilder<PedidosFabricaModel> builder)
        {
            builder.HasKey(p => p.ID_PedidosFabrica);

            builder.Property(p => p.Detalle)
                .IsRequired(false)
                .HasColumnType("varchar(100)");

            builder.HasMany(p => p.OrdenDeTrabajoFabrica)
                .WithOne(x => x.PedidosFabrica)
                .HasForeignKey(d => d.ID_OrdenDeTrabajoFabrica);

            builder.HasMany(p => p.DetallePedidosFabrica)
                .WithOne(x => x.PedidosFabrica)
                .HasForeignKey(d => d.ID_DetallePedidosFabrica);

            builder.HasOne(p => p.Empleados)
                .WithMany(x => x.PedidosFabrica)
                .HasForeignKey(d => d.ID_Empleados);

            builder.ToTable("PedidosFabrica");
        }
    }
}
