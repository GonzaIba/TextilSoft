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
    internal class Permiso_PermisoTypeBuilder : IEntityTypeConfiguration<Permiso_PermisoModel>
    {
        public void Configure(EntityTypeBuilder<Permiso_PermisoModel> builder)
        {
            builder.HasKey(p => p.Id_Permiso_Permiso);

            builder.Property(p => p.Id_Permiso_Hijo)
                .IsRequired(true)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Id_Permiso_Padre)
                .IsRequired(true)
                .HasColumnType("varchar(100)");

            builder.ToTable("Permiso");
        }
    }
}
