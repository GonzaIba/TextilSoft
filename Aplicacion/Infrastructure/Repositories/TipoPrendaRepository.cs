using Contracts.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TipoPrendaRepository : GenericRepository<TipoPrendaModel>, ITipoPrendaRepository
    {
        public TipoPrendaRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
