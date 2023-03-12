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
    public class OrdenDeTrabajoTypeBuilder : IEntityTypeConfiguration<OrdenDeTrabajoModel>
    {
        public void Configure(EntityTypeBuilder<OrdenDeTrabajoModel> builder)
        {
            builder.HasKey(p => p.ID_OrdenDeTrabajo);

            builder.Property(p => p.FechaInicio)
                .IsRequired(true);

            builder.Property(p => p.FechaCerrado)
                .IsRequired(false);

            builder.HasOne(p => p.Pedidos)
                .WithMany(c => c.OrdenDeTrabajo)
                .HasForeignKey(p => p.ID_Pedido);

            builder.HasOne(p => p.Sector)
                .WithMany(c => c.OrdenDeTrabajo)
                .HasForeignKey(p => p.ID_Sector);

            builder.ToTable("OrdenDeTrabajo");
        }
    }
}
