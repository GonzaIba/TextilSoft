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
            builder.HasKey(p => p.ID_Empleados);

            builder.Property(p => p.DNI)
                .IsRequired(true);

            builder.Property(p => p.Nombre)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.Property(p => p.Apellido)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.Property(p => p.Residencia)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.Property(p => p.Legajo);

            builder.ToTable("Empleados");
        }
    }
}
