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
    public class TelaCombinacionTypeBuilder : IEntityTypeConfiguration<TelaCombinacionModel>
    {
        public void Configure(EntityTypeBuilder<TelaCombinacionModel> builder)
        {
            builder.HasKey(p => p.ID_TelaCombinacion);

            builder.Property(p => p.Codigo)
                .IsRequired(true)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Nombre)
                .IsRequired(false)
                .HasColumnType("varchar(100)");

            builder.Ignore(p => p.CreateDate);
            builder.Ignore(p => p.UpdateDate);

            builder.ToTable("TelaCombinacion");
        }
    }
}
