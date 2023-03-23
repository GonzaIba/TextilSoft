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
    public class TransferTypeBuilder : IEntityTypeConfiguration<TransferModel>
    {
        public void Configure(EntityTypeBuilder<TransferModel> builder)
        {
            builder.HasKey(p => p.ID_Transfer);

            builder.Property(p => p.Codigo)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Imagen)
                .IsRequired(true)
                .HasColumnType("varchar(MAX)");

            builder.ToTable("Transfer");
        }
    }
}
