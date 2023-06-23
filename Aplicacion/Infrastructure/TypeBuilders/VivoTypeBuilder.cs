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
    public class VivoTypeBuilder : IEntityTypeConfiguration<VivoModel>
    {
        public void Configure(EntityTypeBuilder<VivoModel> builder)
        {
            builder.HasKey(p => p.ID_Vivo);

            builder.Property(p => p.Codigo)
                .IsRequired(true)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Nombre)
                .IsRequired(false)
                .HasColumnType("varchar(100)");

            builder.Ignore(p => p.CreateDate);
            builder.Ignore(p => p.UpdateDate);

            builder.ToTable("Vivo");
        }
    }
}
