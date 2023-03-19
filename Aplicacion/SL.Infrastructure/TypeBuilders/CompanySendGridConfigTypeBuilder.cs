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
    public class CompanySendGridConfigTypeBuilder : IEntityTypeConfiguration<CompanySendGridConfigModel>
    {
        public void Configure(EntityTypeBuilder<CompanySendGridConfigModel> builder)
        {
            builder.HasKey(p => p.CompanySendGridConfigId);

            builder.Property(p => p.From)
                .IsRequired(true)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.ApiKey)
                .IsRequired(true)
                .HasColumnType("varchar(500)");

            builder.Property(p => p.ApiKeyId)
                .IsRequired(true)
                .HasColumnType("varchar(500)");

            builder.Property(p => p.DisplayName)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.HasOne(p => p.Company)
                .WithOne(p => p.CompanySendGridConfig)
                .HasForeignKey<CompanySendGridConfigModel>(p => p.CompanyId);
            
            builder.ToTable("CompanySendGridConfiguration");
        }
    }
}
