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
    internal class Usuario_PermisoTypeBuilder : IEntityTypeConfiguration<Usuario_PermisoModel>
    {
        public void Configure(EntityTypeBuilder<Usuario_PermisoModel> builder)
        {
            builder.HasKey(p => new { p.Id_Permiso, p.Id_Usuario });

            builder.HasOne(p => p.UsuarioModel)
                   .WithMany(p => p.Usuario_Permisos)
                   .HasForeignKey(p => p.Id_Usuario);

            builder.HasOne(p => p.PermisoModel)
                   .WithMany(p => p.Usuario_Permisos)
                   .HasForeignKey(p => p.Id_Permiso);

            builder.ToTable("usuarios_permisos");
        }
    }
}
