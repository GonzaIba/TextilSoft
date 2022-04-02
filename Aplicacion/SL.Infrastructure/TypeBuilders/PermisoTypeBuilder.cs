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
    internal class PermisoTypeBuilder : IEntityTypeConfiguration<PermisoModel>
    {
        public void Configure(EntityTypeBuilder<PermisoModel> builder)
        {
            builder.HasKey(p => p.Id_Permiso);

            builder.Property(p => p.Permiso)
                .IsRequired(false)
                .HasColumnType("varchar(100)");

            builder.ToTable("Permiso");
        }
    }
}
