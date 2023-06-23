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
    public class TipoPrendaTypeBuilder : IEntityTypeConfiguration<TipoPrendaModel>
    {
        public void Configure(EntityTypeBuilder<TipoPrendaModel> builder)
        {
            builder.HasKey(p => p.ID_TipoPrenda);

            builder.Property(p => p.TipoPrenda)
                .IsRequired(true)
                .HasColumnType("varchar(100)");

            builder.Ignore(p => p.CreateDate);
            builder.Ignore(p => p.UpdateDate);

            builder.ToTable("TipoPrenda");
        }
    }
}
