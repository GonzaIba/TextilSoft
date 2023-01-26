using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class GenericEntity : IGenericEntity
    {
        public DateTime CreateDate { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }
        public bool Active { get; set; }
    }
}
