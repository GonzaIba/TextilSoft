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
    public class ForreriaTypeBuilder : IEntityTypeConfiguration<ForreriaModel>
    {
        public void Configure(EntityTypeBuilder<ForreriaModel> builder)
        {
            builder.HasKey(p => p.ID_Forreria);

            builder.Property(p => p.Codigo)
                .IsRequired(true)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Nombre)
                .IsRequired(false)
                .HasColumnType("varchar(100)");

            builder.Ignore(p => p.CreateDate);
            builder.Ignore(p => p.UpdateDate);

            builder.ToTable("Forreria");
        }
    }
}
