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
    public class EstadoPedidoFabricaTypeBuilder : IEntityTypeConfiguration<EstadoPedidoFabricaModel>
    {
        public void Configure(EntityTypeBuilder<EstadoPedidoFabricaModel> builder)
        {
            builder.HasKey(e => e.ID_EstadoPedidoFabrica);

            builder.Property(e => e.Estado)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Ignore(e => e.UpdateDate); //Las filas van a ser fijas asi que no se actualizan...
            builder.Ignore(e => e.CreateDate);

            builder.ToTable("EstadoPedidoFabrica");
        }
    }
}
