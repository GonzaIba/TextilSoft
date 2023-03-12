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
    public class OrdenDeTrabajoFabricaTypeBuilder : IEntityTypeConfiguration<OrdenDeTrabajoFabricaModel>
    {
        public void Configure(EntityTypeBuilder<OrdenDeTrabajoFabricaModel> builder)
        {
            builder.HasKey(p => p.ID_OrdenDeTrabajoFabrica);

            builder.Property(p => p.FechaInicio)
                .IsRequired(true);

            builder.Property(p => p.FechaCerrado)
                .IsRequired(false);

            builder.HasOne(p => p.PedidosFabrica)
                .WithMany(c => c.OrdenDeTrabajoFabrica)
                .HasForeignKey(p => p.ID_PedidoFabrica);

            builder.HasOne(p => p.Sector)
                .WithMany(c => c.OrdenDeTrabajoFabrica)
                .HasForeignKey(p => p.ID_Sector);

            builder.ToTable("OrdenDeTrabajoFabrica");
        }
    }
}
