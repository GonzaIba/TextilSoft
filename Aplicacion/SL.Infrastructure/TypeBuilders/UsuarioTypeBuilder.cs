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

            builder.ToTable("usuarios");
        }
    }
}
