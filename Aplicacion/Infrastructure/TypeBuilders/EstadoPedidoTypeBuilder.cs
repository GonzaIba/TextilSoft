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
    public class EstadoPedidoTypeBuilder : IEntityTypeConfiguration<EstadoPedidoModel>
    {
        public void Configure(EntityTypeBuilder<EstadoPedidoModel> builder)
        {
            builder.HasKey(e => e.ID_EstadoPedido);

            builder.Property(e => e.Estado)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.ToTable("EstadoPedido");
        }
    }
}
