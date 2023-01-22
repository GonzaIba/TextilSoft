using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Infrastructure.TypeBuilders
{
    public class CompanyPasswordConfigTypeBuilder : IEntityTypeConfiguration<CompanyPasswordConfigModel>
    {
        public void Configure(EntityTypeBuilder<CompanyPasswordConfigModel> builder)
        {
            builder.HasKey(x => x.CompanyPasswordConfigId);

            builder.HasOne(p => p.CompanyAuthentication)
                .WithOne(p => p.CompanyPasswordConfig)
                .HasForeignKey<CompanyPasswordConfigModel>(p => p.CompanyAuthenticationId);

            builder.Property(x => x.RequireDigit)
                .IsRequired(true)
                .HasColumnType("bit");

            builder.Property(x => x.RequireUppercase)
                .IsRequired(true)
                .HasColumnType("bit");

            builder.Property(x => x.RequireLowercase)
                .IsRequired(true)
                .HasColumnType("bit");

            builder.Property(x => x.RequireNonAlphanumeric)
                .IsRequired(true)
                .HasColumnType("bit");

            builder.Property(x => x.CountLength)
                .IsRequired(true)
                .HasColumnType("int");

            builder.ToTable("CompanyPasswordConfig");
        }
    }
}
