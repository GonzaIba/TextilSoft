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
    public class CompanyAuthenticationTypeBuilder : IEntityTypeConfiguration<CompanyAuthenticationModel>
    {
        public void Configure(EntityTypeBuilder<CompanyAuthenticationModel> builder)
        {
            builder.HasKey(x => x.CompanyAuthenticationId);

            builder.HasOne(p => p.Company)
                .WithOne(p => p.CompanyAuthentication)
                .HasForeignKey<CompanyAuthenticationModel>(p => p.CompanyId);
            
            builder.Property(x => x.UserRequireUniqueEmail)
                .IsRequired(true)
                .HasColumnType("bit");

            builder.Property(x => x.SignInRequireConfirmedAccount)
                .IsRequired(true)
                .HasColumnType("bit");

            builder.Property(x => x.MaxFailedAccessAttempts)
                .IsRequired(true)
                .HasColumnType("int");

            builder.Property(x => x.CanUseLoginAndRegister)
                .IsRequired(true)
                .HasColumnType("bit");

            builder.ToTable("CompanyAuthentication");
        }
    }
}
