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
    public class EmpleadosTypeBuilder : IEntityTypeConfiguration<EmpleadosModel>
    {
        public void Configure(EntityTypeBuilder<EmpleadosModel> builder)
        {
            builder.Property(p => p.ID_Empleados)
                .HasDefaultValueSql("NEWID()");

            builder.Property(p => p.DNI)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Nombre)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Apellido)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Residencia)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Legajo)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.ToTable("Empleados");
        }
    }
}
