using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Infrastructure.TypeBuilders
{
    internal class UsuarioTypeBuilder : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(p => p.Id_Usuario);

            builder.Property(p => p.Nombre)
                .IsRequired(true)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Contraseña)
                .IsRequired(true)
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Email)
                .IsRequired(false)
                .HasColumnType("varchar(200)");
            
            builder.Property(p => p.DNI)
                .IsRequired(true)
                .HasColumnType("int");

            builder.Property(p => p.AccesFailed)
                .IsRequired(true)
                .HasColumnType("int");

            builder.Property(p => p.EmailConfirmado)
                .IsRequired(true)
                .HasColumnType("bit");

            builder.Property(p => p.DateTimeEmail)
                .IsRequired(false)
                .HasColumnType("datetime");

            builder.Property(p => p.NumeroTeléfono)
                .IsRequired(false)
                .HasColumnType("varchar(50)");

            builder.ToTable("usuarios");
        }
    }
}
