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
    public class SectorTypeBuilder : IEntityTypeConfiguration<SectorModel>
    {
        public void Configure(EntityTypeBuilder<SectorModel> builder)
        {
            builder.HasKey(p => p.ID_Sector);

            builder.Property(p => p.NombreSector)
                .IsRequired(true);

            builder.HasMany(p => p.OrdenDeTrabajo)
                .WithOne(d=>d.Sector)
                .HasForeignKey(p=>p.ID_Sector);

            builder.ToTable("Sector");
        }
    }
}
