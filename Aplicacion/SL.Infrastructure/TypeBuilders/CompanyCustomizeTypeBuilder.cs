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
    public class CompanyCustomizeTypeBuilder : IEntityTypeConfiguration<CompanyCustomizeModel>
    {
        public void Configure(EntityTypeBuilder<CompanyCustomizeModel> builder)
        {
            builder.HasKey(x => x.CompanyCustomizeId);

            builder.HasOne(p => p.Company)
                .WithOne(p => p.CompanyCustomize)
                .HasForeignKey<CompanyCustomizeModel>(p => p.CompanyId);

            builder.Property(x => x.CompanyLogo)
                .IsRequired(false)
                .HasColumnType("varchar(max)"); //Puede ser un base 64, una URL, etc... Se valida con REGEX

            builder.Property(x => x.CompanyColor)
                .IsRequired(false)
                .HasColumnType("varchar(50)"); //Puede ser texto, un hexadecimal (30;30;30) o (#303030). Se valida con REGEX

            //builder.Property(x => x.CreatedAt).IsRequired();
            //builder.Property(x => x.UpdatedAt).IsRequired();
            //builder.Property(x => x.CreatedBy).IsRequired();
            //builder.Property(x => x.UpdatedBy).IsRequired();

            builder.ToTable("CompanyCustomize");
        }
    }
}
