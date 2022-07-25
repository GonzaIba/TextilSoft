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
    public class CompanyTypeBuilder : IEntityTypeConfiguration<CompanyModel>
    {
        public void Configure(EntityTypeBuilder<CompanyModel> builder)
        {
            builder.HasKey(p => p.CompanyId);

            builder.Property(p => p.CompanyName)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.CompanyLocation)
                .IsRequired(true)
                .HasColumnType("varchar(200)");

            builder.Property(p => p.CompanyCuil)
                .IsRequired(true)
                .HasColumnType("varchar(20)");

            builder.Property(p => p.CompanyPhone)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.CompanyMail)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.CompanyApiKey)
                .IsRequired(true)
                .HasColumnType("varchar(64)");

            builder.ToTable("Company");
        }
    }
}
