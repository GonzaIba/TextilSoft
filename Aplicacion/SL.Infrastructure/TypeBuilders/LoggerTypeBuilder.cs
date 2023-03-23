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
    public class LoggerTypeBuilder : IEntityTypeConfiguration<LoggerModel>
    {
        public void Configure(EntityTypeBuilder<LoggerModel> builder)
        {
            builder.HasKey(p => p.LoggerId);

            builder.Property(p => p.Date)
                .IsRequired(true)
                .HasDefaultValueSql("GETDATE()");

            builder.Property(p => p.Thread)
                .IsRequired(true)
                .HasColumnType("varchar(MAX)");

            builder.Property(p => p.Level)
                .IsRequired(true)
                .HasColumnType("varchar(500)");

            builder.Property(p => p.Logger)
                .IsRequired(true)
                .HasColumnType("varchar(500)");

            builder.Property(p => p.Message)
                .IsRequired(true)
                .HasColumnType("varchar(MAX)");

            builder.Property(p => p.Exception)
                .IsRequired(false)
                .HasColumnType("varchar(MAX)");

            builder.HasOne(p => p.Company)
                .WithMany(p => p.Loggers)
                .HasForeignKey(p => p.CompanyId);

            builder.ToTable("Logs");
        }
    }
}
