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
    class FacturasTypeBuilder : IEntityTypeConfiguration<FacturasModel>
    {
        public void Configure(EntityTypeBuilder<FacturasModel> builder)
        {
            builder.HasKey(p => p.ID_Factura);

            builder.Property(p => p.NumeroFactura)
                .IsRequired(false);

            builder.Property(p => p.Fecha)
                .IsRequired(false);

            builder.Property(p => p.TotalPago)
                .IsRequired(false)
                .HasColumnType("decimal(18,0)");

            builder.HasOne(p => p.Pedidos)
                .WithOne()
                .HasForeignKey<FacturasModel>(p=>p.ID_Pedido);

            builder.ToTable("Factura");
        }
    }
}
