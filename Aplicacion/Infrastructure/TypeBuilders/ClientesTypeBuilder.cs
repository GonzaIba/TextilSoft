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
    public class ClientesTypeBuilder : IEntityTypeConfiguration<ClientesModel>   
    {

        public void Configure(EntityTypeBuilder<ClientesModel> builder)
        {
            builder.HasKey(p => p.ID_Cliente);

            builder.Property(p => p.DNI)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Nombre)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Apellido)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.EstadoCliente)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.FechaNac)
                .IsRequired(false)
                .HasColumnType("datetime");

            builder.Property(p => p.Mail)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Telefono)
                .IsRequired(false)
                .HasColumnType("int");

            builder.Property(p => p.Residencia)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.ToTable("Cliente");
        }
    }
}
