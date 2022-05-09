using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Extensions
{
    public static class EntityTypeBuilderExtensions
    {

        public static KeyBuilder IsIdentityAndAutoIncremental(this KeyBuilder propertyBuilder)
        {
            propertyBuilder.Metadata.SetAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            return propertyBuilder;
        }

        
    }
}
