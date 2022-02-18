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
    class ProveedoresTypeBuilder : IEntityTypeConfiguration<ProveedoresModel>
    {

        public void Configure(EntityTypeBuilder<ProveedoresModel> builder)
        {
            builder.HasKey(p => p.ID_Proveedor);

            builder.Property(p => p.DNI)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.EstadoProveedor)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.FechaNac);

            builder.Property(p => p.LugarEmpresa)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Mail)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Nombre)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.ToTable("Proveedor");
        }
    }
    
}
